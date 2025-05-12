namespace InventoryManagement
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.AddRowBtn = new System.Windows.Forms.Button();
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.RemoveStockBtn = new System.Windows.Forms.Button();
            this.AddStockBtn = new System.Windows.Forms.Button();
            this.RowInput = new System.Windows.Forms.Panel();
            this.RowMenExitBtn = new System.Windows.Forms.Button();
            this.ConfirmRowBtn = new System.Windows.Forms.Button();
            this.SupplierInput = new System.Windows.Forms.TextBox();
            this.SupplierText = new System.Windows.Forms.Label();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.PriceText = new System.Windows.Forms.Label();
            this.QuantityInput = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.Label();
            this.CategoryInput = new System.Windows.Forms.TextBox();
            this.CategoryText = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StockIncrement = new System.Windows.Forms.Panel();
            this.CurrentQuant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseAddStockMenu = new System.Windows.Forms.Button();
            this.AddStock = new System.Windows.Forms.Button();
            this.NameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StockAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.CSVExport = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TypeDropdown = new System.Windows.Forms.ComboBox();
            this.GenReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.RowInput.SuspendLayout();
            this.StockIncrement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(583, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(595, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "Inventory Management System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataView.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataView.Location = new System.Drawing.Point(339, 138);
            this.DataView.Name = "DataView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Pressio No. 52", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataView.Size = new System.Drawing.Size(1035, 455);
            this.DataView.TabIndex = 1;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRowBtn.Location = new System.Drawing.Point(21, 73);
            this.AddRowBtn.Name = "AddRowBtn";
            this.AddRowBtn.Size = new System.Drawing.Size(242, 62);
            this.AddRowBtn.TabIndex = 2;
            this.AddRowBtn.Text = "Add Row";
            this.AddRowBtn.UseVisualStyleBackColor = false;
            this.AddRowBtn.Click += new System.EventHandler(this.AddRowBtn_Click);
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.BackColor = System.Drawing.Color.LightPink;
            this.DeleteRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRowBtn.Location = new System.Drawing.Point(21, 149);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(242, 62);
            this.DeleteRowBtn.TabIndex = 3;
            this.DeleteRowBtn.Text = "Delete Row";
            this.DeleteRowBtn.UseVisualStyleBackColor = false;
            this.DeleteRowBtn.Click += new System.EventHandler(this.DeleteRowBtn_Click);
            // 
            // RemoveStockBtn
            // 
            this.RemoveStockBtn.BackColor = System.Drawing.Color.LightPink;
            this.RemoveStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveStockBtn.Location = new System.Drawing.Point(21, 316);
            this.RemoveStockBtn.Name = "RemoveStockBtn";
            this.RemoveStockBtn.Size = new System.Drawing.Size(242, 62);
            this.RemoveStockBtn.TabIndex = 4;
            this.RemoveStockBtn.Text = "Decrement Stock";
            this.RemoveStockBtn.UseVisualStyleBackColor = false;
            this.RemoveStockBtn.Click += new System.EventHandler(this.RemoveStockBtn_Click);
            // 
            // AddStockBtn
            // 
            this.AddStockBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddStockBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockBtn.Location = new System.Drawing.Point(21, 233);
            this.AddStockBtn.Name = "AddStockBtn";
            this.AddStockBtn.Size = new System.Drawing.Size(242, 62);
            this.AddStockBtn.TabIndex = 5;
            this.AddStockBtn.Text = "Increment Stock";
            this.AddStockBtn.UseVisualStyleBackColor = false;
            this.AddStockBtn.Click += new System.EventHandler(this.AddStockBtn_Click);
            // 
            // RowInput
            // 
            this.RowInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RowInput.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RowInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RowInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RowInput.Controls.Add(this.RowMenExitBtn);
            this.RowInput.Controls.Add(this.ConfirmRowBtn);
            this.RowInput.Controls.Add(this.SupplierInput);
            this.RowInput.Controls.Add(this.SupplierText);
            this.RowInput.Controls.Add(this.PriceInput);
            this.RowInput.Controls.Add(this.PriceText);
            this.RowInput.Controls.Add(this.QuantityInput);
            this.RowInput.Controls.Add(this.QuantityText);
            this.RowInput.Controls.Add(this.CategoryInput);
            this.RowInput.Controls.Add(this.CategoryText);
            this.RowInput.Controls.Add(this.NameInput);
            this.RowInput.Controls.Add(this.NameText);
            this.RowInput.Controls.Add(this.label1);
            this.RowInput.Location = new System.Drawing.Point(591, 138);
            this.RowInput.Name = "RowInput";
            this.RowInput.Size = new System.Drawing.Size(566, 476);
            this.RowInput.TabIndex = 6;
            this.RowInput.Visible = false;
            this.RowInput.Paint += new System.Windows.Forms.PaintEventHandler(this.RowInput_Paint);
            this.RowInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RowInput_MouseDown_1);
            this.RowInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RowInput_MouseMove);
            this.RowInput.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RowInput_MouseUp);
            // 
            // RowMenExitBtn
            // 
            this.RowMenExitBtn.BackColor = System.Drawing.Color.LightPink;
            this.RowMenExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowMenExitBtn.Location = new System.Drawing.Point(291, 397);
            this.RowMenExitBtn.Name = "RowMenExitBtn";
            this.RowMenExitBtn.Size = new System.Drawing.Size(183, 51);
            this.RowMenExitBtn.TabIndex = 12;
            this.RowMenExitBtn.Text = "Exit";
            this.RowMenExitBtn.UseVisualStyleBackColor = false;
            this.RowMenExitBtn.Click += new System.EventHandler(this.RowMenExitBtn_Click);
            // 
            // ConfirmRowBtn
            // 
            this.ConfirmRowBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ConfirmRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmRowBtn.Location = new System.Drawing.Point(73, 397);
            this.ConfirmRowBtn.Name = "ConfirmRowBtn";
            this.ConfirmRowBtn.Size = new System.Drawing.Size(183, 51);
            this.ConfirmRowBtn.TabIndex = 11;
            this.ConfirmRowBtn.Text = "Add Row";
            this.ConfirmRowBtn.UseVisualStyleBackColor = false;
            this.ConfirmRowBtn.Click += new System.EventHandler(this.ConfirmRowBtn_Click);
            // 
            // SupplierInput
            // 
            this.SupplierInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierInput.Location = new System.Drawing.Point(243, 301);
            this.SupplierInput.Name = "SupplierInput";
            this.SupplierInput.Size = new System.Drawing.Size(287, 30);
            this.SupplierInput.TabIndex = 10;
            // 
            // SupplierText
            // 
            this.SupplierText.AutoSize = true;
            this.SupplierText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierText.Location = new System.Drawing.Point(91, 300);
            this.SupplierText.Name = "SupplierText";
            this.SupplierText.Size = new System.Drawing.Size(146, 31);
            this.SupplierText.TabIndex = 9;
            this.SupplierText.Text = "Supplier : ";
            // 
            // PriceInput
            // 
            this.PriceInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceInput.Location = new System.Drawing.Point(241, 252);
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(287, 30);
            this.PriceInput.TabIndex = 8;
            // 
            // PriceText
            // 
            this.PriceText.AutoSize = true;
            this.PriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.Location = new System.Drawing.Point(131, 251);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(106, 31);
            this.PriceText.TabIndex = 7;
            this.PriceText.Text = "Price : ";
            // 
            // QuantityInput
            // 
            this.QuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityInput.Location = new System.Drawing.Point(243, 200);
            this.QuantityInput.Name = "QuantityInput";
            this.QuantityInput.Size = new System.Drawing.Size(287, 30);
            this.QuantityInput.TabIndex = 6;
            // 
            // QuantityText
            // 
            this.QuantityText.AutoSize = true;
            this.QuantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location = new System.Drawing.Point(88, 199);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(149, 31);
            this.QuantityText.TabIndex = 5;
            this.QuantityText.Text = "Quantity : ";
            // 
            // CategoryInput
            // 
            this.CategoryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryInput.Location = new System.Drawing.Point(243, 150);
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(287, 30);
            this.CategoryInput.TabIndex = 4;
            // 
            // CategoryText
            // 
            this.CategoryText.AutoSize = true;
            this.CategoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryText.Location = new System.Drawing.Point(79, 147);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(158, 31);
            this.CategoryText.TabIndex = 3;
            this.CategoryText.Text = "Category : ";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(243, 104);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(287, 30);
            this.NameInput.TabIndex = 2;
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.Location = new System.Drawing.Point(13, 101);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(224, 31);
            this.NameText.TabIndex = 1;
            this.NameText.Text = "Product Name : ";
            this.NameText.Click += new System.EventHandler(this.NameText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Row";
            // 
            // StockIncrement
            // 
            this.StockIncrement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StockIncrement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StockIncrement.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StockIncrement.Controls.Add(this.CurrentQuant);
            this.StockIncrement.Controls.Add(this.label5);
            this.StockIncrement.Controls.Add(this.CloseAddStockMenu);
            this.StockIncrement.Controls.Add(this.AddStock);
            this.StockIncrement.Controls.Add(this.NameField);
            this.StockIncrement.Controls.Add(this.label4);
            this.StockIncrement.Controls.Add(this.IDInput);
            this.StockIncrement.Controls.Add(this.label3);
            this.StockIncrement.Controls.Add(this.StockAmount);
            this.StockIncrement.Controls.Add(this.label2);
            this.StockIncrement.Controls.Add(this.AddText);
            this.StockIncrement.Location = new System.Drawing.Point(677, 249);
            this.StockIncrement.Name = "StockIncrement";
            this.StockIncrement.Size = new System.Drawing.Size(370, 183);
            this.StockIncrement.TabIndex = 7;
            this.StockIncrement.Visible = false;
            this.StockIncrement.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StockIncrement_MouseDown);
            this.StockIncrement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StockIncrement_MouseMove);
            this.StockIncrement.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StockIncrement_MouseUp);
            // 
            // CurrentQuant
            // 
            this.CurrentQuant.Enabled = false;
            this.CurrentQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentQuant.Location = new System.Drawing.Point(266, 105);
            this.CurrentQuant.Name = "CurrentQuant";
            this.CurrentQuant.ReadOnly = true;
            this.CurrentQuant.Size = new System.Drawing.Size(79, 24);
            this.CurrentQuant.TabIndex = 10;
            this.CurrentQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current : ";
            // 
            // CloseAddStockMenu
            // 
            this.CloseAddStockMenu.BackColor = System.Drawing.Color.LightPink;
            this.CloseAddStockMenu.Location = new System.Drawing.Point(226, 145);
            this.CloseAddStockMenu.Name = "CloseAddStockMenu";
            this.CloseAddStockMenu.Size = new System.Drawing.Size(105, 26);
            this.CloseAddStockMenu.TabIndex = 8;
            this.CloseAddStockMenu.Text = "Exit";
            this.CloseAddStockMenu.UseVisualStyleBackColor = false;
            this.CloseAddStockMenu.Click += new System.EventHandler(this.CloseAddStockMenu_Click);
            // 
            // AddStock
            // 
            this.AddStock.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddStock.Location = new System.Drawing.Point(93, 145);
            this.AddStock.Name = "AddStock";
            this.AddStock.Size = new System.Drawing.Size(105, 26);
            this.AddStock.TabIndex = 7;
            this.AddStock.Text = "Add Stock";
            this.AddStock.UseVisualStyleBackColor = false;
            this.AddStock.Click += new System.EventHandler(this.AddStock_Click);
            // 
            // NameField
            // 
            this.NameField.Enabled = false;
            this.NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.Location = new System.Drawing.Point(109, 42);
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            this.NameField.Size = new System.Drawing.Size(236, 24);
            this.NameField.TabIndex = 6;
            this.NameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name : ";
            // 
            // IDInput
            // 
            this.IDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDInput.Location = new System.Drawing.Point(109, 75);
            this.IDInput.Name = "IDInput";
            this.IDInput.Size = new System.Drawing.Size(236, 24);
            this.IDInput.TabIndex = 4;
            this.IDInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID : ";
            // 
            // StockAmount
            // 
            this.StockAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockAmount.Location = new System.Drawing.Point(109, 105);
            this.StockAmount.Name = "StockAmount";
            this.StockAmount.Size = new System.Drawing.Size(89, 24);
            this.StockAmount.TabIndex = 2;
            this.StockAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount : ";
            // 
            // AddText
            // 
            this.AddText.AutoSize = true;
            this.AddText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddText.Location = new System.Drawing.Point(145, 10);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(83, 20);
            this.AddText.TabIndex = 0;
            this.AddText.Text = "Add Stock";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.GenReport);
            this.panel1.Controls.Add(this.CSVExport);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AddStockBtn);
            this.panel1.Controls.Add(this.RemoveStockBtn);
            this.panel1.Controls.Add(this.DeleteRowBtn);
            this.panel1.Controls.Add(this.AddRowBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 738);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(79, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Controls";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.Title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1465, 60);
            this.panel2.TabIndex = 9;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // CSVExport
            // 
            this.CSVExport.BackColor = System.Drawing.Color.Moccasin;
            this.CSVExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSVExport.Location = new System.Drawing.Point(21, 452);
            this.CSVExport.Name = "CSVExport";
            this.CSVExport.Size = new System.Drawing.Size(242, 62);
            this.CSVExport.TabIndex = 7;
            this.CSVExport.Text = "Export To CSV";
            this.CSVExport.UseVisualStyleBackColor = false;
            this.CSVExport.Click += new System.EventHandler(this.CSVExport_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(644, 76);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(612, 26);
            this.SearchBar.TabIndex = 10;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label7.Location = new System.Drawing.Point(389, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Search By: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeDropdown
            // 
            this.TypeDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeDropdown.FormattingEnabled = true;
            this.TypeDropdown.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Category",
            "Supplier"});
            this.TypeDropdown.Location = new System.Drawing.Point(540, 76);
            this.TypeDropdown.MaxDropDownItems = 5;
            this.TypeDropdown.Name = "TypeDropdown";
            this.TypeDropdown.Size = new System.Drawing.Size(98, 28);
            this.TypeDropdown.TabIndex = 12;
            this.TypeDropdown.Text = "Name";
            // 
            // GenReport
            // 
            this.GenReport.BackColor = System.Drawing.Color.Moccasin;
            this.GenReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenReport.Location = new System.Drawing.Point(21, 531);
            this.GenReport.Name = "GenReport";
            this.GenReport.Size = new System.Drawing.Size(242, 62);
            this.GenReport.TabIndex = 8;
            this.GenReport.Text = "Generate Report";
            this.GenReport.UseVisualStyleBackColor = false;
            this.GenReport.Click += new System.EventHandler(this.GenReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1465, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RowInput);
            this.Controls.Add(this.StockIncrement);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TypeDropdown);
            this.Controls.Add(this.SearchBar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.RowInput.ResumeLayout(false);
            this.RowInput.PerformLayout();
            this.StockIncrement.ResumeLayout(false);
            this.StockIncrement.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button AddRowBtn;
        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.Button RemoveStockBtn;
        private System.Windows.Forms.Button AddStockBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Button ConfirmRowBtn;
        private System.Windows.Forms.TextBox SupplierInput;
        private System.Windows.Forms.Label SupplierText;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Label PriceText;
        private System.Windows.Forms.TextBox QuantityInput;
        private System.Windows.Forms.Label QuantityText;
        private System.Windows.Forms.TextBox CategoryInput;
        private System.Windows.Forms.Label CategoryText;
        private System.Windows.Forms.Button RowMenExitBtn;
        private System.Windows.Forms.Panel StockIncrement;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StockAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AddText;
        private System.Windows.Forms.Button CloseAddStockMenu;
        private System.Windows.Forms.Button AddStock;
        private System.Windows.Forms.Panel RowInput;
        private System.Windows.Forms.TextBox CurrentQuant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button CSVExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TypeDropdown;
        private System.Windows.Forms.Button GenReport;
    }
}

