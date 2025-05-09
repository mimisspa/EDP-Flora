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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EDP_Flora
{
    public partial class forgotPassVerify : Form
    {
        public forgotPassVerify()
        {
            InitializeComponent();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string answer = securityAnswerTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Please enter both username and security answer.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string conString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM admin WHERE username = @username AND security_answer = @answer";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@answer", answer);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Verification successful! You may now reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OpenForm(new forgotPassResetPass(username));
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or security answer.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void forgotPassVerify_Load(object sender, EventArgs e)
        {
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            OpenForm(new login());
        }

        private void instructionLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
