namespace ZadanieLabNr6
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
            this.send = new System.Windows.Forms.Button();
            this.powiadomienie = new System.Windows.Forms.TextBox();
            this.powiadomieniaPolicji = new System.Windows.Forms.TextBox();
            this.powiadomieniaStraz = new System.Windows.Forms.TextBox();
            this.powiadomieniaPogotowie = new System.Windows.Forms.TextBox();
            this.policja = new System.Windows.Forms.CheckBox();
            this.straz = new System.Windows.Forms.CheckBox();
            this.Pogotowie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(276, 24);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 0;
            this.send.Text = "Wyślij";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // powiadomienie
            // 
            this.powiadomienie.Location = new System.Drawing.Point(34, 24);
            this.powiadomienie.Name = "powiadomienie";
            this.powiadomienie.Size = new System.Drawing.Size(213, 20);
            this.powiadomienie.TabIndex = 1;
            this.powiadomienie.TextChanged += new System.EventHandler(this.powiadomienie_TextChanged);
            // 
            // powiadomieniaPolicji
            // 
            this.powiadomieniaPolicji.Location = new System.Drawing.Point(34, 291);
            this.powiadomieniaPolicji.Multiline = true;
            this.powiadomieniaPolicji.Name = "powiadomieniaPolicji";
            this.powiadomieniaPolicji.Size = new System.Drawing.Size(213, 147);
            this.powiadomieniaPolicji.TabIndex = 2;
            // 
            // powiadomieniaStraz
            // 
            this.powiadomieniaStraz.Location = new System.Drawing.Point(554, 291);
            this.powiadomieniaStraz.Multiline = true;
            this.powiadomieniaStraz.Name = "powiadomieniaStraz";
            this.powiadomieniaStraz.Size = new System.Drawing.Size(213, 147);
            this.powiadomieniaStraz.TabIndex = 3;
            // 
            // powiadomieniaPogotowie
            // 
            this.powiadomieniaPogotowie.Location = new System.Drawing.Point(294, 291);
            this.powiadomieniaPogotowie.Multiline = true;
            this.powiadomieniaPogotowie.Name = "powiadomieniaPogotowie";
            this.powiadomieniaPogotowie.Size = new System.Drawing.Size(213, 147);
            this.powiadomieniaPogotowie.TabIndex = 4;
            // 
            // policja
            // 
            this.policja.AutoSize = true;
            this.policja.Location = new System.Drawing.Point(100, 268);
            this.policja.Name = "policja";
            this.policja.Size = new System.Drawing.Size(57, 17);
            this.policja.TabIndex = 8;
            this.policja.Text = "Policja";
            this.policja.UseVisualStyleBackColor = true;
            this.policja.CheckedChanged += new System.EventHandler(this.policja_CheckedChanged);
            // 
            // straz
            // 
            this.straz.AutoSize = true;
            this.straz.Location = new System.Drawing.Point(610, 268);
            this.straz.Name = "straz";
            this.straz.Size = new System.Drawing.Size(92, 17);
            this.straz.TabIndex = 9;
            this.straz.Text = "Straż Pożarna";
            this.straz.UseVisualStyleBackColor = true;
            this.straz.CheckedChanged += new System.EventHandler(this.straz_CheckedChanged);
            // 
            // Pogotowie
            // 
            this.Pogotowie.AutoSize = true;
            this.Pogotowie.Location = new System.Drawing.Point(372, 268);
            this.Pogotowie.Name = "Pogotowie";
            this.Pogotowie.Size = new System.Drawing.Size(76, 17);
            this.Pogotowie.TabIndex = 10;
            this.Pogotowie.Text = "Pogotowie";
            this.Pogotowie.UseVisualStyleBackColor = true;
            this.Pogotowie.CheckedChanged += new System.EventHandler(this.Pogotowie_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pogotowie);
            this.Controls.Add(this.straz);
            this.Controls.Add(this.policja);
            this.Controls.Add(this.powiadomieniaPogotowie);
            this.Controls.Add(this.powiadomieniaStraz);
            this.Controls.Add(this.powiadomieniaPolicji);
            this.Controls.Add(this.powiadomienie);
            this.Controls.Add(this.send);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox powiadomienie;
        private System.Windows.Forms.TextBox powiadomieniaPolicji;
        private System.Windows.Forms.TextBox powiadomieniaStraz;
        private System.Windows.Forms.TextBox powiadomieniaPogotowie;
        private System.Windows.Forms.CheckBox policja;
        private System.Windows.Forms.CheckBox straz;
        private System.Windows.Forms.CheckBox Pogotowie;
    }
}

