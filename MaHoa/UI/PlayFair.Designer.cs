namespace MaHoa.UI
{
    partial class PlayFair
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbMaHoa = new System.Windows.Forms.RadioButton();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnRandomMatrix = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbGiaiMa = new System.Windows.Forms.RadioButton();
            this.txtB = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbMaHoa
            // 
            this.rdbMaHoa.AutoSize = true;
            this.rdbMaHoa.Location = new System.Drawing.Point(24, 19);
            this.rdbMaHoa.Name = "rdbMaHoa";
            this.rdbMaHoa.Size = new System.Drawing.Size(63, 17);
            this.rdbMaHoa.TabIndex = 0;
            this.rdbMaHoa.TabStop = true;
            this.rdbMaHoa.Text = "Mã Hóa";
            this.rdbMaHoa.UseVisualStyleBackColor = true;
            this.rdbMaHoa.CheckedChanged += new System.EventHandler(this.radioButtonMethod_CheckedChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(346, 326);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(153, 36);
            this.btnExecute.TabIndex = 13;
            this.btnExecute.Text = "Mã Hóa";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // btnRandomMatrix
            // 
            this.btnRandomMatrix.Location = new System.Drawing.Point(346, 239);
            this.btnRandomMatrix.Name = "btnRandomMatrix";
            this.btnRandomMatrix.Size = new System.Drawing.Size(153, 51);
            this.btnRandomMatrix.TabIndex = 14;
            this.btnRandomMatrix.Text = "Random Matrix";
            this.btnRandomMatrix.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbGiaiMa);
            this.groupBox3.Controls.Add(this.rdbMaHoa);
            this.groupBox3.Location = new System.Drawing.Point(346, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 77);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Method";
            // 
            // rdbGiaiMa
            // 
            this.rdbGiaiMa.AutoSize = true;
            this.rdbGiaiMa.Location = new System.Drawing.Point(24, 52);
            this.rdbGiaiMa.Name = "rdbGiaiMa";
            this.rdbGiaiMa.Size = new System.Drawing.Size(61, 17);
            this.rdbGiaiMa.TabIndex = 1;
            this.rdbGiaiMa.TabStop = true;
            this.rdbGiaiMa.Text = "Giải Mã";
            this.rdbGiaiMa.UseVisualStyleBackColor = true;
            this.rdbGiaiMa.CheckedChanged += new System.EventHandler(this.radioButtonMethod_CheckedChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(70, 344);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(254, 20);
            this.txtB.TabIndex = 8;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(24, 53);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "6 x 6";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "5 x 5";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(3, 347);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(64, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Cypher Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(346, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 92);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrix Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 214);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Matrix";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(70, 54);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(254, 20);
            this.txtA.TabIndex = 9;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(3, 57);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(51, 13);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "PlainText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thuật toán PlayFair";
            // 
            // PlayFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnRandomMatrix);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Name = "PlayFair";
            this.Size = new System.Drawing.Size(512, 372);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMaHoa;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnRandomMatrix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbGiaiMa;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label1;
    }
}
