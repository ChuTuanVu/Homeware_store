using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BLL;

namespace UTLT
{
    public class Tool
    {
        private static Bll_taikhoan bllTaikhoan = new Bll_taikhoan();

        public static string Sha256(string mk)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(mk));
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringBuilder.Append(bytes[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }

        public static void Form(Form form_an, Form form_hien)
        {
            form_an.Hide();
            form_hien.ShowDialog();
            form_an.Close();
        }

        public static void Anmatkhau(List<TextBox> textBoxes, List<PictureBox> pictureBoxes)
        {
            for (int i = 0; i < textBoxes.Count; i++)
            {
                if (textBoxes[i].UseSystemPasswordChar)
                {
                    textBoxes[i].UseSystemPasswordChar = false;
                    pictureBoxes[i].Image = Properties.Resources.matkhauhien;
                }
                else
                {
                    textBoxes[i].UseSystemPasswordChar = true;
                    pictureBoxes[i].Image = Properties.Resources.matkhauan;
                }
            }
        }

        public static void Bat(List<Button> buttons, List<TextBox> textBoxes)
        {
            bool bt = false;
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    bt = true;
                    break;
                }
            }

            foreach (Button button in buttons)
            {
                button.Enabled =! bt;
                button.BackColor =! bt ? Color.Red : SystemColors.ControlLight;
            }
        }

        public static bool Email(string email)
        {
            try
            {
                if (bllTaikhoan.EmailTrung(email) && !string.IsNullOrEmpty(email))
                {
                    MailAddress mailAddress = new MailAddress(email);
                    return true;
                }
                return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool Emaillay(string email)
        {
            try
            {
                if (!string.IsNullOrEmpty(email))
                {
                    MailAddress mailAddress = new MailAddress(email);
                    return true;
                }

                return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool Sdt(string sdt)
        {
            if (bllTaikhoan.SdtTrung(sdt) && Regex.Match(sdt, @"^0\d{9}$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool Sdtlay(string sdt)
        {
            if (Regex.Match(sdt, @"^0\d{9}$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool Tennguoidung(string tennguoidung)
        {
            if (bllTaikhoan.TennguoidungTrung(tennguoidung) && Regex.Match(tennguoidung, @"^[a-zA-Z0-9]{4,}$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool Tennguoidunglay(string tennguoidung)
        {
            if (Regex.Match(tennguoidung, @"^[a-zA-Z0-9]{4,}$").Success)
            {
                return true;
            }
            return false;
        }

        public static bool Matkhau(string matkhau)
        {
            if (Regex.Match(matkhau, @"^[A-Za-z0-9!@#$%^&*]{8,}$").Success)
            {
                if (Regex.Match(matkhau, @"^(?=.*?[A-Za-z])(?=.*?[0-9])").Success ||
                    Regex.Match(matkhau, @"^(?=.*?[A-Za-z])(?=.*?[#?!@$%^&*-])").Success ||
                    Regex.Match(matkhau, @"(?=.*?[0-9])(?=.*?[#?!@$%^&*-])").Success)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public static bool Xnmk(string mk, string xnmk)
        {
            if (mk == xnmk)
            {
                return true;
            }
            return false;
        }

        public static string Mahoa (string mh)
        {
            if (mh.Length < 6)
            {
                string dau = mh.Substring(0, 1);
                string cuoi = mh.Substring(mh.Length - 1);
                string kq = new string('*', mh.Length - 2);
                return $"{dau}{kq}{cuoi}";
            }
            else
            {
                string dau = mh.Substring(0, 2);
                string cuoi = mh.Substring(mh.Length - 2);
                string kq = new string('*', mh.Length - 4);
                return $"{dau}{kq}{cuoi}";
            }
        }

        public static byte[] PtoB(Label label)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Ảnh (*.png;*.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string duongdan = openFileDialog.FileName;
                Image image = Image.FromFile(duongdan);
                label.Text = Path.GetFileName(openFileDialog.FileName);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, image.RawFormat);
                    return memoryStream.ToArray();
                }
            }
            return null;
        }


        public static void UserControl(UserControl userControl, Panel panel)
        {
            if (panel.Controls.Count > 0 && panel.Controls[0].GetType() == userControl.GetType())
            {
                return;
            }
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
        }

        public static string VND(long tien)
        {
            var numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalDigits = 0,
                NumberGroupSeparator = "."
            };
            return tien.ToString("N", numberFormatInfo) + " đ";
        }

        public static long DNV(string tien)
        {
            if (tien.EndsWith(" đ"))
            {
                tien = tien.Substring(0, tien.Length - 2);
            }
            tien = tien.Replace(".", "");
            return Convert.ToInt64(tien);
        }

        public static void Panel(List<Panel> panels_an, Panel panel_hien)
        {
            foreach (var panel in panels_an)
            {
                if (panel == panel_hien)
                {
                    if (panel_hien.Visible)
                    {
                        panel_hien.Visible = false;

                    }
                    else
                    {
                        panel_hien.Visible = true;
                    }
                }
                else
                {
                    panel.Visible = false;
                }
            }
        }
    }
}