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
    public partial class QLThanhVien : Form
    {
        public QLThanhVien()
        {
            InitializeComponent();
            c.ketnoi();
            HienThi();
        }

        connect c = new connect();
        

        public void HienThi()
        {
            String sql = " Select MaThanhVien,HoTen,NgaySinh,GioiTinh,SoThich,DiaChi from tlbThanhvien";
            dataGridView1.DataSource = c.TaoBang(sql);
            dataGridView1.ForeColor = Color.Red;

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comMaTD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comMaPB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void txtHo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }


        string MaTV = "";
        string TenTV = "";
        string NS = "";
        string GT = "";
        string ST = "";
        string DC = "";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QLThanhVien_Load(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (butUpdate.Text == "Sửa")
            {
                butUpdate.Text = "Lưu";
                txtTTV.ReadOnly = false;
                txtGT.ReadOnly = false;
                txtST.ReadOnly = false;
                txtDC.ReadOnly = false;
                txtTTV.Focus();// Dat con tro vao day
            }
            else
            {
                //string update = "Update PHongBan set TenPB = '" + txtTenPB.Text + "'" + ", DiaChi ='" + txtDC +
                //"'" + "'" + ",DienThoai ='" + txtSDT + "'";

                string update = "Update tlbThanhvien set " +
                   "HoTen='" + txtTTV.Text + "'" +
                   ", GioiTinh = '" + txtGT.Text + "'" +
                   ", NgaySinh='" + txtNS.Text + "'" +
                   ", DiaChi='" + txtDC.Text + "'" +
                   ", SoThich='" + txtST.Text + "'";

                update += "Where MaThanhVien='" + txtMTV.Text + "'";

                c.runSQL(update);
                HienThi();
                butUpdate.Text = "Sửa";
                txtTTV.ReadOnly = true;
                txtST.ReadOnly = true;
                txtGT.ReadOnly = true;
                txtDC.ReadOnly = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            if (btnadd.Text == "Cập Nhật")
            {
                btnadd.Text = "Lưu";
                txtMTV.ReadOnly = false;
                txtTTV.ReadOnly = false;// Cho phep sua
                txtST.ReadOnly = false;
                txtGT.ReadOnly = false;
                txtDC.ReadOnly = false;
                txtMTV.Focus();// Dat con tro vao day
            }
            else // 
            {
               
               string insert = "insert into tlbThanhvien (MaThanhVien,HoTen,NgaySinh,GioiTinh,SoThich,DiaChi)values ";
               insert += "(N'" + txtMTV.Text + "' , N'" + txtTTV.Text + "' , N'" + txtNS.Value + "' , N'" + txtGT.Text + "' , N'" + txtST.Text + "' , N'" + txtDC.Text +  "')";
               c.runSQL(insert);
               HienThi();
               btnadd.Text = "Cập Nhật";
               txtMTV.ReadOnly = true;
               txtTTV.ReadOnly = true;
               txtST.ReadOnly = true;
               txtDC.ReadOnly = true;
                

            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            if (MaTV != "")
            {
                string delete = "delete from tlbThanhvien where MaThanhVien = '" + MaTV + "'";
                c.runSQL(delete);
                HienThi();
                MaTV = "";
            }
            else
            {
                MessageBox.Show("Rỗng");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            MaTV = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TenTV = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            NS = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            GT = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ST = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DC = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            txtMTV.Text = MaTV;
            txtTTV.Text = TenTV;
            txtNS.Text = NS;
            txtGT.Text = GT;
            txtST.Text = ST;
            txtDC.Text = DC;
        }
    }
}
