﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa
{
    public class Matrix
    {
        protected char[,] matrix;
        protected int N_matrix; //size of matrix

        public Matrix(int n)
        {
            N_matrix = n;
            matrix = new char[N_matrix, N_matrix];
        }

        public char Get(int i, int j)
        {
            return matrix[i, j];
        }

        public char Get(Coordinate cor)
        {
            return matrix[cor.I, cor.J];
        }
    }
}
