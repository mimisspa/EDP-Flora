using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace EDP_Flora
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void quantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {
            LoadProductTable();
            productDataGridView.CellClick += productGridView_CellContentClick;
            LoadCategoryIDs();

        }

        private void LoadProductTable()
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                productDataGridView.DataSource = dt;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "INSERT INTO products (productName, price, stock, categoryID) VALUES (@productName, @price, @stock, @categoryID)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@productName", productNameTextBox.Text);
                cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                cmd.Parameters.AddWithValue("@stock", stockTextBox.Text);
                cmd.Parameters.AddWithValue("@categoryID", categoryIDComboBox.SelectedValue);


                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record(s) inserted");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            if (productDataGridView.CurrentRow != null)
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string query = "UPDATE products SET productName = @productName, price = @price, stock = @stock, categoryID = @categoryID WHERE productID = @productID";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@productName", productNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@price", priceTextBox.Text);
                    cmd.Parameters.AddWithValue("@stock", stockTextBox.Text);
                    cmd.Parameters.AddWithValue("@categoryID", categoryIDComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@productID", productDataGridView.CurrentRow.Cells["productID"].Value);

                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result + " record(s) updated");
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to update.");
            }
        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productDataGridView.Rows[e.RowIndex];
                productNameTextBox.Text = row.Cells["productName"].Value?.ToString() ?? string.Empty;
                priceTextBox.Text = row.Cells["price"].Value?.ToString() ?? string.Empty;
                stockTextBox.Text = row.Cells["stock"].Value?.ToString() ?? string.Empty;
                if (row.Cells["categoryID"].Value != null && categoryIDComboBox.DataSource != null)
                {
                    categoryIDComboBox.SelectedValue = row.Cells["categoryID"].Value;
                }
            }
        }

        private void LoadCategoryIDs()
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "SELECT categoryID FROM category";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                categoryIDComboBox.DataSource = dt;
                categoryIDComboBox.DisplayMember = "categoryID";
                categoryIDComboBox.ValueMember = "categoryID";
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadProductTable();
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            if (productDataGridView.CurrentRow != null)
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    string query = "DELETE FROM products WHERE productID = @productID";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@productID", productDataGridView.CurrentRow.Cells["productID"].Value);
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result + " record(s) deleted");
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to delete.");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "SELECT * FROM products WHERE productName LIKE @productName";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@productName", "%" + searchTextBox.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                productDataGridView.DataSource = table;
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string fileName = Interaction.InputBox("Enter a name for the CSV file (without extension):", "Name your file", "products");

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Export cancelled. Filename cannot be empty.", "Export Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName + ".csv");

            if (File.Exists(filePath))
            {
                var result = MessageBox.Show("File already exists. Overwrite?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
            }
            ExportDataGridViewToCSV(productDataGridView, filePath);
        }

        private void ExportDataGridViewToCSV(DataGridView dgv, string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sw.Write(dgv.Columns[i].HeaderText);
                        if (i < dgv.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dgv.Columns.Count; i++)
                            {
                                var cellValue = row.Cells[i].Value?.ToString()?.Replace(",", " ");
                                sw.Write(cellValue);
                                if (i < dgv.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Data exported successfully to Desktop.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new admin());
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new customer());
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new category());
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new order());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new product());    
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new sale());
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new supplier());
        }
    }
}
