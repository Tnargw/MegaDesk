﻿namespace MegaDesk_Watson
{
    partial class SearchQuotes
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
            this.closeSearchQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeSearchQuote
            // 
            this.closeSearchQuote.Location = new System.Drawing.Point(661, 369);
            this.closeSearchQuote.Name = "closeSearchQuote";
            this.closeSearchQuote.Size = new System.Drawing.Size(127, 69);
            this.closeSearchQuote.TabIndex = 1;
            this.closeSearchQuote.Text = "Close";
            this.closeSearchQuote.UseVisualStyleBackColor = true;
            this.closeSearchQuote.Click += new System.EventHandler(this.closeSearchQuote_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeSearchQuote);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeSearchQuote;
    }
}