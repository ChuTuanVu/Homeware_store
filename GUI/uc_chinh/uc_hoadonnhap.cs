using System;
using System.Windows.Forms;

namespace GUI.uc_chinh
{
    public partial class uc_hoadonnhap : UserControl
    {
        public uc_hoadonnhap()
        {
            InitializeComponent();
        }

        private void Uc_hoadonnhap_Load(object sender, EventArgs e)
        {
            crvhoadonnhap.RefreshReport();
        }
    }
}
