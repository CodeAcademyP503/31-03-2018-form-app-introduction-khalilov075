namespace FormCRUD
{
    partial class WelcomeScreen
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
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SelectForDelete = new System.Windows.Forms.ComboBox();
            this.SelectForUpdate = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(90, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(158, 20);
            this.NameBox.TabIndex = 0;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(90, 45);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(158, 20);
            this.SurnameBox.TabIndex = 0;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(90, 75);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(158, 20);
            this.AgeBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(15, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name : ";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(15, 45);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(58, 13);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Surname : ";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(15, 75);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(32, 13);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Age :";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 2;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(263, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 33);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "CREATE";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(18, 125);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(759, 211);
            this.ResultBox.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderSize = 2;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Location = new System.Drawing.Point(378, 62);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 33);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatAppearance.BorderSize = 2;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Location = new System.Drawing.Point(378, 15);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(99, 33);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // ReadButton
            // 
            this.ReadButton.FlatAppearance.BorderSize = 2;
            this.ReadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ReadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadButton.Location = new System.Drawing.Point(263, 62);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(99, 33);
            this.ReadButton.TabIndex = 2;
            this.ReadButton.Text = "READ";
            this.ReadButton.UseVisualStyleBackColor = true;
            // 
            // SelectForDelete
            // 
            this.SelectForDelete.FormattingEnabled = true;
            this.SelectForDelete.Location = new System.Drawing.Point(502, 66);
            this.SelectForDelete.Name = "SelectForDelete";
            this.SelectForDelete.Size = new System.Drawing.Size(121, 21);
            this.SelectForDelete.TabIndex = 4;
            // 
            // SelectForUpdate
            // 
            this.SelectForUpdate.FormattingEnabled = true;
            this.SelectForUpdate.Location = new System.Drawing.Point(502, 22);
            this.SelectForUpdate.Name = "SelectForUpdate";
            this.SelectForUpdate.Size = new System.Drawing.Size(121, 21);
            this.SelectForUpdate.TabIndex = 4;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 369);
            this.Controls.Add(this.SelectForUpdate);
            this.Controls.Add(this.SelectForDelete);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.ComboBox SelectForDelete;
        private System.Windows.Forms.ComboBox SelectForUpdate;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}