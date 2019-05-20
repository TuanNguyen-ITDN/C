using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; // Thêm thư viện để làm việc với SQL
namespace QLVDV
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        connect c = new connect();


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            String ten = txtUser.Text;
            String mk = txtPass.Text;
            string strCn = @"Data Source = ASVNPNPC82\SQLEXPRESS2;Initial Catalog=QLVDV;User Id =" + ten + ";Password=" + mk;
            connect.strCn = strCn;
            if (c.ketnoi() == 1)
            {
                this.Hide();
                new homepage().ShowDialog();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // cho dòng text tiêu đề dịch chuyển
            string td = this.Text; // lấy dòng tiêu đề gán cho biến td
            int doDai = td.Length; // độ dài của dòng text
            string cuoi = td.Substring(doDai - 1, 1);// lấy 1 ký tự ở cuối
            string dau = td.Substring(0, doDai - 1);
            td = cuoi + dau;
            this.Text = td;
        }
    }
}
