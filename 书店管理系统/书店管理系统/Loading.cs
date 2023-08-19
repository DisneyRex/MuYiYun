namespace 书店管理系统
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
        }

        int sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            MyProgress.Value = sec;
            label4.Text = sec + "%";
            if (sec == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                LoginUser login = new LoginUser();
                login.Show();
                Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}