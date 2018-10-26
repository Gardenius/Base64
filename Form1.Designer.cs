namespace Base64
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Koduj = new System.Windows.Forms.Button();
            this.dekoduj = new System.Windows.Forms.Button();
            this.Input_Button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Input_Text = new System.Windows.Forms.Label();
            this.Output_Button = new System.Windows.Forms.Button();
            this.Output_Text = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Koduj
            // 
            this.Koduj.Location = new System.Drawing.Point(12, 12);
            this.Koduj.Name = "Koduj";
            this.Koduj.Size = new System.Drawing.Size(75, 23);
            this.Koduj.TabIndex = 1;
            this.Koduj.Text = "Koduj";
            this.Koduj.UseVisualStyleBackColor = true;
            this.Koduj.Click += new System.EventHandler(this.Koduj_Click);
            // 
            // dekoduj
            // 
            this.dekoduj.Location = new System.Drawing.Point(12, 41);
            this.dekoduj.Name = "dekoduj";
            this.dekoduj.Size = new System.Drawing.Size(75, 23);
            this.dekoduj.TabIndex = 1;
            this.dekoduj.Text = "Dekoduj";
            this.dekoduj.UseVisualStyleBackColor = true;
            this.dekoduj.Click += new System.EventHandler(this.dekoduj_Click);
            // 
            // Input_Button
            // 
            this.Input_Button.Location = new System.Drawing.Point(93, 12);
            this.Input_Button.Name = "Input_Button";
            this.Input_Button.Size = new System.Drawing.Size(25, 23);
            this.Input_Button.TabIndex = 2;
            this.Input_Button.Text = "...";
            this.Input_Button.UseVisualStyleBackColor = true;
            this.Input_Button.Click += new System.EventHandler(this.Input_Button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Input_Text
            // 
            this.Input_Text.AutoSize = true;
            this.Input_Text.Location = new System.Drawing.Point(124, 17);
            this.Input_Text.Name = "Input_Text";
            this.Input_Text.Size = new System.Drawing.Size(29, 13);
            this.Input_Text.TabIndex = 3;
            this.Input_Text.Text = "Path";
            // 
            // Output_Button
            // 
            this.Output_Button.Location = new System.Drawing.Point(93, 41);
            this.Output_Button.Name = "Output_Button";
            this.Output_Button.Size = new System.Drawing.Size(25, 23);
            this.Output_Button.TabIndex = 2;
            this.Output_Button.Text = "...";
            this.Output_Button.UseVisualStyleBackColor = true;
            this.Output_Button.Click += new System.EventHandler(this.Output_Button_Click);
            // 
            // Output_Text
            // 
            this.Output_Text.AutoSize = true;
            this.Output_Text.Location = new System.Drawing.Point(124, 46);
            this.Output_Text.Name = "Output_Text";
            this.Output_Text.Size = new System.Drawing.Size(29, 13);
            this.Output_Text.TabIndex = 3;
            this.Output_Text.Text = "Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 70);
            this.Controls.Add(this.Output_Text);
            this.Controls.Add(this.Input_Text);
            this.Controls.Add(this.Output_Button);
            this.Controls.Add(this.Input_Button);
            this.Controls.Add(this.dekoduj);
            this.Controls.Add(this.Koduj);
            this.Name = "Form1";
            this.Text = "Base64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Koduj;
        private System.Windows.Forms.Button dekoduj;
        private System.Windows.Forms.Button Input_Button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Input_Text;
        private System.Windows.Forms.Button Output_Button;
        private System.Windows.Forms.Label Output_Text;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

