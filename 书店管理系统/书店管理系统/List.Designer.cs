namespace 书店管理系统
{
    partial class List
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BookList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            LPrice = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            LQty = new TextBox();
            LTitle = new TextBox();
            Logout = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label4 = new Label();
            BuyingCarButton = new Button();
            ResetButton = new Button();
            BuyingCarList = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            DeleteButton = new Button();
            ListCount = new Label();
            PrintButton = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)BookList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BuyingCarList).BeginInit();
            SuspendLayout();
            // 
            // BookList
            // 
            BookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookList.BackgroundColor = SystemColors.ButtonHighlight;
            BookList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            BookList.GridColor = Color.LightGray;
            BookList.Location = new Point(406, 313);
            BookList.Name = "BookList";
            BookList.ReadOnly = true;
            BookList.RowHeadersVisible = false;
            BookList.RowHeadersWidth = 62;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 192, 255);
            BookList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            BookList.RowTemplate.Height = 32;
            BookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BookList.Size = new Size(497, 396);
            BookList.TabIndex = 59;
            BookList.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Uid";
            Column1.HeaderText = "编号";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "UTitle";
            Column2.HeaderText = "书名";
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
            Column4.HeaderText = "类型";
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
            // LPrice
            // 
            LPrice.BackColor = SystemColors.ButtonHighlight;
            LPrice.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPrice.Location = new Point(650, 93);
            LPrice.Name = "LPrice";
            LPrice.ReadOnly = true;
            LPrice.Size = new Size(111, 38);
            LPrice.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(406, 57);
            label11.Name = "label11";
            label11.Size = new Size(106, 24);
            label11.TabIndex = 52;
            label11.Text = "书籍名称";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(650, 57);
            label10.Name = "label10";
            label10.Size = new Size(58, 24);
            label10.TabIndex = 51;
            label10.Text = "价格";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("幼圆", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(792, 57);
            label8.Name = "label8";
            label8.Size = new Size(58, 24);
            label8.TabIndex = 49;
            label8.Text = "数量";
            // 
            // LQty
            // 
            LQty.BackColor = SystemColors.ButtonHighlight;
            LQty.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LQty.Location = new Point(792, 93);
            LQty.Name = "LQty";
            LQty.Size = new Size(111, 38);
            LQty.TabIndex = 47;
            // 
            // LTitle
            // 
            LTitle.BackColor = SystemColors.ButtonHighlight;
            LTitle.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LTitle.Location = new Point(406, 93);
            LTitle.Name = "LTitle";
            LTitle.ReadOnly = true;
            LTitle.Size = new Size(212, 38);
            LTitle.TabIndex = 45;
            // 
            // Logout
            // 
            Logout.AutoSize = true;
            Logout.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Logout.ForeColor = SystemColors.ControlText;
            Logout.Location = new Point(141, 264);
            Logout.Name = "Logout";
            Logout.Size = new Size(73, 30);
            Logout.TabIndex = 41;
            Logout.Text = "登出";
            Logout.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 372);
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
            label2.Location = new Point(36, 659);
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
            label1.Location = new Point(22, 361);
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
            label6.Location = new Point(1288, 10);
            label6.Name = "label6";
            label6.Size = new Size(43, 30);
            label6.TabIndex = 37;
            label6.Text = "×";
            label6.Click += label6_Click;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(585, 264);
            label4.Name = "label4";
            label4.Size = new Size(133, 30);
            label4.TabIndex = 60;
            label4.Text = "书籍列表";
            // 
            // BuyingCarButton
            // 
            BuyingCarButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            BuyingCarButton.Location = new Point(471, 178);
            BuyingCarButton.Name = "BuyingCarButton";
            BuyingCarButton.Size = new Size(192, 52);
            BuyingCarButton.TabIndex = 61;
            BuyingCarButton.Text = "加入购物车";
            BuyingCarButton.UseVisualStyleBackColor = true;
            BuyingCarButton.Click += SaveButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            ResetButton.Location = new Point(700, 178);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(135, 52);
            ResetButton.TabIndex = 62;
            ResetButton.Text = "重置";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // BuyingCarList
            // 
            BuyingCarList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BuyingCarList.BackgroundColor = SystemColors.ButtonHighlight;
            BuyingCarList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            BuyingCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BuyingCarList.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn5 });
            BuyingCarList.GridColor = Color.LightGray;
            BuyingCarList.Location = new Point(942, 128);
            BuyingCarList.Name = "BuyingCarList";
            BuyingCarList.ReadOnly = true;
            BuyingCarList.RowHeadersVisible = false;
            BuyingCarList.RowHeadersWidth = 62;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            BuyingCarList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            BuyingCarList.RowTemplate.Height = 32;
            BuyingCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BuyingCarList.Size = new Size(369, 396);
            BuyingCarList.TabIndex = 63;
            BuyingCarList.CellClick += dataGridView2_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "AId";
            dataGridViewTextBoxColumn1.HeaderText = "单号";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "AName";
            dataGridViewTextBoxColumn2.HeaderText = "书名";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "AMount";
            dataGridViewTextBoxColumn6.HeaderText = "单价";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "AQty";
            dataGridViewTextBoxColumn5.HeaderText = "数量";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(1075, 82);
            label5.Name = "label5";
            label5.Size = new Size(103, 30);
            label5.TabIndex = 64;
            label5.Text = "购物车";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(1188, 553);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(123, 52);
            DeleteButton.TabIndex = 65;
            DeleteButton.Text = "删除商品";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ListCount
            // 
            ListCount.AutoSize = true;
            ListCount.Font = new Font("幼圆", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ListCount.ForeColor = SystemColors.ControlText;
            ListCount.Location = new Point(942, 561);
            ListCount.Name = "ListCount";
            ListCount.Size = new Size(133, 30);
            ListCount.TabIndex = 66;
            ListCount.Text = "订单总额";
            ListCount.Click += label7_Click;
            // 
            // PrintButton
            // 
            PrintButton.Font = new Font("楷体", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            PrintButton.Location = new Point(1044, 632);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(166, 67);
            PrintButton.TabIndex = 67;
            PrintButton.Text = "结算";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += Printbtn_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // List
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1342, 734);
            Controls.Add(PrintButton);
            Controls.Add(ListCount);
            Controls.Add(DeleteButton);
            Controls.Add(label5);
            Controls.Add(BuyingCarList);
            Controls.Add(ResetButton);
            Controls.Add(BuyingCarButton);
            Controls.Add(label4);
            Controls.Add(BookList);
            Controls.Add(LPrice);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(LQty);
            Controls.Add(LTitle);
            Controls.Add(Logout);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "List";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List";
            ((System.ComponentModel.ISupportInitialize)BookList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BuyingCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView BookList;
        private TextBox LPrice;
        private Label label11;
        private Label label10;
        private Label label8;
        private TextBox LQty;
        private TextBox LTitle;
        private Label Logout;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label4;
        private Button BuyingCarButton;
        private Button ResetButton;
        private DataGridView BuyingCarList;
        private Label label5;
        private Button DeleteButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label ListCount;
        private Button PrintButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}