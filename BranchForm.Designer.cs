namespace MultiBranchInventory
{
    partial class BranchForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBranchName = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridViewBranches = new Guna.UI2.WinForms.Guna2DataGridView();
            panel2 = new Panel();
            label4 = new Label();
            btnProduct = new Button();
            btnStock = new Button();
            btnPurchase = new Button();
            pictureBox1 = new PictureBox();
            pictureFade = new PictureBox();
            fadeTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBranches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFade).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 128);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(1331, 9);
            label3.Name = "label3";
            label3.Size = new Size(39, 41);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(132, 9);
            label2.Name = "label2";
            label2.Size = new Size(1098, 47);
            label2.TabIndex = 1;
            label2.Text = "Multi-Branch Inventory And Supplier Management System ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MingLiU_MSCS-ExtB", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(586, 66);
            label1.Name = "label1";
            label1.Size = new Size(116, 32);
            label1.TabIndex = 0;
            label1.Text = "Branch";
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(271, 134);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(263, 31);
            txtBranchName.TabIndex = 1;
            txtBranchName.Text = " ";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(271, 171);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(422, 171);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 0, 64);
            button4.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(1244, 632);
            button4.Name = "button4";
            button4.Size = new Size(126, 47);
            button4.TabIndex = 8;
            button4.Text = "Log Out<<";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridViewBranches
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewBranches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBranches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBranches.ColumnHeadersHeight = 4;
            dataGridViewBranches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewBranches.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBranches.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewBranches.Location = new Point(44, 226);
            dataGridViewBranches.Name = "dataGridViewBranches";
            dataGridViewBranches.RowHeadersVisible = false;
            dataGridViewBranches.RowHeadersWidth = 62;
            dataGridViewBranches.Size = new Size(621, 410);
            dataGridViewBranches.TabIndex = 9;
            dataGridViewBranches.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewBranches.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewBranches.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewBranches.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewBranches.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewBranches.ThemeStyle.BackColor = Color.White;
            dataGridViewBranches.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewBranches.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewBranches.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBranches.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewBranches.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewBranches.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewBranches.ThemeStyle.HeaderStyle.Height = 4;
            dataGridViewBranches.ThemeStyle.ReadOnly = false;
            dataGridViewBranches.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewBranches.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBranches.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewBranches.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewBranches.ThemeStyle.RowsStyle.Height = 33;
            dataGridViewBranches.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewBranches.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 717);
            panel2.Name = "panel2";
            panel2.Size = new Size(1382, 31);
            panel2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(91, 131);
            label4.Name = "label4";
            label4.Size = new Size(174, 32);
            label4.TabIndex = 11;
            label4.Text = "Branch Name:";
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Teal;
            btnProduct.Font = new Font("SimSun", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = SystemColors.ButtonHighlight;
            btnProduct.Location = new Point(690, 152);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(161, 40);
            btnProduct.TabIndex = 12;
            btnProduct.Text = "Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Teal;
            btnStock.Font = new Font("SimSun", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStock.ForeColor = SystemColors.ButtonHighlight;
            btnStock.Location = new Point(1196, 152);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(174, 40);
            btnStock.TabIndex = 13;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.Teal;
            btnPurchase.Font = new Font("SimSun", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.ForeColor = SystemColors.ButtonHighlight;
            btnPurchase.Location = new Point(934, 152);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(181, 40);
            btnPurchase.TabIndex = 14;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_1624927637280_f033784c1279;
            pictureBox1.Location = new Point(690, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(680, 419);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureFade
            // 
            pictureFade.BackgroundImage = Properties.Resources.Screenshot_2025_11_16_1810041;
            pictureFade.BackgroundImageLayout = ImageLayout.Stretch;
            pictureFade.Dock = DockStyle.Fill;
            pictureFade.Location = new Point(0, 0);
            pictureFade.Name = "pictureFade";
            pictureFade.Size = new Size(1382, 748);
            pictureFade.TabIndex = 15;
            pictureFade.TabStop = false;
            // 
            // fadeTimer
            // 
            fadeTimer.Interval = 30;
            // 
            // BranchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1382, 748);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(btnPurchase);
            Controls.Add(btnStock);
            Controls.Add(btnProduct);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(dataGridViewBranches);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtBranchName);
            Controls.Add(panel1);
            Controls.Add(pictureFade);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BranchForm";
            Text = "BranchForm";
            Load += BranchForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBranches).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtBranchName;
        private Button button1;
        private Button button3;
        private Button button4;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewBranches;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Button btnProduct;
        private Button btnStock;
        private Button btnPurchase;
        private PictureBox pictureBox1;
        private PictureBox pictureFade;
        private System.Windows.Forms.Timer fadeTimer;
    }
}