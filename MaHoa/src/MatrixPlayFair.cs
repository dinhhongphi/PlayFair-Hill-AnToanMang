using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa
{
    public class MatrixPlayFair : Matrix
    {
        public MatrixPlayFair(int n_matrix) : base(n_matrix)
        {

        }

        /// <summary>
        /// Init matrix key
        /// </summary>
        /// <param name="key"></param>
        public void CreateMatrix(string key)
        {
            string temp = String.Copy(key);
            var alpha = Bang_Chu_cai.Tolist();
            var an = alpha + "0123456789";
            //remove space
            temp = temp.Replace(" ", "");
            temp = temp.ToUpper();
            //key don't have contain special character
            foreach(char c in temp)
            {
                if (!an.Contains<char>(c))
                    throw new ArgumentException("key don't have special character");
            }
            temp += alpha;
            if(N_matrix == 5)
            {
                temp = temp.Replace('J', 'I');
            }else if(N_matrix == 6)
            {
                temp += "0123456789";
            }
            else
            {
                throw new Exception("size of matrix in [5,6]");
            }
            temp = RemoveSameCharacter(temp);

            int k = 0;
            foreach (char x in temp.ToCharArray())
            {
                base.Set(k / N_matrix, k % N_matrix, x);
                k++;
            }
        }
        /// <summary>
        /// Delete same character string
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
#if TEST
        public string RemoveSameCharacter(string key)
#else
        private string RemoveSameCharacter(string key)
#endif
        {
            //remove same character
            int i = 0;
            while (i < key.Length - 1)
            {
                int j = i + 1;
                while (j < key.Length)
                {
                    if (key[i] == key[j])
                    {
                        key = key.Remove(j, 1);
                    }
                    else
                    {
                        j++;
                    }
                }
                i++;
            }
            return key;
        }

        /// <summary>
        /// Find Coordinate of a character in matrix
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Coordinate GetCoordinate(char key)
        {
            key = key.ToString().ToUpper()[0];
            for(int i = 0; i < N_matrix; i++)
            {
                for(int j = 0; j < N_matrix; j++)
                {
                    if(matrix[i,j] == key)
                    {
                        Coordinate temp = new Coordinate()
                        {
                            I = i,
                            J = j
                        };
                        return temp;
                    }
                }
            }
            return null;
        }
    }
}
