using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVDV
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void buttonQLTV_Click(object sender, EventArgs e)
        {
            this.Hide();
            new QLThanhVien().ShowDialog();
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
