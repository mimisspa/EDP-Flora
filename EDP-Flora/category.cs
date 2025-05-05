using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Flora
{
    public partial class category : Form
    {
        public category() => InitializeComponent();
        private void LoadForm(Form form)
        {
            navbarPanel.Controls.Clear();
            form.TopLevel = false; // Makes the form a child of the panel
            form.FormBorderStyle = FormBorderStyle.None; // Removes form borders
            form.Dock = DockStyle.Fill; // Ensures it fills the panel
            navbarPanel.Controls.Add(form); // Adds the form to the panel
            form.Show(); // Displays the form
        }

        private void inventory_Load(object sender, EventArgs e)
        {

        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new admin());
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new customer());
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new category());
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new order());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new product());
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new sale());
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new supplier());
        }
    }
}
