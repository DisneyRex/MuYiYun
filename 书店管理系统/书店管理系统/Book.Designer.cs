namespace 书店管理系统
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            LogoutLabel = new Label();
            AccountLabel = new Label();
            UserLabel = new Label();
            BookLabel = new Label();
            BTitle = new TextBox();
            BAuther = new TextBox();
            BQty = new TextBox();
            BCat = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            BPrice = new TextBox();
            SaveButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            ResetButton = new Button();
            Booklist = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label13 = new Label();
            Cat = new ComboBox();
            UpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Booklist).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(1287, 9);
            label6.Name = "label6";
            label6.Size = new Size(43, 30);
            label6.TabIndex = 11;
            label6.Text = "×";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
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
            label1.TabIndex = 12;
            label1.Text = "木\r\n抑\r\n云";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("幼圆", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(35, 658);
            label2.Name = "label2";
            label2.Size = new Size(357, 40);
            label2.TabIndex = 13;
            label2.Text = "书 店 管 理 系 统";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LogoutLabel
            // 
            LogoutLabel.AutoSize = true;
            LogoutLabel.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutLabel.ForeColor = SystemColors.ControlText;
            LogoutLabel.Location = new Point(140, 263);
            LogoutLabel.Name = "LogoutLabel";
            LogoutLabel.Size = new Size(73, 30);
            LogoutLabel.TabIndex = 15;
            LogoutLabel.Text = "登出";
            LogoutLabel.Click += label3_Click;
            // 
            // AccountLabel
            // 
            AccountLabel.AutoSize = true;
            AccountLabel.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            AccountLabel.ForeColor = SystemColors.ControlText;
            AccountLabel.Location = new Point(112, 189);
            AccountLabel.Name = "AccountLabel";
            AccountLabel.Size = new Size(133, 30);
            AccountLabel.TabIndex = 16;
            AccountLabel.Text = "账户管理";
            AccountLabel.Click += label4_Click;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            UserLabel.ForeColor = SystemColors.ControlText;
            UserLabel.Location = new Point(140, 119);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(73, 30);
            UserLabel.TabIndex = 17;
            UserLabel.Text = "用户";
            UserLabel.Click += label5_Click;
            // 
            // BookLabel
            // 
            BookLabel.AutoSize = true;
            BookLabel.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BookLabel.ForeColor = Color.LightCoral;
            BookLabel.Location = new Point(140, 53);
            BookLabel.Name = "BookLabel";
            BookLabel.Size = new Size(73, 30);
            BookLabel.TabIndex = 18;
            BookLabel.Text = "书籍";
            BookLabel.Click += label7_Click;
            // 
            // BTitle
            // 
            BTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTitle.Location = new Point(426, 94);
            BTitle.Name = "BTitle";
            BTitle.Size = new Size(156, 38);
            BTitle.TabIndex = 19;
            BTitle.TextChanged += BTitle_TextChanged;
            // 
            // BAuther
            // 
            BAuther.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BAuther.Location = new Point(611, 94);
            BAuther.Name = "BAuther";
            BAuther.Size = new Size(154, 38);
            BAuther.TabIndex = 20;
            BAuther.TextChanged += BAuther_TextChanged;
            // 
            // BQty
            // 
            BQty.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BQty.Location = new Point(998, 94);
            BQty.Name = "BQty";
            BQty.Size = new Size(111, 38);
            BQty.TabIndex = 21;
            BQty.TextChanged += BQty_TextChanged;
            // 
            // BCat
            // 
            BCat.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BCat.FormattingEnabled = true;
            BCat.Items.AddRange(new object[] { "儿童读物", "文学艺术", "科学技术", "人文历史", "生活美食", "经济管理", "教辅书籍" });
            BCat.Location = new Point(796, 94);
            BCat.Name = "BCat";
            BCat.Size = new Size(171, 39);
            BCat.TabIndex = 22;
            BCat.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(998, 58);
            label8.Name = "label8";
            label8.Size = new Size(58, 24);
            label8.TabIndex = 23;
            label8.Text = "数量";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(796, 58);
            label9.Name = "label9";
            label9.Size = new Size(106, 24);
            label9.TabIndex = 24;
            label9.Text = "书目类别";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(611, 58);
            label10.Name = "label10";
            label10.Size = new Size(58, 24);
            label10.TabIndex = 25;
            label10.Text = "作者";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(426, 58);
            label11.Name = "label11";
            label11.Size = new Size(106, 24);
            label11.TabIndex = 26;
            label11.Text = "书籍名称";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(1138, 57);
            label12.Name = "label12";
            label12.Size = new Size(58, 24);
            label12.TabIndex = 28;
            label12.Text = "价格";
            label12.Click += label12_Click;
            // 
            // BPrice
            // 
            BPrice.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BPrice.Location = new Point(1138, 93);
            BPrice.Name = "BPrice";
            BPrice.Size = new Size(111, 38);
            BPrice.TabIndex = 27;
            BPrice.TextChanged += BPrice_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(469, 167);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(162, 52);
            SaveButton.TabIndex = 29;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(662, 167);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(162, 52);
            EditButton.TabIndex = 30;
            EditButton.Text = "修改";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += button2_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(855, 167);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(162, 52);
            DeleteButton.TabIndex = 31;
            DeleteButton.Text = "删除";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            ResetButton.Location = new Point(1048, 167);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(162, 52);
            ResetButton.TabIndex = 32;
            ResetButton.Text = "重置";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // Booklist
            // 
            Booklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Booklist.BackgroundColor = SystemColors.ButtonHighlight;
            Booklist.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Booklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Booklist.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            Booklist.GridColor = Color.LightGray;
            Booklist.Location = new Point(405, 312);
            Booklist.Name = "Booklist";
            Booklist.ReadOnly = true;
            Booklist.RowHeadersVisible = false;
            Booklist.RowHeadersWidth = 62;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 192, 255);
            Booklist.RowsDefaultCellStyle = dataGridViewCellStyle2;
            Booklist.RowTemplate.Height = 32;
            Booklist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Booklist.Size = new Size(909, 396);
            Booklist.TabIndex = 33;
            Booklist.CellClick += dataGridView1_CellContentClick;
            Booklist.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Uid";
            Column1.HeaderText = "书籍编号";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "UTitle";
            Column2.HeaderText = "书籍名称";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "UAuthor";
            Column3.HeaderText = "作者";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "UCat";
            Column4.HeaderText = "书籍类型";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "UQty";
            Column5.HeaderText = "数量";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "UPrice";
            Column6.HeaderText = "价格";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("幼圆", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(662, 262);
            label13.Name = "label13";
            label13.Size = new Size(116, 26);
            label13.TabIndex = 34;
            label13.Text = "书籍清单";
            label13.Click += label13_Click;
            // 
            // Cat
            // 
            Cat.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Cat.ForeColor = SystemColors.ScrollBar;
            Cat.FormattingEnabled = true;
            Cat.Items.AddRange(new object[] { "儿童读物", "文学艺术", "科学技术", "人文历史", "生活美食", "经济管理", "教辅书籍" });
            Cat.Location = new Point(785, 256);
            Cat.Name = "Cat";
            Cat.Size = new Size(171, 39);
            Cat.TabIndex = 35;
            Cat.Text = "选定类别";
            Cat.SelectedIndexChanged += Cat_SelectedIndexChanged;
            Cat.SelectionChangeCommitted += Cat_SelectionChangeCommitted;
            // 
            // UpdateButton
            // 
            UpdateButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateButton.Location = new Point(979, 256);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(107, 39);
            UpdateButton.TabIndex = 36;
            UpdateButton.Text = "更新";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1342, 734);
            Controls.Add(UpdateButton);
            Controls.Add(Cat);
            Controls.Add(label13);
            Controls.Add(Booklist);
            Controls.Add(ResetButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(SaveButton);
            Controls.Add(label12);
            Controls.Add(BPrice);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(BCat);
            Controls.Add(BQty);
            Controls.Add(BAuther);
            Controls.Add(BTitle);
            Controls.Add(BookLabel);
            Controls.Add(UserLabel);
            Controls.Add(AccountLabel);
            Controls.Add(LogoutLabel);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            Load += Book_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Booklist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label LogoutLabel;
        private Label AccountLabel;
        private Label UserLabel;
        private Label BookLabel;
        private TextBox BTitle;
        private TextBox BAuther;
        private TextBox BQty;
        private ComboBox BCat;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox BPrice;
        private Button SaveButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button ResetButton;
        private DataGridView Booklist;
        private Label label13;
        private ComboBox Cat;
        private Button UpdateButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}