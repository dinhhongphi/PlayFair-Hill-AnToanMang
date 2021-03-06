﻿using System;
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
    public partial class PlayFair : UserControl
    {
        private MaHoa.PlayFair playfair;
        public PlayFair()
        {
            InitializeComponent();
            radioButton4.PerformClick();
            rdbMaHoa.PerformClick();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //remove old item in matrix
            this.groupBox1.Controls.Clear();
            var control = ((RadioButton)sender).Text;
            int value = 0;
            switch (control)
            {
                case "6 x 6":
                    value = 6;
                    break;
                case "5 x 5":
                    value = 5;
                    break;
            }
            playfair = new MaHoa.PlayFair(value);
        }


        private void DrawMatrix(MaHoa.Matrix matrix, bool allowModifier)
        {
            //remove old item in matrix
            this.groupBox1.Controls.Clear();
            //show matrix
            var X_begin = 7;
            var Y_begin = 19;
            for (int i = 1; i <= matrix.N_matrix; i++)
            {
                for (int j = 1; j <= matrix.N_matrix; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Location = new System.Drawing.Point(X_begin, Y_begin);
                    txt.Name = "txt" + i.ToString() + j.ToString();
                    txt.Size = new System.Drawing.Size(44, 20);
                    txt.Enabled = allowModifier;
                    if (matrix != null)
                    {
                        txt.Text = matrix.Get(i - 1, j - 1).ToString();
                    }
                    this.groupBox1.Controls.Add(txt);
                    X_begin += 52;
                }
                X_begin = 7;
                Y_begin += 32;
            }
        }

        private void radioButtonMethod_CheckedChanged(object sender, EventArgs e)
        {
            var control = ((RadioButton)sender).Name;
            if (control == "rdbGiaiMa")
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

        private void btnInitMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                var matrix = playfair.InitMatrix(txtKey.Text);
                DrawMatrix(matrix, false);
            }catch(Exception ex)
            {
                MessageBox.Show("Error while init matrix with key", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (rdbMaHoa.Checked)
            {
                try
                {
                    string result = playfair.Encrypt(txtInput.Text);
                    txtResult.Text = result;
                }catch(Exception ex)
                {
                    MessageBox.Show("Error while encrypt data", "Error", MessageBoxButtons.OK);
                }
            }
            else //giai ma
            {
                try
                {
                    string result = playfair.Decrypt(txtInput.Text);
                    txtResult.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while encrypt data", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
