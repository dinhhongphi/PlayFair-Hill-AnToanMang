using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    static class Bang_Chu_cai
    {
        static int GetPosition(char Chu_cai)
        {
            return (int)(Chu_cai) - 64;
        }
        static char GetCharacter(int x)
        {
            return (char)(x + 64);
        }
        static char Seed(int currentPos, int offset)
        {
            int c = (currentPos + offset) % 26;
            return (char)(c + 64);
        }
        static string Tolist()
        {
            string str = null;
            for (int i = 0; i < 26; i++)
            {
                str += (char)(65 + i);
            }
            return str;
        }
    }
}
