
namespace Module4Project
{
    partial class frmOfDataTypes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnByte = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.btnFloat = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnByte
            // 
            this.btnByte.BackColor = System.Drawing.Color.Gold;
            this.btnByte.Location = new System.Drawing.Point(12, 12);
            this.btnByte.Name = "btnByte";
            this.btnByte.Size = new System.Drawing.Size(113, 60);
            this.btnByte.TabIndex = 0;
            this.btnByte.Text = "Byte (+)";
            this.btnByte.UseVisualStyleBackColor = false;
            this.btnByte.Click += new System.EventHandler(this.btnByte_Click);
            // 
            // btnShort
            // 
            this.btnShort.BackColor = System.Drawing.Color.Gold;
            this.btnShort.Location = new System.Drawing.Point(131, 12);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(113, 60);
            this.btnShort.TabIndex = 1;
            this.btnShort.Text = "Short (-)";
            this.btnShort.UseVisualStyleBackColor = false;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.Gold;
            this.btnInt.Location = new System.Drawing.Point(12, 87);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(113, 60);
            this.btnInt.TabIndex = 2;
            this.btnInt.Tag = "";
            this.btnInt.Text = "Int (Int Div)";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnLong
            // 
            this.btnLong.BackColor = System.Drawing.Color.Gold;
            this.btnLong.Location = new System.Drawing.Point(131, 87);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(113, 60);
            this.btnLong.TabIndex = 3;
            this.btnLong.Text = "Long (Modulus %)";
            this.btnLong.UseVisualStyleBackColor = false;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnFloat
            // 
            this.btnFloat.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnFloat.Location = new System.Drawing.Point(12, 256);
            this.btnFloat.Name = "btnFloat";
            this.btnFloat.Size = new System.Drawing.Size(113, 60);
            this.btnFloat.TabIndex = 4;
            this.btnFloat.Text = "Float (Modulus %)";
            this.btnFloat.UseVisualStyleBackColor = false;
            this.btnFloat.Click += new System.EventHandler(this.btnFloat_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDouble.Location = new System.Drawing.Point(131, 256);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(113, 60);
            this.btnDouble.TabIndex = 5;
            this.btnDouble.Text = "Double (Decimal Div)";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDecimal.Location = new System.Drawing.Point(66, 322);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(113, 60);
            this.btnDecimal.TabIndex = 6;
            this.btnDecimal.Text = "Decimal (*)";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnPow
            // 
            this.btnPow.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPow.Location = new System.Drawing.Point(606, 87);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(113, 60);
            this.btnPow.TabIndex = 7;
            this.btnPow.Text = "Pow";
            this.btnPow.UseVisualStyleBackColor = false;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnRound
            // 
            this.btnRound.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRound.Location = new System.Drawing.Point(675, 21);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(113, 60);
            this.btnRound.TabIndex = 8;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = false;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSqrt.Location = new System.Drawing.Point(533, 21);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(113, 60);
            this.btnSqrt.TabIndex = 9;
            this.btnSqrt.Text = "Sqrt";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tan;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(533, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 60);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tan;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(675, 256);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(250, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 429);
            this.label1.TabIndex = 12;
            this.label1.Text = "Results will be displayed in this box.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmOfDataTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnFloat);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnByte);
            this.Name = "frmOfDataTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOfDataTypes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnByte;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.Button btnFloat;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

