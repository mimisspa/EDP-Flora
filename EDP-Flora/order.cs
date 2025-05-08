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
    public partial class order : Form
    {

        public order()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderLabel_Click(object sender, EventArgs e)
        {

        }

        private void order_Load(object sender, EventArgs e)
        {
            LoadOrderTable();
            orderGridView.CellClick += orderGridView_CellContentClick;
            LoadProductIDs();
            LoadOrderColumns();
        }

        private void LoadOrderTable()
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM orders";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                orderGridView.DataSource = dt;
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadOrderTable();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "INSERT INTO orders (orderID, productID, quantity) VALUES (@orderID, @productID, @quantity)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@orderID", orderIDTextBox.Text);
                cmd.Parameters.AddWithValue("@productID", productComboBox.SelectedValue);
                cmd.Parameters.AddWithValue("@quantity", quantityTextBox.Text);

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record(s) inserted");
            }
        }

        private void LoadProductIDs()
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "SELECT productID FROM products";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                productComboBox.DataSource = dt;
                productComboBox.DisplayMember = "productID";
                productComboBox.ValueMember = "productID";
            }
            productComboBox.SelectedIndex = -1;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            if (orderGridView.CurrentRow != null)
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string query = "UPDATE orders SET productID = @productID, quantity = @quantity WHERE orderID = @orderID";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@productID", productComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@quantity", quantityTextBox.Text);
                    cmd.Parameters.AddWithValue("@orderID", orderGridView.CurrentRow.Cells["orderID"].Value);

                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result + " record(s) updated");
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to update.");
            }
        }

        private void orderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = orderGridView.Rows[e.RowIndex];
                orderIDTextBox.Text = row.Cells["orderID"].Value?.ToString() ?? string.Empty;
                productComboBox.SelectedValue = row.Cells["productID"].Value?.ToString() ?? string.Empty;
                quantityTextBox.Text = row.Cells["quantity"].Value?.ToString() ?? string.Empty;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "DELETE FROM orders WHERE orderID = @orderID";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@orderID", orderGridView.CurrentRow.Cells[0].Value);

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record(s) deleted");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager
                .ConnectionStrings["MySqlConnection"]
                .ConnectionString;
            string userInput = searchTextBox.Text.Trim();

            string selectedColumn = columnFilterComboBox.SelectedItem as string;
            bool hasValidSelection =
                !string.IsNullOrEmpty(selectedColumn)
                && columnFilterComboBox.Items.Contains(selectedColumn);

            string query;
            if (hasValidSelection)
            {
                query = $"SELECT * FROM orders WHERE `{selectedColumn}` LIKE @search";
            }
            else
            {
                var cols = columnFilterComboBox.Items
                            .Cast<string>()
                            .Select(col => $"`{col}` LIKE @search");
                query = "SELECT * FROM orders WHERE " + string.Join(" OR ", cols);
            }

            using (var con = new MySqlConnection(conString))
            using (var cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@search", "%" + userInput + "%");

                var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                orderGridView.DataSource = table;
            }
        }

        private void LoadOrderColumns()
        {
            columnFilterComboBox.Items.Clear();

            string conString = ConfigurationManager
                .ConnectionStrings["MySqlConnection"]
                .ConnectionString;

            using (var con = new MySqlConnection(conString))
            using (var cmd = new MySqlCommand("SHOW COLUMNS FROM orders", con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string colName = reader.GetString(0);
                        columnFilterComboBox.Items.Add(colName);
                    }
                }
            }

            columnFilterComboBox.SelectedIndex = -1;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string fileName = Interaction.InputBox("Enter a name for the CSV file (without extension):", "Name your file", "order");

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
            ExportDataGridViewToCSV(orderGridView, filePath);
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForm = new login();
            loginForm.Show();
            loginForm.FormClosed += (s, args) => this.Close();
        }
    }
}
