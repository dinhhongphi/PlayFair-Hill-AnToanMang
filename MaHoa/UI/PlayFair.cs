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
    public partial class PlayFair : UserControl
    {
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
            var X_begin = 7;
            var Y_begin = 19;
            for (int i = 1; i <= value; i++)
            {
                for (int j = 1; j <= value; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Location = new System.Drawing.Point(X_begin, Y_begin);
                    txt.Name = "txt7";
                    txt.Size = new System.Drawing.Size(44, 20);
                    txt.Enabled = false;
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
    }
}
