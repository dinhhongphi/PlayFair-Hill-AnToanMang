﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa
{
    //Alphabet A = 1
    public class Hill
    {
#if TEST
        public string Data;
        public int n_matrix;
        public HillKey Matrix;
#else
        private string Data;
        private int n_matrix;
        private HillKey Matrix;
#endif

        public Hill(string data, int n)
        {
            this.Data = data;
            this.n_matrix = n;
            this.Matrix = new HillKey(n_matrix);
            Validate();
        }

        private bool Validate()
        {
            //delete whitespace in data
            int i = 0;
            while (i < Data.Length)
            {
                if (Data[i] == ' ')
                {
                    Data = Data.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            //add 'X' character 
            i = Data.Length % n_matrix;
            if (i != 0) //don't enough character
            {
                for (int j = 1; j <= n_matrix - i; i++)
                {
                    Data = Data.Insert(Data.Length, "X");
                }
            }
            return true;
        }
#if TEST
        public char[] Encrypt_N_Char(char[] n_char)
#else
        private char[] Encrypt_N_Char(char[] n_char)
#endif
        {
            int i = 0;
            List<char> data_return = new List<char>();
            while (i < n_matrix)
            {
                int j = 0, temp = 0;
                while (j < n_matrix)
                {
                    temp += (Bang_Chu_cai.GetPosition(n_char[j]) - 1) * (Bang_Chu_cai.GetPosition(Matrix.Get(i, j)) - 1); //A = 0
                    j++;
                }
                data_return.Add(Bang_Chu_cai.GetCharacter(temp % 26 + 1));
                i++;
            }
            return data_return.ToArray();
        }

        public string Encrypt()
        {
            int i = 0;
            string data_return = "";
            while(i < Data.Length)
            {
                //encrypt one-to-one group character
                string x = Data.Substring(i, n_matrix);
                char[] encrypt_n_char = Encrypt_N_Char(x.ToCharArray());
                foreach(char temp in encrypt_n_char)
                {
                    data_return += temp;
                }
                i += n_matrix;
            }
            return data_return;
        }
    }
}