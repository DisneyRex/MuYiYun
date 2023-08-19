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
    public partial class Login : Form
    {
        public Login()
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
            if (textBox1.Text == "1069410564" & textBox2.Text == "1069410564")
            {
                Book book = new Book();
                book.Show();
                Hide();
            }
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
            LoginUser login = new LoginUser();
            login.Show();
            Hide();
        }
    }
}
