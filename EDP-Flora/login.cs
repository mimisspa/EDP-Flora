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


namespace EDP_Flora
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;database=floweryflowers;uid=root;password= ;";
        MySqlConnection connection;

        private void InitializeConnection()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
