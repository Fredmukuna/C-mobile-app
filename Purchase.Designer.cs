namespace MultiBranchInventory
{
    partial class Purchase
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
            panel1 = new Panel();
            panel2 = new Panel();
            lblPurchase = new Label();
            lblSupplier = new Label();
            txtSupplier = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            numQuantity = new NumericUpDown();
            btnAddItem = new Button();
            dataGridViewOrderItems = new DataGridView();
            btnBack = new Button();
            txtProductName = new TextBox();
            lblProductName = new Label();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 0);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 755);
            panel1.Name = "panel1";
            panel1.Size = new Size(1387, 32);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Controls.Add(lblPurchase);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1387, 93);
            panel2.TabIndex = 1;
            // 
            // lblPurchase
            // 
            lblPurchase.AutoSize = true;
            lblPurchase.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPurchase.ForeColor = SystemColors.ButtonHighlight;
            lblPurchase.Location = new Point(548, 31);
            lblPurchase.Name = "lblPurchase";
            lblPurchase.Size = new Size(264, 45);
            lblPurchase.TabIndex = 0;
            lblPurchase.Text = "Purchase Orders";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupplier.ForeColor = SystemColors.ButtonHighlight;
            lblSupplier.Location = new Point(168, 121);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(117, 32);
            lblSupplier.TabIndex = 2;
            lblSupplier.Text = "Supplier:";
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(168, 156);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(150, 31);
            txtSupplier.TabIndex = 3;
            txtSupplier.TextChanged += txtSupplier_TextChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ButtonHighlight;
            lblDate.Location = new Point(168, 216);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(57, 25);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(153, 251);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(300, 31);
            dtpDate.TabIndex = 5;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(1061, 157);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(180, 31);
            numQuantity.TabIndex = 7;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.FromArgb(0, 192, 192);
            btnAddItem.Font = new Font("Javanese Text", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(756, 250);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(356, 47);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(477, 303);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.RowHeadersWidth = 62;
            dataGridViewOrderItems.Size = new Size(645, 369);
            dataGridViewOrderItems.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(128, 255, 255);
            btnBack.Font = new Font("MS PGothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ActiveCaptionText;
            btnBack.Location = new Point(23, 592);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 45);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back<<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(440, 157);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(233, 31);
            txtProductName.TabIndex = 13;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.ButtonHighlight;
            lblProductName.Location = new Point(440, 123);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(169, 30);
            lblProductName.TabIndex = 14;
            lblProductName.Text = "Product Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ButtonHighlight;
            lblPrice.Location = new Point(778, 121);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(78, 32);
            lblPrice.TabIndex = 15;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(778, 156);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 16;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ButtonHighlight;
            lblQuantity.Location = new Point(1061, 121);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(110, 30);
            lblQuantity.TabIndex = 17;
            lblQuantity.Text = "Quantity:";
            // 
            // Purchase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImage = Properties.Resources.african_american_worker_writing_inventory_list_while_checking_stock_storage_room;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1387, 787);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(txtProductName);
            Controls.Add(btnBack);
            Controls.Add(dataGridViewOrderItems);
            Controls.Add(btnAddItem);
            Controls.Add(numQuantity);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(txtSupplier);
            Controls.Add(lblSupplier);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Purchase";
            Text = "Purchase";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblPurchase;
        private Label lblSupplier;
        private TextBox txtSupplier;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private NumericUpDown numQuantity;
        private Button btnAddItem;
        private DataGridView dataGridViewOrderItems;
        private Button btnBack;
        private TextBox txtProductName;
        private Label lblProductName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
    }
}