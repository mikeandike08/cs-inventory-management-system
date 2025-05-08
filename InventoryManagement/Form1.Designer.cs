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
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.RowInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(435, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(595, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "Inventory Management System";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataView
            // 
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(77, 98);
            this.DataView.Name = "DataView";
            this.DataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataView.Size = new System.Drawing.Size(1294, 455);
            this.DataView.TabIndex = 1;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            // 
            // AddRowBtn
            // 
            this.AddRowBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddRowBtn.Location = new System.Drawing.Point(77, 588);
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
            this.DeleteRowBtn.Location = new System.Drawing.Point(336, 588);
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
            this.RemoveStockBtn.Location = new System.Drawing.Point(1129, 588);
            this.RemoveStockBtn.Name = "RemoveStockBtn";
            this.RemoveStockBtn.Size = new System.Drawing.Size(242, 62);
            this.RemoveStockBtn.TabIndex = 4;
            this.RemoveStockBtn.Text = "Decrement Stock";
            this.RemoveStockBtn.UseVisualStyleBackColor = false;
            // 
            // AddStockBtn
            // 
            this.AddStockBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddStockBtn.Location = new System.Drawing.Point(870, 588);
            this.AddStockBtn.Name = "AddStockBtn";
            this.AddStockBtn.Size = new System.Drawing.Size(242, 62);
            this.AddStockBtn.TabIndex = 5;
            this.AddStockBtn.Text = "Increment Stock";
            this.AddStockBtn.UseVisualStyleBackColor = false;
            // 
            // RowInput
            // 
            this.RowInput.AllowDrop = true;
            this.RowInput.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.RowInput.Location = new System.Drawing.Point(425, 77);
            this.RowInput.Name = "RowInput";
            this.RowInput.Size = new System.Drawing.Size(566, 476);
            this.RowInput.TabIndex = 6;
            this.RowInput.Visible = false;
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
            this.PriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceInput.Location = new System.Drawing.Point(243, 254);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 680);
            this.Controls.Add(this.RowInput);
            this.Controls.Add(this.AddStockBtn);
            this.Controls.Add(this.RemoveStockBtn);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.AddRowBtn);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.RowInput.ResumeLayout(false);
            this.RowInput.PerformLayout();
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
        private System.Windows.Forms.Panel RowInput;
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
    }
}

