namespace ZadanieA3
{
    partial class Form1
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
            this.DataGridViewA3 = new System.Windows.Forms.DataGridView();
            this.ButtonA3 = new System.Windows.Forms.Button();
            this.ButtonA5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewA3)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewA3
            // 
            this.DataGridViewA3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewA3.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewA3.Name = "DataGridViewA3";
            this.DataGridViewA3.RowHeadersWidth = 46;
            this.DataGridViewA3.Size = new System.Drawing.Size(776, 253);
            this.DataGridViewA3.TabIndex = 0;
            // 
            // ButtonA3
            // 
            this.ButtonA3.Location = new System.Drawing.Point(251, 330);
            this.ButtonA3.Name = "ButtonA3";
            this.ButtonA3.Size = new System.Drawing.Size(359, 66);
            this.ButtonA3.TabIndex = 1;
            this.ButtonA3.Text = "A3Pracownicy";
            this.ButtonA3.UseVisualStyleBackColor = true;
            this.ButtonA3.Click += new System.EventHandler(this.ButtonA3_Click);
            // 
            // ButtonA5
            // 
            this.ButtonA5.Location = new System.Drawing.Point(251, 408);
            this.ButtonA5.Name = "ButtonA5";
            this.ButtonA5.Size = new System.Drawing.Size(359, 66);
            this.ButtonA5.TabIndex = 2;
            this.ButtonA5.Text = "A5Produkty";
            this.ButtonA5.UseVisualStyleBackColor = true;
            this.ButtonA5.Click += new System.EventHandler(this.ButtonA5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.ButtonA5);
            this.Controls.Add(this.ButtonA3);
            this.Controls.Add(this.DataGridViewA3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewA3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewA3;
        private System.Windows.Forms.Button ButtonA3;
        private System.Windows.Forms.Button ButtonA5;
    }
}

