using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MaHoa
{
    //Alphabet A = 1
    public class HillKey : Matrix
    {
        public HillKey(int n) : base(n)
        {
            int i = 0;
            Random rd = new Random();
            while (i < n * n)
            {
                int r = rd.Next(26) + 1;
                char c = Bang_Chu_cai.GetCharacter(r);
                matrix[i / n, i % n] = c;
                i++;
            }
        }
    }
}
