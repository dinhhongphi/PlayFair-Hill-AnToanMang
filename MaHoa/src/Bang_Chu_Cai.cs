using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoa
{
    public static class Bang_Chu_cai
    {
        public static int GetPosition(char Chu_cai)
        {
            return (int)(Chu_cai) - 64;
        }
        public static char GetCharacter(int x)
        {
            return (char)(x + 64);
        }
        public static char Seed(int currentPos, int offset)
        {
            int c = (currentPos + offset) % 26;
            return (char)(c + 64);
        }
        public static string Tolist()
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
