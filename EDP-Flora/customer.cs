using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using Microsoft.VisualBasic;
using System.IO;

namespace EDP_Flora
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            LoadCustomerTable();
            customerDataGridView.CellClick += customerDataGridView_CellContentClick;

        }

        private void LoadCustomerTable()
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM customers";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                customerDataGridView.DataSource = dt;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "INSERT INTO customers (name, email, phone, address) VALUES (@name, @email, @phone, @address)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record(s) inserted");
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadCustomerTable();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            if (customerDataGridView.CurrentRow != null)
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string query = "UPDATE customers SET name = @name, email = @email, phone = @phone, address = @address WHERE customersID = @customersID";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                    cmd.Parameters.AddWithValue("@customersID", customerDataGridView.CurrentRow.Cells["customersID"].Value);

                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result + " record(s) updated");
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to update.");
            }
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customerDataGridView.Rows[e.RowIndex];
                nameTextBox.Text = row.Cells["name"].Value?.ToString() ?? string.Empty;
                emailTextBox.Text = row.Cells["email"].Value?.ToString() ?? string.Empty;
                phoneTextBox.Text = row.Cells["phone"].Value?.ToString() ?? string.Empty;
                addressTextBox.Text = row.Cells["address"].Value?.ToString() ?? string.Empty;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "DELETE FROM customers WHERE customersID = @customersID";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@customersID", customerDataGridView.CurrentRow.Cells[0].Value);

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record(s) deleted");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "SELECT * FROM customers WHERE name LIKE @name";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", "%" + searchTextBox.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                customerDataGridView.DataSource = table;
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string fileName = Interaction.InputBox("Enter a name for the CSV file (without extension):", "Name your file", "customer");

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
            ExportDataGridViewToCSV(customerDataGridView, filePath);
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
            this.Hide();
            OpenForm(new admin());
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new customer());
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new category());
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new order());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new product());
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new sale());
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new supplier());
        }
    }
}
