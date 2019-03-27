namespace FactorialDoWhileConnorQ
{
    partial class frmFactorialDoWhile
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.lblFactorialAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(262, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(120, 26);
            this.txtInput.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(285, 133);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 31);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 24;
            this.lstOutput.Location = new System.Drawing.Point(204, 189);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(244, 148);
            this.lstOutput.TabIndex = 2;
            // 
            // lblFactorialAnswer
            // 
            this.lblFactorialAnswer.AutoSize = true;
            this.lblFactorialAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorialAnswer.Location = new System.Drawing.Point(272, 363);
            this.lblFactorialAnswer.Name = "lblFactorialAnswer";
            this.lblFactorialAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblFactorialAnswer.TabIndex = 3;
            // 
            // frmFactorialDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 421);
            this.Controls.Add(this.lblFactorialAnswer);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInput);
            this.Name = "frmFactorialDoWhile";
            this.Text = "Factorial Do While by Connor Quinlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Label lblFactorialAnswer;
    }
}

