namespace ZadanieA2
{
    partial class FormA2
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
            this.components = new System.ComponentModel.Container();
            this.ButtonA2 = new System.Windows.Forms.Button();
            this.TimerOfStartButton = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ButtonA2
            // 
            this.ButtonA2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonA2.Location = new System.Drawing.Point(38, 377);
            this.ButtonA2.Name = "ButtonA2";
            this.ButtonA2.Size = new System.Drawing.Size(111, 42);
            this.ButtonA2.TabIndex = 0;
            this.ButtonA2.Text = "A2 Start";
            this.ButtonA2.UseVisualStyleBackColor = true;
            this.ButtonA2.Click += new System.EventHandler(this.ButtonA2_Click);
            // 
            // TimerOfStartButton
            // 
            this.TimerOfStartButton.Interval = 3000;
            this.TimerOfStartButton.Tick += new System.EventHandler(this.TimerOfStartButton_Tick);
            // 
            // FormA2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 450);
            this.Controls.Add(this.ButtonA2);
            this.Name = "FormA2";
            this.Text = "FormA2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimerOfStartButton;
        public System.Windows.Forms.Button ButtonA2;
    }
}

