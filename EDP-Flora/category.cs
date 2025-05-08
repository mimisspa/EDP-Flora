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
using MySql.Data.MySqlClient;
using System.Configuration;
using Microsoft.VisualBasic;
using System.IO;


namespace EDP_Flora
{
    public partial class category : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public category()
        {
            InitializeComponent();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            LoadCategoryTable();
            categoryDataGridView.CellClick += categoryDataGridView_CellContentClick;
            LoadCategoryColumns();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void LoadCategoryTable()
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM category";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                categoryDataGridView.DataSource = dt;
            }
        }

        private void categoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = categoryDataGridView.Rows[e.RowIndex];
                nameTextBox.Text = row.Cells["categoryName"].Value?.ToString() ?? string.Empty;
                descriptionTextBox.Text = row.Cells["description"].Value?.ToString() ?? string.Empty;
            }
        }

        private void tablePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "INSERT INTO category (categoryName, description) VALUES (@categoryName, @description)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@categoryName", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record(s) inserted");
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadCategoryTable();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (categoryDataGridView.CurrentRow != null)
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string query = "UPDATE category SET categoryName = @categoryName, description = @description WHERE categoryID = @categoryID";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@categoryName", nameTextBox.Text); 
                    cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                    cmd.Parameters.AddWithValue("@categoryID", categoryDataGridView.CurrentRow.Cells["categoryID"].Value);

                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result + " record(s) updated");
                }
            }
            else
            {
                MessageBox.Show("No row selected. Please select a row to update.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "DELETE FROM category WHERE categoryID = @categoryID";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@categoryID", categoryDataGridView.CurrentRow.Cells[0].Value);

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record(s) deleted");
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string fileName = Interaction.InputBox("Enter a name for the CSV file (without extension):", "Name your file", "category");

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
            ExportDataGridViewToCSV(categoryDataGridView, filePath);
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
                query = $"SELECT * FROM category WHERE `{selectedColumn}` LIKE @search";
            }
            else
            {
                var cols = columnFilterComboBox.Items
                            .Cast<string>()
                            .Select(col => $"`{col}` LIKE @search");
                query = "SELECT * FROM category WHERE " + string.Join(" OR ", cols);
            }

            using (var con = new MySqlConnection(conString))
            using (var cmd = new MySqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@search", "%" + userInput + "%");

                var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                categoryDataGridView.DataSource = table;
            }
        }

        private void LoadCategoryColumns()
        {
            columnFilterComboBox.Items.Clear();

            string conString = ConfigurationManager
                .ConnectionStrings["MySqlConnection"]
                .ConnectionString;

            using (var con = new MySqlConnection(conString))
            using (var cmd = new MySqlCommand("SHOW COLUMNS FROM category", con))
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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

