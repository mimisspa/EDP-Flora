using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using Microsoft.VisualBasic;
using System.IO;

namespace EDP_Flora
{
    public partial class admin : Form
    {
        string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        public admin()
        {
            InitializeComponent();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            LoadAdminTable();
            adminDataGridView.CellClick += adminDataGridView_CellClick;

        }

        private void navbarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
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
            OpenForm(new sale());
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenForm(new supplier());
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "INSERT INTO admin (username, password, security_answer) VALUES (@username, @password, @security_answer)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text); 
                cmd.Parameters.AddWithValue("@security_answer", securityAnsTextBox.Text);

                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i + " record(s) inserted");
            }
        }

        private void adminDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void LoadAdminTable()
        {
            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM admin";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                adminDataGridView.DataSource = dt;
            }
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadAdminTable();
        }

        private void tablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = adminDataGridView.Rows[e.RowIndex];
                usernameTextBox.Text = row.Cells["username"].Value?.ToString() ?? string.Empty;
                passwordTextBox.Text = row.Cells["password"].Value?.ToString() ?? string.Empty;
                securityAnsTextBox.Text = row.Cells["security_answer"].Value?.ToString() ?? string.Empty;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (adminDataGridView.CurrentRow != null)
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    string query = "UPDATE admin SET username = @username, password = @password, security_answer = @security_answer WHERE admin_id = @admin_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", passwordTextBox.Text); 
                    cmd.Parameters.AddWithValue("@security_answer", securityAnsTextBox.Text);
                    cmd.Parameters.AddWithValue("@admin_id", adminDataGridView.CurrentRow.Cells["admin_id"].Value);

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

                string query = "DELETE FROM admin WHERE admin_id = @admin_id";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@admin_id", adminDataGridView.CurrentRow.Cells[0].Value);

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

                string query = "SELECT * FROM admin WHERE username LIKE @username";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", "%" + searchTextBox.Text + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                adminDataGridView.DataSource = table;
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            string fileName = Interaction.InputBox("Enter a name for the CSV file (without extension):", "Name your file", "admin");

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
            ExportDataGridViewToCSV(adminDataGridView, filePath);
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
    }
}
