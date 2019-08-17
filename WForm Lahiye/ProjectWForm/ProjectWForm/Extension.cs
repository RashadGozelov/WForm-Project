using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWForm
{
   public static class Extension
    {
        public static bool IsEmail(this string str)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(str);
            if (match.Success)
                return true;
            else
                return false;
        }
        public static bool CheckInput(this Form form)
        {
            var isText = true;
            foreach (var item in form.Controls)
            {
                if (item is TextBox)
                {
                    var texb = item as TextBox;

                    if (texb.Text.Trim() == "")
                    {
                        texb.BackColor = System.Drawing.Color.Red;
                        isText = false;
                    }
                    else
                    {
                        texb.BackColor = System.Drawing.Color.White;
                    }
                }
            }
            return isText;
        }

        public static string HashPassword(string s)
        {
            byte[] passHashCode = Encoding.ASCII.GetBytes(s);
            byte[] pass = new SHA256Managed().ComputeHash(passHashCode);
            return Encoding.ASCII.GetString(pass);
        }

        public static bool IsNumber(this string str)
        {
            return int.TryParse(str, out int k);
        }
    }
}
