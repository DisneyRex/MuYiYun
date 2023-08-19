using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 书店管理系统
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            populate();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (BTitle.Text == "" || BAuther.Text == "" || BQty.Text == "" || BPrice.Text == "" || BCat.Text == "" || key == -1)
            {
                MessageBox.Show("信息缺失");
                return;
            }
            string cmd = "update Book set UTitle = '" + BTitle.Text + "',UAuthor = '" + BAuther.Text + "',UCat = '" + BCat.SelectedItem + "',UQty = '" + BQty.Text + "',UPrice = '" + BPrice.Text + "'where Uid = '" + key + "'";
            connection.Open();
            SqlCommand sc = new SqlCommand(cmd, connection);
            sc.ExecuteNonQuery();
            MessageBox.Show("修改成功");
            populate();
            Reset();
            connection.Close();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-EFSGP0C;Initial Catalog=C:\USERS\LUNYE\DOCUMENTS\MUYIYUNBOOK.MDF;Integrated Security=True");
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (BTitle.Text == "" || BAuther.Text == "" || BQty.Text == "" || BPrice.Text == "" || BCat.Text == "")
            {
                MessageBox.Show("信息缺失");
            }
            else
            {
                try
                {
                    connection.Open();
                    string Query = "insert into Book values('" + BTitle.Text + "','" + BAuther.Text + "','" + BCat.SelectedItem.ToString() + "'," + BQty.Text + "," + BPrice.Text + ")";
                    SqlCommand cmd = new SqlCommand(Query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("书籍信息添加成功");
                    populate();
                    Reset();
                    connection.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            connection.Close();
            connection.Open();
            string sql = "select * from book;";
            SqlDataAdapter sda = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            connection.Close();
            Booklist.DataSource = ds.Tables[0];
        }
        private void Filter()
        {
            connection.Open();
            string sql = "select * from book where UCat = '" + Cat.SelectedItem + "';";
            SqlDataAdapter sda = new SqlDataAdapter(sql, connection);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            connection.Close();
            Booklist.DataSource = ds.Tables[0];
        }

        int key = -1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BTitle.Text = Booklist.SelectedRows[0].Cells[1].Value.ToString();
            BAuther.Text = Booklist.SelectedRows[0].Cells[2].Value.ToString();
            BCat.Text = Booklist.SelectedRows[0].Cells[3].Value.ToString();
            BQty.Text = Booklist.SelectedRows[0].Cells[4].Value.ToString();
            BPrice.Text = Booklist.SelectedRows[0].Cells[5].Value.ToString();
            if (BTitle.Text == "")
            {
                key = -1;
            }
            else
            {
                key = Convert.ToInt32(Booklist.SelectedRows[0].Cells[0].Value);
            }
        }

        private void Cat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            populate();
            Cat.SelectedIndex = -1;
        }

        private void Reset()
        {
            BTitle.Text = null;
            BCat.Text = null;
            BAuther.Text = null;
            BQty.Text = null;
            BPrice.Text = null;
            key = -1;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BTitle.Text == "")
            {
                MessageBox.Show("信息缺失");
                return;
            }
            string cmd = "delete from Book where Uid = '" + key + "'";
            connection.Open();
            SqlCommand sc = new SqlCommand(cmd, connection);
            sc.ExecuteNonQuery();
            MessageBox.Show("删除成功");
            populate();
            Reset();
            key = -1;
            connection.Close();

        }

        private void Cat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void BPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void BQty_TextChanged(object sender, EventArgs e)
        {
        }

        private void BAuther_TextChanged(object sender, EventArgs e)
        {
        }

        private void BTitle_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
