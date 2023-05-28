namespace Mortgage_Calculator
{
    partial class Calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.downInput = new System.Windows.Forms.TextBox();
            this.downLbl = new System.Windows.Forms.Label();
            this.interestLbl = new System.Windows.Forms.Label();
            this.interestInput = new System.Windows.Forms.TextBox();
            this.termLbl = new System.Windows.Forms.Label();
            this.termInput = new System.Windows.Forms.TextBox();
            this.valueLbl = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.incomeLbl = new System.Windows.Forms.Label();
            this.incomeInput = new System.Windows.Forms.TextBox();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.downErr = new System.Windows.Forms.Label();
            this.interestErr = new System.Windows.Forms.Label();
            this.termErr = new System.Windows.Forms.Label();
            this.valueErr = new System.Windows.Forms.Label();
            this.incomeErr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(406, 376);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(115, 68);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(639, 376);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(115, 68);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // downInput
            // 
            this.downInput.Location = new System.Drawing.Point(331, 116);
            this.downInput.Name = "downInput";
            this.downInput.Size = new System.Drawing.Size(190, 22);
            this.downInput.TabIndex = 2;
            // 
            // downLbl
            // 
            this.downLbl.AutoSize = true;
            this.downLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.downLbl.Location = new System.Drawing.Point(326, 88);
            this.downLbl.Name = "downLbl";
            this.downLbl.Size = new System.Drawing.Size(144, 25);
            this.downLbl.TabIndex = 3;
            this.downLbl.Text = "Down Payment";
            // 
            // interestLbl
            // 
            this.interestLbl.AutoSize = true;
            this.interestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.interestLbl.Location = new System.Drawing.Point(326, 177);
            this.interestLbl.Name = "interestLbl";
            this.interestLbl.Size = new System.Drawing.Size(121, 25);
            this.interestLbl.TabIndex = 4;
            this.interestLbl.Text = "Interest Rate";
            // 
            // interestInput
            // 
            this.interestInput.Location = new System.Drawing.Point(331, 205);
            this.interestInput.Name = "interestInput";
            this.interestInput.Size = new System.Drawing.Size(190, 22);
            this.interestInput.TabIndex = 5;
            // 
            // termLbl
            // 
            this.termLbl.AutoSize = true;
            this.termLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.termLbl.Location = new System.Drawing.Point(326, 265);
            this.termLbl.Name = "termLbl";
            this.termLbl.Size = new System.Drawing.Size(107, 25);
            this.termLbl.TabIndex = 6;
            this.termLbl.Text = "Loan Term";
            // 
            // termInput
            // 
            this.termInput.Location = new System.Drawing.Point(331, 293);
            this.termInput.Name = "termInput";
            this.termInput.Size = new System.Drawing.Size(190, 22);
            this.termInput.TabIndex = 7;
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valueLbl.Location = new System.Drawing.Point(634, 88);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(120, 25);
            this.valueLbl.TabIndex = 9;
            this.valueLbl.Text = "Home Value";
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(639, 116);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(190, 22);
            this.valueInput.TabIndex = 8;
            // 
            // incomeLbl
            // 
            this.incomeLbl.AutoSize = true;
            this.incomeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.incomeLbl.Location = new System.Drawing.Point(634, 177);
            this.incomeLbl.Name = "incomeLbl";
            this.incomeLbl.Size = new System.Drawing.Size(136, 25);
            this.incomeLbl.TabIndex = 11;
            this.incomeLbl.Text = "Yearly Income";
            // 
            // incomeInput
            // 
            this.incomeInput.Location = new System.Drawing.Point(639, 205);
            this.incomeInput.Name = "incomeInput";
            this.incomeInput.Size = new System.Drawing.Size(190, 22);
            this.incomeInput.TabIndex = 10;
            // 
            // paymentLbl
            // 
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.paymentLbl.Location = new System.Drawing.Point(328, 498);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(0, 39);
            this.paymentLbl.TabIndex = 12;
            // 
            // downErr
            // 
            this.downErr.AutoSize = true;
            this.downErr.ForeColor = System.Drawing.Color.Red;
            this.downErr.Location = new System.Drawing.Point(328, 153);
            this.downErr.Name = "downErr";
            this.downErr.Size = new System.Drawing.Size(0, 16);
            this.downErr.TabIndex = 13;
            // 
            // interestErr
            // 
            this.interestErr.AutoSize = true;
            this.interestErr.ForeColor = System.Drawing.Color.Red;
            this.interestErr.Location = new System.Drawing.Point(328, 240);
            this.interestErr.Name = "interestErr";
            this.interestErr.Size = new System.Drawing.Size(0, 16);
            this.interestErr.TabIndex = 14;
            // 
            // termErr
            // 
            this.termErr.AutoSize = true;
            this.termErr.ForeColor = System.Drawing.Color.Red;
            this.termErr.Location = new System.Drawing.Point(335, 329);
            this.termErr.Name = "termErr";
            this.termErr.Size = new System.Drawing.Size(0, 16);
            this.termErr.TabIndex = 15;
            // 
            // valueErr
            // 
            this.valueErr.AutoSize = true;
            this.valueErr.ForeColor = System.Drawing.Color.Red;
            this.valueErr.Location = new System.Drawing.Point(636, 153);
            this.valueErr.Name = "valueErr";
            this.valueErr.Size = new System.Drawing.Size(0, 16);
            this.valueErr.TabIndex = 16;
            // 
            // incomeErr
            // 
            this.incomeErr.AutoSize = true;
            this.incomeErr.ForeColor = System.Drawing.Color.Red;
            this.incomeErr.Location = new System.Drawing.Point(636, 240);
            this.incomeErr.Name = "incomeErr";
            this.incomeErr.Size = new System.Drawing.Size(0, 16);
            this.incomeErr.TabIndex = 17;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 675);
            this.Controls.Add(this.incomeErr);
            this.Controls.Add(this.valueErr);
            this.Controls.Add(this.termErr);
            this.Controls.Add(this.interestErr);
            this.Controls.Add(this.downErr);
            this.Controls.Add(this.paymentLbl);
            this.Controls.Add(this.incomeLbl);
            this.Controls.Add(this.incomeInput);
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.termInput);
            this.Controls.Add(this.termLbl);
            this.Controls.Add(this.interestInput);
            this.Controls.Add(this.interestLbl);
            this.Controls.Add(this.downLbl);
            this.Controls.Add(this.downInput);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox downInput;
        private System.Windows.Forms.Label downLbl;
        private System.Windows.Forms.Label interestLbl;
        private System.Windows.Forms.TextBox interestInput;
        private System.Windows.Forms.Label termLbl;
        private System.Windows.Forms.TextBox termInput;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Label incomeLbl;
        private System.Windows.Forms.TextBox incomeInput;
        private System.Windows.Forms.Label paymentLbl;
        private System.Windows.Forms.Label downErr;
        private System.Windows.Forms.Label interestErr;
        private System.Windows.Forms.Label termErr;
        private System.Windows.Forms.Label valueErr;
        private System.Windows.Forms.Label incomeErr;
    }
}

