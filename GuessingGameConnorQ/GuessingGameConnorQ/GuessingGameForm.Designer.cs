namespace GuessingGameConnorQ
{
    partial class frmGuessingGame
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.picCheckX = new System.Windows.Forms.PictureBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblWrong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCheckX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(63, 119);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(402, 23);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Guess the number I\'m thinking of from 1 to 10";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(481, 116);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 32);
            this.txtInput.TabIndex = 1;
            // 
            // picCheckX
            // 
            this.picCheckX.Image = global::GuessingGameConnorQ.Properties.Resources.red_x;
            this.picCheckX.Location = new System.Drawing.Point(67, 256);
            this.picCheckX.Name = "picCheckX";
            this.picCheckX.Size = new System.Drawing.Size(96, 85);
            this.picCheckX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheckX.TabIndex = 2;
            this.picCheckX.TabStop = false;
            this.picCheckX.Tag = "";
            this.picCheckX.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(327, 180);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 31);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.Green;
            this.lblCorrect.Location = new System.Drawing.Point(296, 278);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(144, 23);
            this.lblCorrect.TabIndex = 4;
            this.lblCorrect.Text = "You got it right!";
            this.lblCorrect.Visible = false;
            // 
            // lblWrong
            // 
            this.lblWrong.AutoSize = true;
            this.lblWrong.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrong.ForeColor = System.Drawing.Color.Red;
            this.lblWrong.Location = new System.Drawing.Point(296, 278);
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(203, 23);
            this.lblWrong.TabIndex = 5;
            this.lblWrong.Text = "Sorry you got it wrong.";
            this.lblWrong.Visible = false;
            // 
            // frmGuessingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 384);
            this.Controls.Add(this.lblWrong);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.picCheckX);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmGuessingGame";
            this.Text = "Guessing Game by Connor Quinlan";
            this.Load += new System.EventHandler(this.frmGuessingGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCheckX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.PictureBox picCheckX;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblWrong;
    }
}

