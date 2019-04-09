namespace RunningAverageConnorQ
{
    partial class frmRunningAverage
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
            this.lblNext = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblAverageText = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.lblAverageNumber = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(215, 91);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(96, 19);
            this.lblNext.TabIndex = 0;
            this.lblNext.Text = "Next Number:";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(350, 87);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(125, 26);
            this.txtInput.TabIndex = 1;
            // 
            // lblAverageText
            // 
            this.lblAverageText.AutoSize = true;
            this.lblAverageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageText.Location = new System.Drawing.Point(259, 198);
            this.lblAverageText.Name = "lblAverageText";
            this.lblAverageText.Size = new System.Drawing.Size(180, 20);
            this.lblAverageText.TabIndex = 2;
            this.lblAverageText.Text = "Your running average is:";
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinish.Location = new System.Drawing.Point(272, 128);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(135, 20);
            this.lblFinish.TabIndex = 3;
            this.lblFinish.Text = "Enter (-1) to finish";
            // 
            // lblAverageNumber
            // 
            this.lblAverageNumber.AutoSize = true;
            this.lblAverageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageNumber.Location = new System.Drawing.Point(272, 260);
            this.lblAverageNumber.Name = "lblAverageNumber";
            this.lblAverageNumber.Size = new System.Drawing.Size(18, 20);
            this.lblAverageNumber.TabIndex = 4;
            this.lblAverageNumber.Text = "?";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(516, 87);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 28);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Add Number";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 364);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAverageNumber);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblAverageText);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblNext);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average by Connor Quinlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAverageText;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label lblAverageNumber;
        private System.Windows.Forms.Button btnCalculate;
    }
}

