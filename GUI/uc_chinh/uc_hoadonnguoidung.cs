using System;
using System.Windows.Forms;

namespace GUI.uc_chinh
{
    public partial class uc_hoadonnguoidung : UserControl
    {
        public uc_hoadonnguoidung()
        {
            InitializeComponent();
        }

        private void Uc_hoadonnguoidung_Load(object sender, EventArgs e)
        {
            crvhoadonnguoidung.RefreshReport();
        }
    }
}
