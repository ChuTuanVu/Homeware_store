using System.Windows.Forms;

namespace GUI.uc_chinh
{
    public partial class Uc_hoadonxuat : UserControl
    {
        public Uc_hoadonxuat()
        {
            InitializeComponent();
        }

        private void Uc_hoadonxuat_Load(object sender, System.EventArgs e)
        {
            crvhoadonxuat.RefreshReport();
        }
    }
}