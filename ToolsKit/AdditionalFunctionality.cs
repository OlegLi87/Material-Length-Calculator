using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ToolsKit
{
    static class AdditionalFunctionality
    {
        public static  void ButtonStatusChange(string status, Button btn)
        {
            switch (status)
            {
                case "en":
                    {
                        btn.Enabled = true;
                        break;
                    }
                case "dis":
                    {
                        btn.Enabled = false;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Invalid status parameter was delivered !");
                        break;
                    }
            }
        }

        public static void FormCentering(Form frm)
        {
            frm.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - (frm.Width / 2), Screen.PrimaryScreen.WorkingArea.Height / 2 - (frm.Height / 2));
        }

        public static string TimeFormation(int time)
        {
            if (time < 10) return string.Format("0{0}", time);
            else return time.ToString();
        }

        public static string TotalTimeFormat(string time)
        {
            string[] arr  = time.Split(':');

            return string.Format("[ {0}:{1} ] : זמן העבודה הכולל הינו", arr[0], arr[1]);
        }
    }
}
