
namespace Guess_The_Number
{
    partial class Form1
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
            this.highLowBox = new System.Windows.Forms.TextBox();
            this.playerInput = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highLowBox
            // 
            this.highLowBox.Location = new System.Drawing.Point(12, 12);
            this.highLowBox.Multiline = true;
            this.highLowBox.Name = "highLowBox";
            this.highLowBox.Size = new System.Drawing.Size(409, 141);
            this.highLowBox.TabIndex = 0;
            // 
            // playerInput
            // 
            this.playerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInput.Location = new System.Drawing.Point(90, 224);
            this.playerInput.Multiline = true;
            this.playerInput.Name = "playerInput";
            this.playerInput.Size = new System.Drawing.Size(253, 102);
            this.playerInput.TabIndex = 1;
            this.playerInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guessButton
            // 
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(90, 345);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(253, 75);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.playerInput);
            this.Controls.Add(this.highLowBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox highLowBox;
        private System.Windows.Forms.TextBox playerInput;
        private System.Windows.Forms.Button guessButton;
    }
}

