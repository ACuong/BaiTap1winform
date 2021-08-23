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
    public partial class Form1 : Form
    {
        
        public object Dayso { get; private set; }

        public Form1()
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
            int[] Dayso = new int[100];// khai bao va cap phat day so toi da 100 so

            Dayso[i] = int.Parse(txtNhap.Text);
            txtDayNhap.Text += Dayso[i] + " ";
            Tongpt += Dayso[i];
            int temp = Dayso[i] % 2; // chia lấy phần dư
            if (temp == 0) // nếu phần dư khác không tức là số lẻ, còn bằng 0 thì là số chẵn
            { 
                TongChan += Dayso[i]; 
            }
            else 
            { 
                TongLe += Dayso[i]; 
            }

            txtTongPhanTu.Text += Tongpt;
            txtTongChan.Text += TongChan;
            txtTongLe.Text += TongLe;
            i++;
            txtNhap.Text = "";
            txtNhap.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
