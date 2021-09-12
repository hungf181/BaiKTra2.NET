using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLKS;
namespace LeVanHung2019600006
{
    
    public partial class frm_KS : Form
    {
        Bus_KS Ks = new Bus_KS();
        private string getDate()
        {
            return dTP1.Value.Month.ToString() + "/" + dTP1.Value.Day.ToString() + "/" + dTP1.Value.Year.ToString();
        }
        public frm_KS()
        {
            InitializeComponent();
        }

        private void frm_KS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Ks.Show();
            dataGridView1.Rows[1].Cells[3]=new DataGridViewCheckBoxCell();
        }
        private string getGT()
        {
            if (chkNu.Checked == true)
                return "Nữ";
            else
                return "Nam";
        }
        //Click vào thì thêm sản phẩm mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == ""||txtSoP.Text==""||txtCMT.Text==""||txtTen.Text=="")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Ks.check_key(txtMaKH.Text) == true)
                {
                    MessageBox.Show("Mã khách hàng này đã tồn tại!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Ks.Insert_X(txtMaKH.Text, txtTen.Text, int.Parse((txtCMT.Text)), getGT(), int.Parse(txtSoP.Text), getDate());
                        frm_KS_Load(sender, e);
                        MessageBox.Show("Thêm thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi nhập liệu, vui lòng nhập lại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //Click vào thì sửa thông tin
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtSoP.Text == "" || txtCMT.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu thông tin!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Ks.check_key(txtMaKH.Text) == false)
                {
                    MessageBox.Show("Mã khách hàng này không tồn tại!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Ks.Update_X(txtMaKH.Text, txtTen.Text, int.Parse((txtCMT.Text)), getGT(), int.Parse(txtSoP.Text), getDate());
                        frm_KS_Load(sender, e);
                        MessageBox.Show("Sửa thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi, vui lòng hãy thử lại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Ks.check_key(txtMaKH.Text) == false)
                {
                    MessageBox.Show("Mã khách hàng này không tồn tại!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        Ks.Delete_X(txtMaKH.Text);
                        frm_KS_Load(sender, e);
                        MessageBox.Show("Xóa thành công!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi, vui lòng hãy thử lại!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (a == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = e.RowIndex;
                txtMaKH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtCMT.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                if(dataGridView1.Rows[i].Cells[3].Value.ToString()=="Nữ")
                {
                    chkNu.Checked = true;
                }
                else
                {
                    chkNu.Checked = false;
                }    
                txtSoP.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                dTP1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            }
            catch
            { }
        }
    }
}
