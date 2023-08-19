namespace 书店管理系统
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label13 = new Label();
            ResetButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            SaveButton = new Button();
            label11 = new Label();
            label10 = new Label();
            LPhone = new TextBox();
            LName = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label8 = new Label();
            LAddress = new TextBox();
            label9 = new Label();
            LPassword = new TextBox();
            UserList = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserList).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("幼圆", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(782, 262);
            label13.Name = "label13";
            label13.Size = new Size(116, 26);
            label13.TabIndex = 60;
            label13.Text = "用户列表";
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            ResetButton.Location = new Point(1048, 167);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(162, 52);
            ResetButton.TabIndex = 58;
            ResetButton.Text = "重置";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += button4_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(855, 167);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(162, 52);
            DeleteButton.TabIndex = 57;
            DeleteButton.Text = "删除";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += button3_Click;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(662, 167);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(162, 52);
            EditButton.TabIndex = 56;
            EditButton.Text = "修改";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += button2_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(469, 167);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(162, 52);
            SaveButton.TabIndex = 55;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(447, 57);
            label11.Name = "label11";
            label11.Size = new Size(82, 24);
            label11.TabIndex = 52;
            label11.Text = "用户名";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(653, 57);
            label10.Name = "label10";
            label10.Size = new Size(106, 24);
            label10.TabIndex = 51;
            label10.Text = "电话号码";
            // 
            // LPhone
            // 
            LPhone.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPhone.Location = new Point(653, 93);
            LPhone.Name = "LPhone";
            LPhone.Size = new Size(176, 38);
            LPhone.TabIndex = 46;
            // 
            // LName
            // 
            LName.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LName.Location = new Point(447, 93);
            LName.Name = "LName";
            LName.Size = new Size(178, 38);
            LName.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(140, 53);
            label7.Name = "label7";
            label7.Size = new Size(73, 30);
            label7.TabIndex = 44;
            label7.Text = "书籍";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightCoral;
            label5.Location = new Point(140, 119);
            label5.Name = "label5";
            label5.Size = new Size(73, 30);
            label5.TabIndex = 43;
            label5.Text = "用户";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(112, 189);
            label4.Name = "label4";
            label4.Size = new Size(133, 30);
            label4.TabIndex = 42;
            label4.Text = "账户管理";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(140, 263);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 41;
            label3.Text = "登出";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("幼圆", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(35, 658);
            label2.Name = "label2";
            label2.Size = new Size(357, 40);
            label2.TabIndex = 39;
            label2.Text = "书 店 管 理 系 统";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("宋体", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(21, 360);
            label1.Name = "label1";
            label1.Size = new Size(128, 270);
            label1.TabIndex = 38;
            label1.Text = "木\r\n抑\r\n云";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(1287, 9);
            label6.Name = "label6";
            label6.Size = new Size(43, 30);
            label6.TabIndex = 37;
            label6.Text = "×";
            label6.Click += label6_Click_1;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(851, 57);
            label8.Name = "label8";
            label8.Size = new Size(58, 24);
            label8.TabIndex = 64;
            label8.Text = "地址";
            // 
            // LAddress
            // 
            LAddress.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LAddress.Location = new Point(851, 93);
            LAddress.Name = "LAddress";
            LAddress.Size = new Size(176, 38);
            LAddress.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(1053, 57);
            label9.Name = "label9";
            label9.Size = new Size(58, 24);
            label9.TabIndex = 66;
            label9.Text = "密码";
            // 
            // LPassword
            // 
            LPassword.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPassword.Location = new Point(1053, 93);
            LPassword.Name = "LPassword";
            LPassword.Size = new Size(176, 38);
            LPassword.TabIndex = 65;
            // 
            // UserList
            // 
            UserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserList.BackgroundColor = SystemColors.ButtonHighlight;
            UserList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserList.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column3, Column4 });
            UserList.GridColor = Color.LightGray;
            UserList.Location = new Point(407, 312);
            UserList.Name = "UserList";
            UserList.ReadOnly = true;
            UserList.RowHeadersVisible = false;
            UserList.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            UserList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            UserList.RowTemplate.Height = 32;
            UserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserList.Size = new Size(909, 396);
            UserList.TabIndex = 67;
            UserList.CellClick += dataGridView1_CellContentClick;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Id";
            Column5.HeaderText = "用户编号";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "IName";
            Column1.HeaderText = "用户名";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "IPhone";
            Column2.HeaderText = "电话号码";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "IAddress";
            Column3.HeaderText = "地址";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "IPassword";
            Column4.HeaderText = "密码";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1342, 734);
            Controls.Add(UserList);
            Controls.Add(label9);
            Controls.Add(LPassword);
            Controls.Add(label8);
            Controls.Add(LAddress);
            Controls.Add(label13);
            Controls.Add(ResetButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(SaveButton);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(LPhone);
            Controls.Add(LName);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label13;
        private Button ResetButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button SaveButton;
        private Label label11;
        private Label label10;
        private TextBox LPhone;
        private TextBox LName;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label8;
        private TextBox LAddress;
        private Label label9;
        private TextBox LPassword;
        private DataGridView UserList;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}