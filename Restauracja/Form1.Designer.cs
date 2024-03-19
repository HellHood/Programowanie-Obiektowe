namespace Restauracja
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataInNrStolika = new System.Windows.Forms.NumericUpDown();
            this.dataInCena = new System.Windows.Forms.TextBox();
            this.dataInZamowienie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataOutListaDan = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataInGotowe = new System.Windows.Forms.Button();
            this.dataOutGotoweZamowienia = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInNrStolika)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.AccessibleName = "";
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Location = new System.Drawing.Point(12, 12);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(865, 477);
            this.tabPage.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.dataOutGotoweZamowienia);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataInNrStolika);
            this.tabPage1.Controls.Add(this.dataInCena);
            this.tabPage1.Controls.Add(this.dataInZamowienie);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zamówienie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nr Stolika";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataInNrStolika
            // 
            this.dataInNrStolika.Location = new System.Drawing.Point(45, 69);
            this.dataInNrStolika.Name = "dataInNrStolika";
            this.dataInNrStolika.Size = new System.Drawing.Size(120, 20);
            this.dataInNrStolika.TabIndex = 3;
            this.dataInNrStolika.ValueChanged += new System.EventHandler(this.dataInNrStolika_ValueChanged);
            // 
            // dataInCena
            // 
            this.dataInCena.Location = new System.Drawing.Point(331, 69);
            this.dataInCena.Name = "dataInCena";
            this.dataInCena.Size = new System.Drawing.Size(100, 20);
            this.dataInCena.TabIndex = 2;
            // 
            // dataInZamowienie
            // 
            this.dataInZamowienie.Location = new System.Drawing.Point(201, 69);
            this.dataInZamowienie.Name = "dataInZamowienie";
            this.dataInZamowienie.Size = new System.Drawing.Size(100, 20);
            this.dataInZamowienie.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wprowadź zamówienie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataInGotowe);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataOutListaDan);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataOutListaDan
            // 
            this.dataOutListaDan.FormattingEnabled = true;
            this.dataOutListaDan.Location = new System.Drawing.Point(32, 124);
            this.dataOutListaDan.Name = "dataOutListaDan";
            this.dataOutListaDan.Size = new System.Drawing.Size(318, 290);
            this.dataOutListaDan.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataInGotowe
            // 
            this.dataInGotowe.Location = new System.Drawing.Point(377, 218);
            this.dataInGotowe.Name = "dataInGotowe";
            this.dataInGotowe.Size = new System.Drawing.Size(113, 46);
            this.dataInGotowe.TabIndex = 2;
            this.dataInGotowe.Text = "Gotowe do wydania";
            this.dataInGotowe.UseVisualStyleBackColor = true;
            this.dataInGotowe.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataOutGotoweZamowienia
            // 
            this.dataOutGotoweZamowienia.FormattingEnabled = true;
            this.dataOutGotoweZamowienia.Location = new System.Drawing.Point(45, 243);
            this.dataOutGotoweZamowienia.Name = "dataOutGotoweZamowienia";
            this.dataOutGotoweZamowienia.Size = new System.Drawing.Size(256, 173);
            this.dataOutGotoweZamowienia.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(889, 501);
            this.Controls.Add(this.tabPage);
            this.Name = "Form1";
            this.tabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInNrStolika)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown dataInNrStolika;
        private System.Windows.Forms.TextBox dataInCena;
        private System.Windows.Forms.TextBox dataInZamowienie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox dataOutListaDan;
        private System.Windows.Forms.Button dataInGotowe;
        private System.Windows.Forms.ListBox dataOutGotoweZamowienia;
        private System.Windows.Forms.Button button3;
    }
}

