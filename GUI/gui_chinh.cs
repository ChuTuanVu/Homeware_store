using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using BLL;
using GUI.uc_chinh;
using GUI.ucchinh;
using UTLT;

namespace GUI
{
    public partial class Gui_chinh : Form
    {
        private List<Panel> panels_an = new List<Panel>();

        public Gui_chinh()
        {
            InitializeComponent();
            panels_an.Add(pnquanly);
            panels_an.Add(pnhoadon);
        }

        private void Gui_chinh_Load(object sender, EventArgs e)
        {
            if (Bll_taikhoan.taikhoanchon.quyen == false)
            {
                btnhacc.Enabled = false;
                btdanhmuc.Enabled = false;
                bttk.Enabled = false;
                btnhanvien.Enabled = false;
                bthoadonnhap.Enabled = false;
            }
            Btbangdieukhien_Click(this, EventArgs.Empty);
            lbtennguoidung.Text = Bll_taikhoan.taikhoanchon.tennguoidung;
        }

        private void Btquanly_Click(object sender, EventArgs e)
        {
            Tool.Panel(panels_an, pnquanly);
        }

        private void Btsp_Click(object sender, EventArgs e)
        {
            Tool.UserControl(new Uc_sanpham(), pnchinh);
            lbtieude.Text = "SẢN PHẨM";
        }

        private void Btdanhmuc_Click(object sender, EventArgs e)
        {
            Tool.UserControl(new Uc_danhmuc(), pnchinh);
            lbtieude.Text = "DANH MỤC";

        }

        private void Bttk_Click(object sender, EventArgs e)
        {
            Tool.UserControl(new Uc_taikhoan(), pnchinh);
            lbtieude.Text = "TÀI KHOẢN";
        }

        private void Tmtt_Tick(object sender, EventArgs e)
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                pbtt.Image = Properties.Resources.tructuyen;
                lbtt.Text = "Trực tuyến";
            }
            else
            {
                pbtt.Image = Properties.Resources.ngoaituyen;
                lbtt.Text = "Ngoại tuyến";
            }
        }

        private void Btbangdieukhien_Click(object sender, EventArgs e)
        {
            Tool.UserControl(new uc_bangdieukhien(), pnchinh);
            lbtieude.Text = "BẢNG ĐIỀU KHIỂN";
        }

        private void Btnhanvien_Click(object sender, EventArgs e)
        {
            Tool.UserControl(new Uc_nhanvien(), pnchinh);
            lbtieude.Text = "NHÂN VIÊN";
        }

        private void Btnhacc_Click(object sender, EventArgs e)
        {
            Tool.UserControl(new Uc_nhacungcap(), pnchinh);
            lbtieude.Text = "NHÀ CUNG CẤP";
        }

        private void Bthoadon_Click(object sender, EventArgs e)
        {
            Tool.Panel(panels_an, pnhoadon);
        }

        private void Bthoadonnhap_Click(object sender, EventArgs e)
        {
            Tool.UserControl(new uc_hoadonnhap(),pnchinh);
            lbtieude.Text = "HÓA ĐƠN NHẬP";
        }

        private void Bthoadonxuat_Click(object sender, EventArgs e)
        {
            Tool.UserControl(new Uc_hoadonxuat(),pnchinh);
            lbtieude.Text = "HÓA ĐƠN XUẤT";
        }

        private void Btdangxuat_Click(object sender, EventArgs e)
        {
            Tool.Form(this, new Gui_dangnhap());
        }

        private void ThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gui_thongtin guiThongtin = new gui_thongtin();
            guiThongtin.ShowDialog();
        }

        private void Pbanhdaidien_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = pbanhdaidien.PointToScreen(e.Location);
            cmstttk.Show(point);
        }
    }
}