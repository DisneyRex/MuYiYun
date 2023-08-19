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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
            populate();
            Count();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        int key = -1;
        int key2 = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LTitle.Text = BookList.SelectedRows[0].Cells[1].Value.ToString();
            LPrice.Text = BookList.SelectedRows[0].Cells[5].Value.ToString();
            LQty.Text = "1";
            if (LTitle.Text == "")
            {
                key = -1;
            }
            else
            {
                key = Convert.ToInt32(BookList.SelectedRows[0].Cells[0].Value);
            }
        }

        private void Reset()
        {
            LTitle.Text = null;
            LQty.Text = null;
            LPrice.Text = null;
            key = -1;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-EFSGP0C;Initial Catalog=C:\USERS\LUNYE\DOCUMENTS\MUYIYUNBOOK.MDF;Integrated Security=True");
        private void populate1()
        {
            Con.Close();
            Con.Open();
            string sql = "select * from book;";
            SqlDataAdapter sda = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Con.Close();
            BookList.DataSource = ds.Tables[0];
        }
        private void populate2()
        {
            Con.Close();
            Con.Open();
            string sql = "select * from Bill;";
            SqlDataAdapter sda = new SqlDataAdapter(sql, Con);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Con.Close();
            BuyingCarList.DataSource = ds.Tables[0];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (LTitle.Text == "" || LQty.Text == "")
            {
                MessageBox.Show("信息缺失");
                return;
            }
            Con.Close();
            Con.Open();
            int qty;
            string pp = "select UQty from book where UTitle = '" + LTitle.Text + "';";
            SqlCommand cmd = new SqlCommand(pp, Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            qty = rdr.GetInt32(0);
            Con.Close();
            if (Convert.ToInt32(LQty.Text) > qty)
            {
                MessageBox.Show("数量超过库存!");
                return;
            }
            else if (Convert.ToInt32(LQty.Text) < 1)
            {
                MessageBox.Show("数量至少为一");
            }
            else
            {
                Con.Close();
                Con.Open();
                string sql = "insert into Bill(AName,AQty,AMount) values ('" + LTitle.Text + "'," + LQty.Text + "," + LPrice.Text + ")";
                SqlCommand cee = new SqlCommand(sql, Con);
                cee.ExecuteNonQuery();
                UpdateBookDecrease();
                populate();
                Reset();
                Con.Close();
            }
            Count();
        }

        private void populate()
        {
            populate1();
            populate2();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Count()
        {
            Con.Close();
            Con.Open();
            string sql = "select sum(AMount*AQty) as Amount from Bill";
            SqlCommand SC = new SqlCommand(sql, Con);
            SqlDataReader sdr = SC.ExecuteReader();
            sdr.Read();
            if (sdr.IsDBNull(0)) { ListCount.Text = "订单总额"; Con.Close(); return; }
            int sdrtext = sdr.GetInt32(0);
            ListCount.Text = "订单总额 ￥" + sdrtext;
            Con.Close();
        }

        private void UpdateBookDecrease()
        {
            int qty;
            Con.Close();
            Con.Open();
            string pp = "select UQty from book where UTitle = '" + LTitle.Text + "';";
            SqlCommand cmd = new SqlCommand(pp, Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            qty = rdr.GetInt32(0);
            qty = qty - Convert.ToInt32(LQty.Text);
            if (qty < 0)
            {
                MessageBox.Show("已无库存");
                return;
            }
            rdr.Close();
            string pa = "update book set UQty = '" + qty + "' where UTitle = '" + LTitle.Text + "';";
            SqlCommand cmd2 = new SqlCommand(pa, Con);
            cmd2.ExecuteNonQuery();
            Con.Close();
        }

        private void UpdateBookIncrease()
        {
            int qty;
            Con.Close();
            Con.Open();
            string pp = "select UQty from book where UTitle = '" + LTitle.Text + "';";
            SqlCommand cmd = new SqlCommand(pp, Con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            qty = rdr.GetInt32(0);
            rdr.Close();
            qty = qty + Convert.ToInt32(LQty.Text);
            string pa = "update book set UQty = '" + qty + "' where UTitle = '" + LTitle.Text + "';";
            SqlCommand cmd2 = new SqlCommand(pa, Con);
            cmd2.ExecuteNonQuery();
            Con.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (LTitle.Text == "" || key2 == -1)
            {
                MessageBox.Show("信息缺失");
                return;
            }
            string cmd = "delete from Bill where AId = '" + key2 + "'";
            Con.Open();
            SqlCommand sc = new SqlCommand(cmd, Con);
            sc.ExecuteNonQuery();
            UpdateBookIncrease();
            populate();
            Reset();
            key2 = -1;
            Con.Close();
            Count();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LTitle.Text = BuyingCarList.SelectedRows[0].Cells[1].Value.ToString();
            LPrice.Text = BuyingCarList.SelectedRows[0].Cells[2].Value.ToString();
            LQty.Text = BuyingCarList.SelectedRows[0].Cells[3].Value.ToString();
            if (LTitle.Text == "")
            {
                key2 = -1;
            }
            else
            {
                key2 = Convert.ToInt32(BuyingCarList.SelectedRows[0].Cells[0].Value);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("木抑云书店", new Font("幼圆", 12, FontStyle.Bold), Brushes.Red, new Point(100));
            e.Graphics.DrawString("编号  产品  价格  数量  总计", new Font("幼圆", 10, FontStyle.Bold), Brushes.Red, new Point(30, 40));
            foreach (DataGridViewRow row in BuyingCarList.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn1"].Value);
                prodname = "" + row.Cells["dataGridViewTextBoxColumn2"].Value;
                prodprice = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn6"].Value);
                prodqty = Convert.ToInt32(row.Cells["dataGridViewTextBoxColumn5"].Value);
                tottal = prodprice * prodqty;
                e.Graphics.DrawString("" + prodid, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(40, pos));
                e.Graphics.DrawString("" + prodname, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(80, pos));
                e.Graphics.DrawString("" + prodprice, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(130, pos));
                e.Graphics.DrawString("" + prodqty, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("幼圆", 8, FontStyle.Bold), Brushes.Blue, new Point(210, pos));
                pos += 20;
            }
            e.Graphics.DrawString(ListCount.Text, new Font("幼圆", 12, FontStyle.Bold), Brushes.Crimson, new Point(100, pos + 50));
            e.Graphics.DrawString("***********木抑云书店***********", new Font("幼圆", 10, FontStyle.Bold), Brushes.Crimson, new Point(20, pos + 85));
            string clear = "delete from bill;";
            Con.Close();
            Con.Open();
            SqlCommand cmd = new SqlCommand(clear, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            Count();
            pos = 100;
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 660);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;

        private void label3_Click(object sender, EventArgs e)
        {
            LoginUser login = new LoginUser();
            login.Show();
            Hide();
        }
    }
}
