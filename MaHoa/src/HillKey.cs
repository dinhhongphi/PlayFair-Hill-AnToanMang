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
#if TEST
        public Matrix_Int matrix_int;
#else
        protected Matrix_Int matrix_int;
#endif

        public HillKey(int n) : base(n)
        {
            int i = 0;
            Random rd = new Random();
            matrix_int = new Matrix_Int(n);
            do
            {
                while (i < n * n)
                {
                    int r = rd.Next(26);
                    matrix_int.Set(i / n, i % n, r); //A = 0
                    char c = Bang_Chu_cai.GetCharacter(r + 1);
                    matrix[i / n, i % n] = c;
                    i++;
                }
            } while (matrix_int.Determinant() == 0);
        }
    }
}
