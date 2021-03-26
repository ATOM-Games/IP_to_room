using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace MoveB
{
    public partial class Form1 : Form
    {
        string Host, IP, pubIp;
        string str = "";
        public Form1()
        {
            InitializeComponent();
            GetIP();
        }
        void GetIP() {
            try
            {
                pubIp = new System.Net.WebClient().DownloadString("https://api.ipify.org");
                TEXTA.Text = IP_HS(pubIp);
            }
            catch (Exception yy) {
                TEXTA.Text = "ERROR";
            }
        }
        public string IP_HS(string IP)
        {
            string str = "";
            string[] ipi = IP.Split('.');
            int[] ini = new int[ipi.Length];
            for (int i = 0; i < ini.Length; ini[i] = System.Convert.ToInt32(ipi[i]), i++) ;
            for (int i = 0; i < ini.Length; str += ini[i].ToString("X"), i++) ;
            str = str.Replace('0', 'Z').Replace('1', 'O').Replace('2', 'T').Replace('3', 'W').Replace('4', 'X').Replace('5', 'P').Replace('6', 'S').Replace('7', 'V').Replace('8', 'H').Replace('9', 'N');
            return str;
        }


        public string HS_IP(string SH)
        {
            string str = SH;
            str = str.Replace('Z', '0').Replace('O', '1').Replace('T', '2').Replace('W', '3').Replace('X', '4').Replace('P', '5').Replace('S', '6').Replace('V', '7').Replace('H', '8').Replace('N', '9');
            char[] ipi = str.ToCharArray();
            int[] ini = new int[4];
            ini[0] = System.Convert.ToInt32(str.Substring(0, 2), 16);
            ini[1] = System.Convert.ToInt32(str.Substring(2, 2), 16);
            ini[2] = System.Convert.ToInt32(str.Substring(4, 2), 16);
            ini[3] = System.Convert.ToInt32(str.Substring(6, 2), 16);
            return ini[0] + "." + ini[1] + "." + ini[2] + "." + ini[3];
        }
    }
}
