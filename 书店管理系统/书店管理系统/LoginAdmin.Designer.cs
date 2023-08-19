namespace 书店管理系统
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LoginButton = new Button();
            UserLabel = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("宋体", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(90, 65);
            label1.Name = "label1";
            label1.Size = new Size(128, 270);
            label1.TabIndex = 1;
            label1.Text = "木\r\n抑\r\n云";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("幼圆", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(239, 65);
            label2.Name = "label2";
            label2.Size = new Size(357, 40);
            label2.TabIndex = 2;
            label2.Text = "书 店 管 理 系 统";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(602, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(239, 166);
            label3.Name = "label3";
            label3.Size = new Size(133, 30);
            label3.TabIndex = 4;
            label3.Text = "用户名：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(252, 249);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 5;
            label4.Text = "密码：";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(359, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 38);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(359, 247);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(280, 38);
            textBox2.TabIndex = 7;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(359, 326);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(162, 52);
            LoginButton.TabIndex = 8;
            LoginButton.Text = "登录";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button1_Click;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("幼圆", 10.5F, FontStyle.Underline, GraphicsUnit.Point);
            UserLabel.ForeColor = SystemColors.ControlText;
            UserLabel.Location = new Point(546, 342);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(54, 21);
            UserLabel.TabIndex = 9;
            UserLabel.Text = "用户";
            UserLabel.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(714, 9);
            label6.Name = "label6";
            label6.Size = new Size(43, 30);
            label6.TabIndex = 10;
            label6.Text = "×";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(769, 449);
            Controls.Add(label6);
            Controls.Add(UserLabel);
            Controls.Add(LoginButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button LoginButton;
        private Label UserLabel;
        private Label label6;
    }
}