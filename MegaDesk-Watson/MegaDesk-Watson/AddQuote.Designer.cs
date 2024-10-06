namespace MegaDesk_Watson
{
    partial class AddQuote
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
            this.closeAddQuote = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.Depth = new System.Windows.Forms.TextBox();
            this.Drawers = new System.Windows.Forms.TextBox();
            this.GetQuote = new System.Windows.Forms.Button();
            this.RushInput = new System.Windows.Forms.ComboBox();
            this.MaterialBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeAddQuote
            // 
            this.closeAddQuote.Location = new System.Drawing.Point(661, 369);
            this.closeAddQuote.Name = "closeAddQuote";
            this.closeAddQuote.Size = new System.Drawing.Size(127, 69);
            this.closeAddQuote.TabIndex = 0;
            this.closeAddQuote.Text = "Close";
            this.closeAddQuote.UseVisualStyleBackColor = true;
            this.closeAddQuote.Click += new System.EventHandler(this.closeAddQuote_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(138, 50);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 26);
            this.FirstName.TabIndex = 8;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(498, 50);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 26);
            this.LastName.TabIndex = 9;
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(143, 150);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 26);
            this.Width.TabIndex = 10;
            this.Width.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // Depth
            // 
            this.Depth.Location = new System.Drawing.Point(507, 150);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(100, 26);
            this.Depth.TabIndex = 11;
            this.Depth.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_Validating);
            // 
            // Drawers
            // 
            this.Drawers.Location = new System.Drawing.Point(213, 250);
            this.Drawers.Name = "Drawers";
            this.Drawers.Size = new System.Drawing.Size(100, 26);
            this.Drawers.TabIndex = 12;
            this.Drawers.Validating += new System.ComponentModel.CancelEventHandler(this.Drawer_Validating);
            // 
            // GetQuote
            // 
            this.GetQuote.Location = new System.Drawing.Point(528, 369);
            this.GetQuote.Name = "GetQuote";
            this.GetQuote.Size = new System.Drawing.Size(127, 69);
            this.GetQuote.TabIndex = 15;
            this.GetQuote.Text = "Get Quote";
            this.GetQuote.UseVisualStyleBackColor = true;
            this.GetQuote.Click += new System.EventHandler(this.GetQuote_Click);
            // 
            // RushInput
            // 
            this.RushInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushInput.FormattingEnabled = true;
            this.RushInput.Items.AddRange(new object[] {
            "0",
            "3",
            "5",
            "7"});
            this.RushInput.Location = new System.Drawing.Point(144, 350);
            this.RushInput.Name = "RushInput";
            this.RushInput.Size = new System.Drawing.Size(100, 28);
            this.RushInput.TabIndex = 16;
            // 
            // MaterialBox
            // 
            this.MaterialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialBox.FormattingEnabled = true;
            this.MaterialBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.MaterialBox.Location = new System.Drawing.Point(525, 250);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.Size = new System.Drawing.Size(127, 28);
            this.MaterialBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(144)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(144)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(381, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(144)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(19, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Desk Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(144)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(381, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Desk Depth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(144)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(19, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Number of Drawers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(144)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(19, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rush Order:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(144)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(381, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Desk Material:";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.RushInput);
            this.Controls.Add(this.GetQuote);
            this.Controls.Add(this.Drawers);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.closeAddQuote);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeAddQuote;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Depth;
        private System.Windows.Forms.TextBox Drawers;
        private System.Windows.Forms.Button GetQuote;
        private System.Windows.Forms.ComboBox RushInput;
        private System.Windows.Forms.ComboBox MaterialBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}