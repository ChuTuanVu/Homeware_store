using System.Windows.Forms;
using GUI.uckhongthedangnhap;
using UTLT;

namespace GUI
{
    public partial class Gui_khongthedangnhap : Form
    {
        public Gui_khongthedangnhap()
        {
            InitializeComponent();
        }

        private void Pbtt_Click(object sender, System.EventArgs e)
        {
            Tool.Form(this, new Gui_dangnhap());
        }

        private void Bttennguoidung_Click(object sender, System.EventArgs e)
        {
            pnchinh.Visible = true;
            Tool.UserControl(new Uc_tennguoidung(), pnchinh);
        }

        private void Btmk_Click(object sender, System.EventArgs e)
        {
            pnchinh.Visible = true;
            Tool.UserControl(new uc_mk(), pnchinh);
        }

        private void Btdangky_Click(object sender, System.EventArgs e)
        {
            pnchinh.Visible = true;
            Tool.UserControl(new Uc_dangky(), pnchinh);
        }
    }
}