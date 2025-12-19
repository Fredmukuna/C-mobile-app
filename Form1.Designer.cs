namespace MultiBranchInventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            lblUserName = new Label();
            lblPassword = new Label();
            PasswordTb = new TextBox();
            UnameTb = new TextBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(UnameTb);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(25, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(1321, 589);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.eba7e2c1a197ecf89224226317db64a8;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 151);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 255, 255);
            btnExit.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ActiveCaptionText;
            btnExit.Location = new Point(1223, 534);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 33);
            btnExit.TabIndex = 9;
            btnExit.Text = ">Exit<";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ButtonHighlight;
            lblUserName.Location = new Point(450, 275);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(133, 30);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ButtonHighlight;
            lblPassword.Location = new Point(450, 342);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(118, 30);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(450, 375);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(383, 29);
            PasswordTb.TabIndex = 6;
            PasswordTb.UseSystemPasswordChar = true;
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(450, 310);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(383, 29);
            UnameTb.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.african_american_worker_writing_inventory_list_while_checking_stock_storage_room;
            pictureBox1.Location = new Point(450, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Black;
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(655, 476);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 32);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "ShowPassword";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(450, 424);
            button1.Name = "button1";
            button1.Size = new Size(383, 46);
            button1.TabIndex = 1;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(576, -2);
            label1.Name = "label1";
            label1.Size = new Size(104, 45);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(211, 9);
            label2.Name = "label2";
            label2.Size = new Size(907, 45);
            label2.TabIndex = 1;
            label2.Text = " Multi-Branch Inventory And Supplier Management System\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 683);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private TextBox PasswordTb;
        private TextBox UnameTb;
        private Label lblUserName;
        private Label lblPassword;
        private Button btnExit;
        private PictureBox pictureBox2;
    }
}
