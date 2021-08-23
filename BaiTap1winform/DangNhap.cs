using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaiTap1winform
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenDangNhap.Text == "admin" & txtMatKhau.Text == "12345")
            {
                this.Hide();
                FormTinhTongDaySo open_form1 = new FormTinhTongDaySo();
                open_form1.Show();

            }    
        }

        private void DangNhap_Activated(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }
    }
}
