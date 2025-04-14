namespace EDP_Flora
{
    partial class customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.crudPanel = new System.Windows.Forms.Panel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.saleBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.crudPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // crudPanel
            // 
            this.crudPanel.BackColor = System.Drawing.Color.SeaShell;
            this.crudPanel.Controls.Add(this.phoneLabel);
            this.crudPanel.Controls.Add(this.phoneTextBox);
            this.crudPanel.Controls.Add(this.addressLabel);
            this.crudPanel.Controls.Add(this.addressTextBox);
            this.crudPanel.Controls.Add(this.nameLabel);
            this.crudPanel.Controls.Add(this.nameTextBox);
            this.crudPanel.Controls.Add(this.emailLabel);
            this.crudPanel.Controls.Add(this.updateBtn);
            this.crudPanel.Controls.Add(this.addBtn);
            this.crudPanel.Controls.Add(this.deleteBtn);
            this.crudPanel.Controls.Add(this.emailTextBox);
            this.crudPanel.Location = new System.Drawing.Point(249, 448);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(906, 193);
            this.crudPanel.TabIndex = 36;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(587, 70);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(70, 16);
            this.phoneLabel.TabIndex = 34;
            this.phoneLabel.Text = "Phone No.";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(660, 67);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(225, 22);
            this.phoneTextBox.TabIndex = 33;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(596, 114);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 16);
            this.addressLabel.TabIndex = 32;
            this.addressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(660, 111);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(225, 22);
            this.addressTextBox.TabIndex = 31;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(254, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 16);
            this.nameLabel.TabIndex = 30;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(304, 70);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(225, 22);
            this.nameTextBox.TabIndex = 29;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(257, 117);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 16);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "Email";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.updateBtn.Location = new System.Drawing.Point(25, 84);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(107, 27);
            this.updateBtn.TabIndex = 23;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.addBtn.Location = new System.Drawing.Point(25, 32);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 27);
            this.addBtn.TabIndex = 22;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.deleteBtn.Location = new System.Drawing.Point(25, 135);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(107, 27);
            this.deleteBtn.TabIndex = 24;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(304, 114);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(225, 22);
            this.emailTextBox.TabIndex = 26;
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.SeaShell;
            this.tablePanel.Controls.Add(this.customerDataGridView);
            this.tablePanel.Controls.Add(this.customerLabel);
            this.tablePanel.Controls.Add(this.searchLabel);
            this.tablePanel.Controls.Add(this.searchTextBox);
            this.tablePanel.Location = new System.Drawing.Point(249, 24);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(906, 398);
            this.tablePanel.TabIndex = 35;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerAddress,
            this.CustomerName,
            this.CustomerEmail});
            this.customerDataGridView.Location = new System.Drawing.Point(25, 56);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(860, 316);
            this.customerDataGridView.TabIndex = 28;
            // 
            // CustomerID
            // 
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.HeaderText = "Address";
            this.CustomerAddress.Name = "CustomerAddress";
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.HeaderText = "Email";
            this.CustomerEmail.Name = "CustomerEmail";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(20, 19);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(112, 25);
            this.customerLabel.TabIndex = 20;
            this.customerLabel.Text = "Customer";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(604, 26);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(50, 16);
            this.searchLabel.TabIndex = 27;
            this.searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(660, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(225, 22);
            this.searchTextBox.TabIndex = 26;
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.SeaShell;
            this.navbarPanel.Controls.Add(this.logoutBtn);
            this.navbarPanel.Controls.Add(this.supplierBtn);
            this.navbarPanel.Controls.Add(this.saleBtn);
            this.navbarPanel.Controls.Add(this.productBtn);
            this.navbarPanel.Controls.Add(this.orderBtn);
            this.navbarPanel.Controls.Add(this.inventoryBtn);
            this.navbarPanel.Controls.Add(this.customerBtn);
            this.navbarPanel.Controls.Add(this.adminBtn);
            this.navbarPanel.Controls.Add(this.logo);
            this.navbarPanel.Location = new System.Drawing.Point(0, 0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(219, 661);
            this.navbarPanel.TabIndex = 34;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Maroon;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.SeaShell;
            this.logoutBtn.Location = new System.Drawing.Point(27, 581);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(161, 35);
            this.logoutBtn.TabIndex = 29;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // supplierBtn
            // 
            this.supplierBtn.BackColor = System.Drawing.Color.MistyRose;
            this.supplierBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.supplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supplierBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierBtn.ForeColor = System.Drawing.Color.Maroon;
            this.supplierBtn.Location = new System.Drawing.Point(27, 460);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(161, 35);
            this.supplierBtn.TabIndex = 28;
            this.supplierBtn.Text = "Supplier";
            this.supplierBtn.UseVisualStyleBackColor = false;
            // 
            // saleBtn
            // 
            this.saleBtn.BackColor = System.Drawing.Color.MistyRose;
            this.saleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleBtn.ForeColor = System.Drawing.Color.Maroon;
            this.saleBtn.Location = new System.Drawing.Point(27, 408);
            this.saleBtn.Name = "saleBtn";
            this.saleBtn.Size = new System.Drawing.Size(161, 35);
            this.saleBtn.TabIndex = 27;
            this.saleBtn.Text = "Sales";
            this.saleBtn.UseVisualStyleBackColor = false;
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.MistyRose;
            this.productBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBtn.ForeColor = System.Drawing.Color.Maroon;
            this.productBtn.Location = new System.Drawing.Point(27, 356);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(161, 35);
            this.productBtn.TabIndex = 26;
            this.productBtn.Text = "Product";
            this.productBtn.UseVisualStyleBackColor = false;
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.MistyRose;
            this.orderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.ForeColor = System.Drawing.Color.Maroon;
            this.orderBtn.Location = new System.Drawing.Point(27, 303);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(161, 35);
            this.orderBtn.TabIndex = 25;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = false;
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.BackColor = System.Drawing.Color.MistyRose;
            this.inventoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.Color.Maroon;
            this.inventoryBtn.Location = new System.Drawing.Point(27, 249);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(161, 35);
            this.inventoryBtn.TabIndex = 24;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = false;
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.MistyRose;
            this.customerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBtn.ForeColor = System.Drawing.Color.Maroon;
            this.customerBtn.Location = new System.Drawing.Point(27, 195);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(161, 35);
            this.customerBtn.TabIndex = 23;
            this.customerBtn.Text = "Customer";
            this.customerBtn.UseVisualStyleBackColor = false;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.MistyRose;
            this.adminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.Maroon;
            this.adminBtn.Location = new System.Drawing.Point(27, 142);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(161, 35);
            this.adminBtn.TabIndex = 22;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(64, 43);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.logo.TabIndex = 21;
            this.logo.TabStop = false;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.crudPanel);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.navbarPanel);
            this.Name = "customer";
            this.Text = "Flora - Customer";
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button saleBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.PictureBox logo;
    }
}