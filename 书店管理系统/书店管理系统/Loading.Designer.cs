namespace 书店管理系统
{
    partial class Loading
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            MyProgress = new ProgressBar();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("宋体", 45F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(128, 56);
            label1.Name = "label1";
            label1.Size = new Size(128, 270);
            label1.TabIndex = 0;
            label1.Text = "木\r\n抑\r\n云";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("幼圆", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 56);
            label2.Name = "label2";
            label2.Size = new Size(357, 40);
            label2.TabIndex = 1;
            label2.Text = "书 店 管 理 系 统";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MyProgress
            // 
            MyProgress.Location = new Point(-2, 398);
            MyProgress.Name = "MyProgress";
            MyProgress.Size = new Size(734, 34);
            MyProgress.TabIndex = 3;
            MyProgress.Click += progressBar1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 344);
            label3.Name = "label3";
            label3.Size = new Size(317, 24);
            label3.TabIndex = 4;
            label3.Text = "L     o     a     d     i     n     g     .     .     .";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 344);
            label4.Name = "label4";
            label4.Size = new Size(26, 24);
            label4.TabIndex = 5;
            label4.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(732, 424);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(MyProgress);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private ProgressBar MyProgress;
        private Label label3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}