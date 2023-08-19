namespace 书店管理系统
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            panel3 = new Panel();
            UserCount = new Label();
            panel1 = new Panel();
            BookCount = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(UserCount);
            panel3.Location = new Point(693, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 111);
            panel3.TabIndex = 59;
            // 
            // UserCount
            // 
            UserCount.AutoSize = true;
            UserCount.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UserCount.ForeColor = SystemColors.ControlText;
            UserCount.Location = new Point(16, 37);
            UserCount.Name = "UserCount";
            UserCount.Size = new Size(163, 30);
            UserCount.TabIndex = 45;
            UserCount.Text = "总用户人数";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(BookCount);
            panel1.Location = new Point(693, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 111);
            panel1.TabIndex = 57;
            // 
            // BookCount
            // 
            BookCount.AutoSize = true;
            BookCount.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BookCount.ForeColor = SystemColors.ControlText;
            BookCount.Location = new Point(16, 39);
            BookCount.Name = "BookCount";
            BookCount.Size = new Size(193, 30);
            BookCount.TabIndex = 45;
            BookCount.Text = "书籍库存数量";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(141, 51);
            label7.Name = "label7";
            label7.Size = new Size(73, 30);
            label7.TabIndex = 56;
            label7.Text = "书籍";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(141, 117);
            label5.Name = "label5";
            label5.Size = new Size(73, 30);
            label5.TabIndex = 55;
            label5.Text = "用户";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(113, 187);
            label4.Name = "label4";
            label4.Size = new Size(133, 30);
            label4.TabIndex = 54;
            label4.Text = "账户管理";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(141, 261);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 53;
            label3.Text = "登出";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 369);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("幼圆", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(36, 656);
            label2.Name = "label2";
            label2.Size = new Size(357, 40);
            label2.TabIndex = 51;
            label2.Text = "书 店 管 理 系 统";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("宋体", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(22, 358);
            label1.Name = "label1";
            label1.Size = new Size(128, 270);
            label1.TabIndex = 50;
            label1.Text = "木\r\n抑\r\n云";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(1288, 7);
            label6.Name = "label6";
            label6.Size = new Size(43, 30);
            label6.TabIndex = 49;
            label6.Text = "×";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1342, 734);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acount";
            Load += Account_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel3;
        private Label UserCount;
        private Panel panel1;
        private Label BookCount;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}