namespace EDP_Flora
{
    partial class order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order));
            this.tablePanel = new System.Windows.Forms.Panel();
            this.exportBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.orderLabel = new System.Windows.Forms.Label();
            this.navbarPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.saleBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.crudPanel = new System.Windows.Forms.Panel();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productIDLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.crudPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.SeaShell;
            this.tablePanel.Controls.Add(this.exportBtn);
            this.tablePanel.Controls.Add(this.reloadBtn);
            this.tablePanel.Controls.Add(this.searchBtn);
            this.tablePanel.Controls.Add(this.searchLabel);
            this.tablePanel.Controls.Add(this.searchTextBox);
            this.tablePanel.Controls.Add(this.orderGridView);
            this.tablePanel.Controls.Add(this.orderLabel);
            this.tablePanel.Location = new System.Drawing.Point(250, 22);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(906, 399);
            this.tablePanel.TabIndex = 41;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.DarkSalmon;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.Snow;
            this.exportBtn.Location = new System.Drawing.Point(778, 360);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(107, 27);
            this.exportBtn.TabIndex = 36;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.MistyRose;
            this.reloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadBtn.ForeColor = System.Drawing.Color.Maroon;
            this.reloadBtn.Location = new System.Drawing.Point(25, 360);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(107, 27);
            this.reloadBtn.TabIndex = 35;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.MistyRose;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Maroon;
            this.searchBtn.Location = new System.Drawing.Point(814, 23);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(71, 23);
            this.searchBtn.TabIndex = 34;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(526, 26);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(50, 16);
            this.searchLabel.TabIndex = 33;
            this.searchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(582, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(225, 22);
            this.searchTextBox.TabIndex = 32;
            // 
            // orderGridView
            // 
            this.orderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(25, 53);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.Size = new System.Drawing.Size(860, 301);
            this.orderGridView.TabIndex = 29;
            this.orderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGridView_CellContentClick);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(20, 19);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(71, 25);
            this.orderLabel.TabIndex = 20;
            this.orderLabel.Text = "Order";
            this.orderLabel.Click += new System.EventHandler(this.orderLabel_Click);
            // 
            // navbarPanel
            // 
            this.navbarPanel.BackColor = System.Drawing.Color.SeaShell;
            this.navbarPanel.Controls.Add(this.logoutBtn);
            this.navbarPanel.Controls.Add(this.supplierBtn);
            this.navbarPanel.Controls.Add(this.saleBtn);
            this.navbarPanel.Controls.Add(this.productBtn);
            this.navbarPanel.Controls.Add(this.orderBtn);
            this.navbarPanel.Controls.Add(this.categoryBtn);
            this.navbarPanel.Controls.Add(this.customerBtn);
            this.navbarPanel.Controls.Add(this.adminBtn);
            this.navbarPanel.Controls.Add(this.logo);
            this.navbarPanel.Location = new System.Drawing.Point(0, 0);
            this.navbarPanel.Name = "navbarPanel";
            this.navbarPanel.Size = new System.Drawing.Size(219, 661);
            this.navbarPanel.TabIndex = 40;
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
            this.supplierBtn.Click += new System.EventHandler(this.supplierBtn_Click);
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
            this.saleBtn.Click += new System.EventHandler(this.saleBtn_Click);
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
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
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
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackColor = System.Drawing.Color.MistyRose;
            this.categoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.categoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ForeColor = System.Drawing.Color.Maroon;
            this.categoryBtn.Location = new System.Drawing.Point(27, 249);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Size = new System.Drawing.Size(161, 35);
            this.categoryBtn.TabIndex = 24;
            this.categoryBtn.Text = "Category";
            this.categoryBtn.UseVisualStyleBackColor = false;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
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
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
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
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
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
            // crudPanel
            // 
            this.crudPanel.BackColor = System.Drawing.Color.SeaShell;
            this.crudPanel.Controls.Add(this.orderIDLabel);
            this.crudPanel.Controls.Add(this.orderIDTextBox);
            this.crudPanel.Controls.Add(this.productComboBox);
            this.crudPanel.Controls.Add(this.productIDLabel);
            this.crudPanel.Controls.Add(this.quantityLabel);
            this.crudPanel.Controls.Add(this.updateBtn);
            this.crudPanel.Controls.Add(this.addBtn);
            this.crudPanel.Controls.Add(this.deleteBtn);
            this.crudPanel.Controls.Add(this.quantityTextBox);
            this.crudPanel.Location = new System.Drawing.Point(250, 447);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(906, 193);
            this.crudPanel.TabIndex = 42;
            // 
            // productComboBox
            // 
            this.productComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(287, 111);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(224, 24);
            this.productComboBox.TabIndex = 31;
            // 
            // productIDLabel
            // 
            this.productIDLabel.AutoSize = true;
            this.productIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLabel.Location = new System.Drawing.Point(211, 117);
            this.productIDLabel.Name = "productIDLabel";
            this.productIDLabel.Size = new System.Drawing.Size(69, 16);
            this.productIDLabel.TabIndex = 30;
            this.productIDLabel.Text = "Product ID";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(599, 65);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(55, 16);
            this.quantityLabel.TabIndex = 28;
            this.quantityLabel.Text = "Quantity";
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
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(660, 62);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(225, 22);
            this.quantityTextBox.TabIndex = 26;
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDLabel.Location = new System.Drawing.Point(225, 65);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(54, 16);
            this.orderIDLabel.TabIndex = 33;
            this.orderIDLabel.Text = "OrderID";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTextBox.Location = new System.Drawing.Point(286, 62);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(225, 22);
            this.orderIDTextBox.TabIndex = 32;
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.crudPanel);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.navbarPanel);
            this.Name = "order";
            this.Text = "Flora - Order";
            this.Load += new System.EventHandler(this.order_Load);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Panel navbarPanel;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button saleBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.Label productIDLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.TextBox orderIDTextBox;
    }
}