using System;
using System.Windows.Forms;
using GUI.uc_chinh;

namespace GUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Gui_dangnhap());
        }
    }
}