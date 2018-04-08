namespace CinemaApp
{
    partial class CheckOut
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectedSeats = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.netice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(83, 43);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(168, 20);
            this.NameBox.TabIndex = 0;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(83, 72);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(168, 20);
            this.SurnameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname :";
            // 
            // SelectedSeats
            // 
            this.SelectedSeats.AutoSize = true;
            this.SelectedSeats.Location = new System.Drawing.Point(19, 21);
            this.SelectedSeats.Name = "SelectedSeats";
            this.SelectedSeats.Size = new System.Drawing.Size(91, 13);
            this.SelectedSeats.TabIndex = 3;
            this.SelectedSeats.Text = "Secdiyiniz yerler : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // netice
            // 
            this.netice.AutoSize = true;
            this.netice.Location = new System.Drawing.Point(18, 149);
            this.netice.Name = "netice";
            this.netice.Size = new System.Drawing.Size(47, 13);
            this.netice.TabIndex = 5;
            this.netice.Text = "Netice : ";
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.netice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SelectedSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectedSeats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label netice;
    }
}