namespace MultiBranchInventory
{
    partial class Product
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
            lblTitle = new Label();
            panel2 = new Panel();
            dataGridViewProducts = new DataGridView();
            btnBack = new Button();
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            lblProductName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            numStock = new NumericUpDown();
            numAdjust = new NumericUpDown();
            btnIncreaseStock = new Button();
            btnDecreaseStock = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdjust).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1398, 94);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(525, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(346, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Product Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 688);
            panel2.Name = "panel2";
            panel2.Size = new Size(1398, 42);
            panel2.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(224, 290);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 62;
            dataGridViewProducts.Size = new Size(862, 371);
            dataGridViewProducts.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Font = new Font("Yu Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(1227, 632);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back<<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(237, 169);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(211, 31);
            txtProductName.TabIndex = 4;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(510, 166);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(253, 31);
            txtCategory.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(833, 167);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Font = new Font("SimSun-ExtB", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(237, 203);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 192, 192);
            btnUpdate.Font = new Font("SimSun-ExtB", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(510, 203);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 34);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(128, 255, 255);
            btnRemove.Font = new Font("SimSun-ExtB", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(833, 203);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(177, 34);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = SystemColors.ButtonHighlight;
            lblProductName.Location = new Point(237, 135);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(153, 28);
            lblProductName.TabIndex = 10;
            lblProductName.Text = "Product Name:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = SystemColors.ButtonHighlight;
            lblCategory.Location = new Point(510, 135);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(103, 28);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Category:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ButtonHighlight;
            lblPrice.Location = new Point(833, 135);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(64, 28);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Price:";
            // 
            // numStock
            // 
            numStock.Location = new Point(1085, 167);
            numStock.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(180, 31);
            numStock.TabIndex = 13;
            // 
            // numAdjust
            // 
            numAdjust.Location = new Point(1085, 206);
            numAdjust.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numAdjust.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAdjust.Name = "numAdjust";
            numAdjust.Size = new Size(180, 31);
            numAdjust.TabIndex = 14;
            numAdjust.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnIncreaseStock
            // 
            btnIncreaseStock.BackColor = Color.Gray;
            btnIncreaseStock.Font = new Font("Javanese Text", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncreaseStock.ForeColor = SystemColors.ButtonHighlight;
            btnIncreaseStock.Location = new Point(1085, 243);
            btnIncreaseStock.Name = "btnIncreaseStock";
            btnIncreaseStock.Size = new Size(89, 41);
            btnIncreaseStock.TabIndex = 15;
            btnIncreaseStock.Text = "+ Stock";
            btnIncreaseStock.UseVisualStyleBackColor = false;
            // 
            // btnDecreaseStock
            // 
            btnDecreaseStock.BackColor = SystemColors.ControlDarkDark;
            btnDecreaseStock.Font = new Font("Javanese Text", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecreaseStock.ForeColor = SystemColors.ButtonHighlight;
            btnDecreaseStock.Location = new Point(1178, 243);
            btnDecreaseStock.Name = "btnDecreaseStock";
            btnDecreaseStock.Size = new Size(87, 41);
            btnDecreaseStock.TabIndex = 16;
            btnDecreaseStock.Text = "- Stock";
            btnDecreaseStock.UseVisualStyleBackColor = false;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.african_american_worker_taking_notes_while_making_shipment_schedule_warehouse;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1398, 730);
            Controls.Add(btnDecreaseStock);
            Controls.Add(btnIncreaseStock);
            Controls.Add(numAdjust);
            Controls.Add(numStock);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblProductName);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Controls.Add(btnBack);
            Controls.Add(dataGridViewProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Product";
            Text = "Product";
            Load += Product_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdjust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private DataGridView dataGridViewProducts;
        private Button btnBack;
        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblPrice;
        private NumericUpDown numStock;
        private NumericUpDown numAdjust;
        private Button btnIncreaseStock;
        private Button btnDecreaseStock;
    }
}