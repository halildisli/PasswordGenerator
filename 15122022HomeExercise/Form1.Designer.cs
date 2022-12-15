namespace _15122022HomeExercise
{
    partial class PasswordGenerator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxUpperCase = new System.Windows.Forms.CheckBox();
            this.checkBoxLowerCase = new System.Windows.Forms.CheckBox();
            this.checkBoxNumeric = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.numericUpDownPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPasswordNumber = new System.Windows.Forms.NumericUpDown();
            this.PasswordLength = new System.Windows.Forms.Label();
            this.PasswordNumber = new System.Windows.Forms.Label();
            this.buttonGeneratePassword = new System.Windows.Forms.Button();
            this.textBoxPasswords = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGeneratePassword);
            this.groupBox1.Controls.Add(this.PasswordNumber);
            this.groupBox1.Controls.Add(this.PasswordLength);
            this.groupBox1.Controls.Add(this.numericUpDownPasswordNumber);
            this.groupBox1.Controls.Add(this.numericUpDownPasswordLength);
            this.groupBox1.Controls.Add(this.checkBoxSpecial);
            this.groupBox1.Controls.Add(this.checkBoxUpperCase);
            this.groupBox1.Controls.Add(this.checkBoxNumeric);
            this.groupBox1.Controls.Add(this.checkBoxLowerCase);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(288, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // checkBoxUpperCase
            // 
            this.checkBoxUpperCase.AutoSize = true;
            this.checkBoxUpperCase.Location = new System.Drawing.Point(9, 44);
            this.checkBoxUpperCase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxUpperCase.Name = "checkBoxUpperCase";
            this.checkBoxUpperCase.Size = new System.Drawing.Size(112, 21);
            this.checkBoxUpperCase.TabIndex = 1;
            this.checkBoxUpperCase.Text = "Upper Case";
            this.checkBoxUpperCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowerCase
            // 
            this.checkBoxLowerCase.AutoSize = true;
            this.checkBoxLowerCase.Location = new System.Drawing.Point(9, 72);
            this.checkBoxLowerCase.Name = "checkBoxLowerCase";
            this.checkBoxLowerCase.Size = new System.Drawing.Size(111, 21);
            this.checkBoxLowerCase.TabIndex = 1;
            this.checkBoxLowerCase.Text = "Lower Case";
            this.checkBoxLowerCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumeric
            // 
            this.checkBoxNumeric.AutoSize = true;
            this.checkBoxNumeric.Location = new System.Drawing.Point(9, 99);
            this.checkBoxNumeric.Name = "checkBoxNumeric";
            this.checkBoxNumeric.Size = new System.Drawing.Size(86, 21);
            this.checkBoxNumeric.TabIndex = 2;
            this.checkBoxNumeric.Text = "Numeric";
            this.checkBoxNumeric.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecial
            // 
            this.checkBoxSpecial.AutoSize = true;
            this.checkBoxSpecial.Location = new System.Drawing.Point(7, 126);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(164, 21);
            this.checkBoxSpecial.TabIndex = 3;
            this.checkBoxSpecial.Text = "Special Characters";
            this.checkBoxSpecial.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPasswordLength
            // 
            this.numericUpDownPasswordLength.Location = new System.Drawing.Point(154, 179);
            this.numericUpDownPasswordLength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownPasswordLength.Name = "numericUpDownPasswordLength";
            this.numericUpDownPasswordLength.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownPasswordLength.TabIndex = 4;
            this.numericUpDownPasswordLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDownPasswordNumber
            // 
            this.numericUpDownPasswordNumber.Location = new System.Drawing.Point(154, 208);
            this.numericUpDownPasswordNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPasswordNumber.Name = "numericUpDownPasswordNumber";
            this.numericUpDownPasswordNumber.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownPasswordNumber.TabIndex = 5;
            this.numericUpDownPasswordNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PasswordLength
            // 
            this.PasswordLength.AutoSize = true;
            this.PasswordLength.Location = new System.Drawing.Point(7, 181);
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(132, 17);
            this.PasswordLength.TabIndex = 1;
            this.PasswordLength.Text = "Password Length";
            // 
            // PasswordNumber
            // 
            this.PasswordNumber.AutoSize = true;
            this.PasswordNumber.Location = new System.Drawing.Point(7, 210);
            this.PasswordNumber.Name = "PasswordNumber";
            this.PasswordNumber.Size = new System.Drawing.Size(138, 17);
            this.PasswordNumber.TabIndex = 1;
            this.PasswordNumber.Text = "Password Number";
            // 
            // buttonGeneratePassword
            // 
            this.buttonGeneratePassword.Location = new System.Drawing.Point(110, 247);
            this.buttonGeneratePassword.Name = "buttonGeneratePassword";
            this.buttonGeneratePassword.Size = new System.Drawing.Size(164, 37);
            this.buttonGeneratePassword.TabIndex = 1;
            this.buttonGeneratePassword.Text = "Generate Password";
            this.buttonGeneratePassword.UseVisualStyleBackColor = true;
            this.buttonGeneratePassword.Click += new System.EventHandler(this.buttonGeneratePassword_Click);
            // 
            // textBoxPasswords
            // 
            this.textBoxPasswords.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPasswords.Location = new System.Drawing.Point(326, 24);
            this.textBoxPasswords.Multiline = true;
            this.textBoxPasswords.Name = "textBoxPasswords";
            this.textBoxPasswords.Size = new System.Drawing.Size(335, 286);
            this.textBoxPasswords.TabIndex = 1;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 324);
            this.Controls.Add(this.textBoxPasswords);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPasswordNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGeneratePassword;
        private System.Windows.Forms.Label PasswordNumber;
        private System.Windows.Forms.Label PasswordLength;
        private System.Windows.Forms.NumericUpDown numericUpDownPasswordNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownPasswordLength;
        private System.Windows.Forms.CheckBox checkBoxSpecial;
        private System.Windows.Forms.CheckBox checkBoxUpperCase;
        private System.Windows.Forms.CheckBox checkBoxNumeric;
        private System.Windows.Forms.CheckBox checkBoxLowerCase;
        private System.Windows.Forms.TextBox textBoxPasswords;
    }
}

