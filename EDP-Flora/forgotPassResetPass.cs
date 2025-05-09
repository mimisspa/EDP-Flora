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

namespace EDP_Flora
{
    public partial class forgotPassResetPass : Form
    {
        private string _username;
        public forgotPassResetPass(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextBox.Text.Trim();
            string confirmPassword = confirmPasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter both fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();

                    string query = "UPDATE admin SET password = @password WHERE username = @username";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@password", newPassword);
                        cmd.Parameters.AddWithValue("@username", _username);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OpenForm(new login());
                        }
                        else
                        {
                            MessageBox.Show($"No account was updated. Please verify that the username '{_username}' exists.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new forgotPassVerify());
        }

        private void instructionLogin_Click(object sender, EventArgs e)
        {

        }
    }
 }

