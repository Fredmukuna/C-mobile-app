namespace MultiBranchInventory
{
    partial class Stock
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
            lblStock = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnBack = new Button();
            grpStockSummary = new GroupBox();
            lblStatus = new Label();
            btnTransfer = new Button();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            cmbToBranch = new ComboBox();
            cmbFromBranch = new ComboBox();
            lblToBranch = new Label();
            lblFromBranch = new Label();
            lblProduct = new Label();
            cmbProduct = new ComboBox();
            tabPage2 = new TabPage();
            dgvTransferLog = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransferLog).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(lblStock);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 91);
            panel1.TabIndex = 0;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = SystemColors.ButtonHighlight;
            lblStock.Location = new Point(555, 28);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(247, 45);
            lblStock.TabIndex = 0;
            lblStock.Text = "Stock Transfers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 688);
            panel2.Name = "panel2";
            panel2.Size = new Size(1358, 40);
            panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 97);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1358, 591);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.BackgroundImage = Properties.Resources.Screenshot_2025_11_16_181004;
            tabPage1.Controls.Add(btnBack);
            tabPage1.Controls.Add(grpStockSummary);
            tabPage1.Controls.Add(lblStatus);
            tabPage1.Controls.Add(btnTransfer);
            tabPage1.Controls.Add(lblQuantity);
            tabPage1.Controls.Add(txtQuantity);
            tabPage1.Controls.Add(cmbToBranch);
            tabPage1.Controls.Add(cmbFromBranch);
            tabPage1.Controls.Add(lblToBranch);
            tabPage1.Controls.Add(lblFromBranch);
            tabPage1.Controls.Add(lblProduct);
            tabPage1.Controls.Add(cmbProduct);
            tabPage1.Location = new Point(4, 41);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1350, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Transfer";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 192, 192);
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(50, 464);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 16;
            btnBack.Text = "<Back>";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // grpStockSummary
            // 
            grpStockSummary.BackColor = Color.WhiteSmoke;
            grpStockSummary.Location = new Point(829, 177);
            grpStockSummary.Name = "grpStockSummary";
            grpStockSummary.Size = new Size(496, 267);
            grpStockSummary.TabIndex = 15;
            grpStockSummary.TabStop = false;
            grpStockSummary.Text = "Stock Summary";
            grpStockSummary.Enter += groupBox1_Enter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = SystemColors.ButtonHighlight;
            lblStatus.Location = new Point(410, 373);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(112, 32);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "lblStatus";
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.Cyan;
            btnTransfer.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransfer.Location = new Point(322, 272);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(341, 66);
            btnTransfer.TabIndex = 10;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.ForeColor = SystemColors.ButtonHighlight;
            lblQuantity.Location = new Point(67, 118);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(120, 32);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(185, 111);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 39);
            txtQuantity.TabIndex = 8;
            // 
            // cmbToBranch
            // 
            cmbToBranch.FormattingEnabled = true;
            cmbToBranch.Location = new Point(1031, 55);
            cmbToBranch.Name = "cmbToBranch";
            cmbToBranch.Size = new Size(182, 40);
            cmbToBranch.TabIndex = 6;
            // 
            // cmbFromBranch
            // 
            cmbFromBranch.FormattingEnabled = true;
            cmbFromBranch.Location = new Point(592, 53);
            cmbFromBranch.Name = "cmbFromBranch";
            cmbFromBranch.Size = new Size(182, 40);
            cmbFromBranch.TabIndex = 5;
            // 
            // lblToBranch
            // 
            lblToBranch.AutoSize = true;
            lblToBranch.ForeColor = SystemColors.ButtonHighlight;
            lblToBranch.Location = new Point(872, 58);
            lblToBranch.Name = "lblToBranch";
            lblToBranch.Size = new Size(134, 32);
            lblToBranch.TabIndex = 3;
            lblToBranch.Text = "To Branch:";
            // 
            // lblFromBranch
            // 
            lblFromBranch.AutoSize = true;
            lblFromBranch.ForeColor = SystemColors.ButtonHighlight;
            lblFromBranch.Location = new Point(420, 61);
            lblFromBranch.Name = "lblFromBranch";
            lblFromBranch.Size = new Size(166, 32);
            lblFromBranch.TabIndex = 2;
            lblFromBranch.Text = "From Branch:";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.ForeColor = SystemColors.ButtonHighlight;
            lblProduct.Location = new Point(67, 58);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(112, 32);
            lblProduct.TabIndex = 1;
            lblProduct.Text = "Product:";
            lblProduct.Click += lblProduct_Click;
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(185, 53);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(182, 40);
            cmbProduct.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(dgvTransferLog);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 41);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1350, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "History";
            // 
            // dgvTransferLog
            // 
            dgvTransferLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferLog.Location = new Point(3, 3);
            dgvTransferLog.Name = "dgvTransferLog";
            dgvTransferLog.RowHeadersWidth = 62;
            dgvTransferLog.Size = new Size(1344, 470);
            dgvTransferLog.TabIndex = 0;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 728);
            Controls.Add(tabControl1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransferLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblStock;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cmbToBranch;
        private ComboBox cmbFromBranch;
        private Label lblToBranch;
        private Label lblFromBranch;
        private Label lblProduct;
        private ComboBox cmbProduct;
        private TextBox txtQuantity;
        private Label lblStatus;
        private Button btnTransfer;
        private Label lblQuantity;
        private DataGridView dgvTransferLog;
        private GroupBox grpStockSummary;
        private Button btnBack;
    }
}