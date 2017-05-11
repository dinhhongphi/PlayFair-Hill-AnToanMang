using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoa.UI
{
    public partial class Hill : UserControl
    {
        private int Matrix_size;
        private MaHoa.Hill hillCypher;

        public Hill()
        {
            InitializeComponent();
            //init sizeMatrix equal 1
            radioButton1.PerformClick();
            rdbMaHoa.PerformClick();
        }


        /// <summary>
        /// Draw size Matrix
        /// </summary>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var control = ((RadioButton)sender).Text;
            switch (control)
            {
                case "1 x 1":
                    Matrix_size = 1;
                    break;
                case "2 x 2":
                    Matrix_size = 2;
                    break;
                case "3 x 3":
                    Matrix_size = 3;
                    break;
                case "4 x 4":
                    Matrix_size = 4;
                    break;
                case "5 x 5":
                    Matrix_size = 5;
                    break;
            }
        }

        private void radioButtonMethod_CheckedChanged(object sender, EventArgs e)
        {
            var control = ((RadioButton)sender).Name;
            if(control == "rdbGiaiMa")
            {
                lblA.Text = "Cypher Text";
                lblB.Text = "Plain Text";
                btnExecute.Text = "Giải Mã";
            }
            else
            {
                lblB.Text = "Cypher Text";
                lblA.Text = "Plain Text";
                btnExecute.Text = "Mã Hóa";
            }
        }

        private void btnRandomMatrix_Click(object sender, EventArgs e)
        {
            //remove old item in matrix
            this.groupBox1.Controls.Clear();
            //init matrix
            hillCypher = new MaHoa.Hill(txtA.Text, Matrix_size);
            //show matrix
            var X_begin = 7;
            var Y_begin = 19;
            for (int i = 1; i <= Matrix_size; i++)
            {
                for (int j = 1; j <= Matrix_size; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Location = new System.Drawing.Point(X_begin, Y_begin);
                    txt.Name = "txt" + i.ToString() + j.ToString();
                    txt.Size = new System.Drawing.Size(44, 20);
                    txt.Enabled = false;
                    txt.Text = hillCypher.Matrix.Get(i - 1, j - 1).ToString();
                    this.groupBox1.Controls.Add(txt);
                    X_begin += 52;
                }
                X_begin = 7;
                Y_begin += 32;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (this.rdbMaHoa.Checked)
            {
                hillCypher.Data = txtA.Text;
                var result = hillCypher.Encrypt();
                txtB.Text = result;
            }
        }
    }
}
