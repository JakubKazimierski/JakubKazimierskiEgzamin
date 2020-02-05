namespace ZadanieA1
{
    partial class FormA1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxLogIn = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.LabelAfterLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxLogIn
            // 
            this.TextBoxLogIn.Location = new System.Drawing.Point(234, 88);
            this.TextBoxLogIn.Name = "TextBoxLogIn";
            this.TextBoxLogIn.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLogIn.TabIndex = 0;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(234, 158);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPassword.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.Location = new System.Drawing.Point(56, 88);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(116, 23);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "LogIn";
            this.LabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSurname
            // 
            this.LabelSurname.Location = new System.Drawing.Point(56, 158);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(116, 23);
            this.LabelSurname.TabIndex = 3;
            this.LabelSurname.Text = "Password";
            this.LabelSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonA1
            // 
            this.buttonA1.Location = new System.Drawing.Point(106, 254);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(166, 57);
            this.buttonA1.TabIndex = 4;
            this.buttonA1.Text = "A1 Zaloguj";
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.buttonA1_Click);
            // 
            // LabelAfterLog
            // 
            this.LabelAfterLog.Location = new System.Drawing.Point(117, 353);
            this.LabelAfterLog.Name = "LabelAfterLog";
            this.LabelAfterLog.Size = new System.Drawing.Size(131, 38);
            this.LabelAfterLog.TabIndex = 5;
            this.LabelAfterLog.Text = "Zalogowano";
            this.LabelAfterLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAfterLog.Visible = false;
            // 
            // FormA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 400);
            this.Controls.Add(this.LabelAfterLog);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.LabelSurname);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxLogIn);
            this.Name = "FormA1";
            this.Text = "ZadA1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxLogIn;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Label LabelAfterLog;
    }
}

