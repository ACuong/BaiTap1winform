using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1winform
{
    public partial class FormTinhTongDaySo : Form
    {
        
        public object Dayso { get; private set; }

        public FormTinhTongDaySo()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int i = 0;
        int Tongpt = 0;
        int TongChan = 0;
        int TongLe = 0;
        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtTongPhanTu.Text = ""; 
            txtTongChan.Text = "";
            txtTongLe.Text = "";
            //reset lại giá trị của các textbox Tổng phần tử, tổng chẵn, tổng lẻ

            int[] Dayso = new int[100];// khai bao va cap phat day so toi da 100 so

            Dayso[i] = int.Parse(txtNhap.Text); // gán giá trị của textboxNhập vào phần tử mảng i

            txtDayNhap.Text += Dayso[i] + " "; // thêm giá trị phần tử mảng i vào textbox Dãy Nhập

            Tongpt += Dayso[i]; // cộng thêm phân từ mảng i vào giá trị tổng phẩn tử của dãy

            int temp = Dayso[i] % 2; // chia lấy phần dư của phẩn tử mảng i
            if (temp == 0) // nếu phần dư khác 0 tức là số lẻ, còn bằng 0 thì là số chẵn
            { 
                TongChan += Dayso[i]; // cộng giá trị phần tử chẵn vào tổng chắn
            }
            else 
            { 
                TongLe += Dayso[i]; // cộng giá trị phần tử lẻ vào tổng lẻ
            }

            txtTongPhanTu.Text += Tongpt; // Gán giá trị tổng phần tử cho textbox Tổng Phần Tử
            txtTongChan.Text += TongChan; // Gán giá trị tổng chẳn cho textbox Tổng Chẵn
            txtTongLe.Text += TongLe;       // Gán giá trị tổng lẻ cho textbox Tổng Lẻ
            i++; // tăng vị trí mảng i lên 1 đơn vị
            txtNhap.Text = ""; 
            txtNhap.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtTongPhanTu.Text = "";
            txtTongChan.Text = "";
            txtTongLe.Text = "";
            txtDayNhap.Text = "";
            txtNhap.Text = "";
            i = 0;
            Tongpt = 0;
            TongChan = 0;
            TongLe = 0;
            txtNhap.Focus();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            txtNhap.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.Focus();
        }
    }
}
