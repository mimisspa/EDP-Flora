namespace EDP_Flora
{
    partial class sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sale));
            this.crudPanel = new System.Windows.Forms.Panel();
            this.paymentDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentDateLabel = new System.Windows.Forms.Label();
            this.orderNoLabel = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.orderNoTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryLabel = new System.Windows.Forms.Label();
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
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.crudPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // crudPanel
            // 
            this.crudPanel.BackColor = System.Drawing.Color.SeaShell;
            this.crudPanel.Controls.Add(this.paymentMethodComboBox);
            this.crudPanel.Controls.Add(this.paymentDateDatePicker);
            this.crudPanel.Controls.Add(this.paymentDateLabel);
            this.crudPanel.Controls.Add(this.orderNoLabel);
            this.crudPanel.Controls.Add(this.totalAmountTextBox);
            this.crudPanel.Controls.Add(this.totalAmountLabel);
            this.crudPanel.Controls.Add(this.orderNoTextBox);
            this.crudPanel.Controls.Add(this.quantityLabel);
            this.crudPanel.Controls.Add(this.updateBtn);
            this.crudPanel.Controls.Add(this.addBtn);
            this.crudPanel.Controls.Add(this.deleteBtn);
            this.crudPanel.Location = new System.Drawing.Point(250, 446);
            this.crudPanel.Name = "crudPanel";
            this.crudPanel.Size = new System.Drawing.Size(906, 193);
            this.crudPanel.TabIndex = 48;
            // 
            // paymentDateDatePicker
            // 
            this.paymentDateDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDateDatePicker.Location = new System.Drawing.Point(660, 109);
            this.paymentDateDatePicker.Name = "paymentDateDatePicker";
            this.paymentDateDatePicker.Size = new System.Drawing.Size(224, 22);
            this.paymentDateDatePicker.TabIndex = 35;
            // 
            // paymentDateLabel
            // 
            this.paymentDateLabel.AutoSize = true;
            this.paymentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentDateLabel.Location = new System.Drawing.Point(562, 112);
            this.paymentDateLabel.Name = "paymentDateLabel";
            this.paymentDateLabel.Size = new System.Drawing.Size(92, 16);
            this.paymentDateLabel.TabIndex = 34;
            this.paymentDateLabel.Text = "Payment Date";
            this.paymentDateLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // orderNoLabel
            // 
            this.orderNoLabel.AutoSize = true;
            this.orderNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNoLabel.Location = new System.Drawing.Point(179, 62);
            this.orderNoLabel.Name = "orderNoLabel";
            this.orderNoLabel.Size = new System.Drawing.Size(92, 16);
            this.orderNoLabel.TabIndex = 32;
            this.orderNoLabel.Text = "Order Number";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountTextBox.Location = new System.Drawing.Point(277, 109);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(225, 22);
            this.totalAmountTextBox.TabIndex = 31;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.AutoSize = true;
            this.totalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountLabel.Location = new System.Drawing.Point(185, 112);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(86, 16);
            this.totalAmountLabel.TabIndex = 30;
            this.totalAmountLabel.Text = "Total Amount";
            // 
            // orderNoTextBox
            // 
            this.orderNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNoTextBox.Location = new System.Drawing.Point(277, 59);
            this.orderNoTextBox.Name = "orderNoTextBox";
            this.orderNoTextBox.Size = new System.Drawing.Size(225, 22);
            this.orderNoTextBox.TabIndex = 29;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(546, 62);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(108, 16);
            this.quantityLabel.TabIndex = 28;
            this.quantityLabel.Text = "Payment Method";
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
            // tablePanel
            // 
            this.tablePanel.BackColor = System.Drawing.Color.SeaShell;
            this.tablePanel.Controls.Add(this.inventoryDataGridView);
            this.tablePanel.Controls.Add(this.inventoryLabel);
            this.tablePanel.Controls.Add(this.searchLabel);
            this.tablePanel.Controls.Add(this.searchTextBox);
            this.tablePanel.Location = new System.Drawing.Point(250, 22);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(906, 398);
            this.tablePanel.TabIndex = 47;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventoryDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesID,
            this.OrderID,
            this.TotalAmount,
            this.PaymentMethod,
            this.PaymentDate});
            this.inventoryDataGridView.Location = new System.Drawing.Point(25, 56);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.Size = new System.Drawing.Size(860, 316);
            this.inventoryDataGridView.TabIndex = 28;
            // 
            // SalesID
            // 
            this.SalesID.HeaderText = "Sales ID";
            this.SalesID.Name = "SalesID";
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order Number";
            this.OrderID.Name = "OrderID";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.Name = "PaymentMethod";
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Payment Date";
            this.PaymentDate.Name = "PaymentDate";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(20, 19);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(71, 25);
            this.inventoryLabel.TabIndex = 20;
            this.inventoryLabel.Text = "Sales";
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
            this.navbarPanel.TabIndex = 46;
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
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(660, 60);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(224, 24);
            this.paymentMethodComboBox.TabIndex = 36;
            // 
            // sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.crudPanel);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.navbarPanel);
            this.Name = "sale";
            this.Text = "Flora - Sales";
            this.crudPanel.ResumeLayout(false);
            this.crudPanel.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.navbarPanel.ResumeLayout(false);
            this.navbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel crudPanel;
        private System.Windows.Forms.Label paymentDateLabel;
        private System.Windows.Forms.Label orderNoLabel;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.TextBox orderNoTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.Label inventoryLabel;
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
        private System.Windows.Forms.DateTimePicker paymentDateDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
    }
}