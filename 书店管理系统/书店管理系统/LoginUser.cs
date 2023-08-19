using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 书店管理系统
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-EFSGP0C;Initial Catalog=C:\USERS\LUNYE\DOCUMENTS\MUYIYUNBOOK.MDF;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string sql = "select Id from UserTb where IName = '" + textBox1.Text + "' and IPassword = '" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            try
            {
                sdr.GetInt32(0);
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("账户或密码错误，请重新输入");
                return;
            }
            Con.Close();
            List list = new List();
            list.Show();
            Hide();
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = Color.White;
            label6.ForeColor = Color.Black;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.BackColor = Color.LightCoral;
            label6.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }
    }
}
