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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Show();
            Hide();
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

        private void label4_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            Hide();
        }

        private void populate()
        {
            try
            {
                Connection.Close();
                Connection.Open();
                string sql2 = "select * from UserTb;";
                SqlDataAdapter sdd = new SqlDataAdapter(sql2, Connection);
                SqlCommandBuilder scb = new SqlCommandBuilder(sdd);
                var ds = new DataSet();
                sdd.Fill(ds);
                Connection.Close();
                UserList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            LName.Text = null;
            LPhone.Text = null;
            LAddress.Text = null;
            LPassword.Text = null;
            key = -1;
        }

        SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-EFSGP0C;Initial Catalog=C:\USERS\LUNYE\DOCUMENTS\MUYIYUNBOOK.MDF;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (LName.Text == "" || LPhone.Text == "" || LAddress.Text == "" || LPassword.Text == "")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                Connection.Close();
                Connection.Open();
                string Query = "insert into UserTb values('" + LName.Text + "'," + LPhone.Text + ",'" + LAddress.Text + "','" + LPassword.Text + "')";
                SqlCommand cmd = new SqlCommand(Query, Connection);
                cmd.ExecuteNonQuery();
                populate();
                Reset();
                MessageBox.Show("添加成功");
                Connection.Close();
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int key = -1;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LName.Text = UserList.SelectedRows[0].Cells[1].Value.ToString();
            LPhone.Text = UserList.SelectedRows[0].Cells[2].Value.ToString();
            LAddress.Text = UserList.SelectedRows[0].Cells[3].Value.ToString();
            LPassword.Text = UserList.SelectedRows[0].Cells[4].Value.ToString();
            if (LName.Text == "")
            {
                key = -1;
            }
            else
            {
                key = Convert.ToInt32(UserList.SelectedRows[0].Cells[0].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == -1)
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                Connection.Close();
                Connection.Open();
                string Query = "delete from UserTb where Id = " + key + "";
                SqlCommand cmd = new SqlCommand(Query, Connection);
                cmd.ExecuteNonQuery();
                populate();
                Reset();
                MessageBox.Show("删除成功");
                Connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LName.Text == "" || LPhone.Text == "" || LAddress.Text == "" || LPassword.Text == "")
            {
                MessageBox.Show("信息缺失");
                return;
            }
            string cmd = "update UserTb set IName = '" + LName.Text + "',IPhone = '" + LPhone.Text + "',IAddress = '" + LAddress.Text + "',IPassword = '" + LPassword.Text + "'where Id = '" + key + "'";
            Connection.Open();
            SqlCommand sc = new SqlCommand(cmd, Connection);
            sc.ExecuteNonQuery();
            MessageBox.Show("修改成功");
            populate();
            Reset();
            Connection.Close();
        }
    }
}
