using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 书店管理系统
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            Start();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            Hide();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-EFSGP0C;Initial Catalog=C:\USERS\LUNYE\DOCUMENTS\MUYIYUNBOOK.MDF;Integrated Security=True");

        private void Start()
        {
            Con.Close();
            Con.Open();
            string sql1 = "select sum(UQty) from book";
            string sql2 = "select count(IName) from UserTb";
            try
            {
                SqlCommand cmd1 = new SqlCommand(sql1, Con);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                sdr1.Read();
                BookCount.Text = "书籍库存数量 " + sdr1.GetInt32(0);
                sdr1.Close();
            }
            catch (System.Data.SqlTypes.SqlNullValueException)
            {
                BookCount.Text = "书籍库存数量 " + 0;
            }
            Con.Close();
            Con.Open();
            SqlCommand cmd2 = new SqlCommand(sql2, Con);
            SqlDataReader sdr2 = cmd2.ExecuteReader();
            sdr2.Read();
            UserCount.Text = "总用户人数 " + sdr2.GetInt32(0);
            Con.Close();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.LightCoral;
            label6.ForeColor = Color.White;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
