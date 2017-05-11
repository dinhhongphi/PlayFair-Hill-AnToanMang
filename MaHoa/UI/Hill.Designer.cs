namespace MaHoa.UI
{
    partial class Hill
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnRandomMatrix = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbGiaiMa = new System.Windows.Forms.RadioButton();
            this.rdbMaHoa = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thuật toán Hill";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(3, 58);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(51, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "PlainText";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(70, 55);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(291, 20);
            this.txtA.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Matrix";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(375, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 182);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrix Size";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(24, 151);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5 x 5";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 118);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4 x 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(24, 85);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3 x 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(48, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2 x 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 x 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(3, 323);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(64, 13);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "Cypher Text";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(70, 320);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(291, 20);
            this.txtB.TabIndex = 1;
            // 
            // btnRandomMatrix
            // 
            this.btnRandomMatrix.Location = new System.Drawing.Point(286, 180);
            this.btnRandomMatrix.Name = "btnRandomMatrix";
            this.btnRandomMatrix.Size = new System.Drawing.Size(75, 51);
            this.btnRandomMatrix.TabIndex = 4;
            this.btnRandomMatrix.Text = "Random Matrix";
            this.btnRandomMatrix.UseVisualStyleBackColor = true;
            this.btnRandomMatrix.Click += new System.EventHandler(this.btnRandomMatrix_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(375, 311);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(143, 36);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Mã hóa";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbGiaiMa);
            this.groupBox3.Controls.Add(this.rdbMaHoa);
            this.groupBox3.Location = new System.Drawing.Point(375, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 77);
            this.groupBox3.TabIndex = 3;
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
            // Hill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnRandomMatrix);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Name = "Hill";
            this.Size = new System.Drawing.Size(531, 357);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnRandomMatrix;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbGiaiMa;
        private System.Windows.Forms.RadioButton rdbMaHoa;
    }
}
