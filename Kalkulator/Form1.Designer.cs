﻿namespace Kalkulator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.poleLiczbowe1 = new System.Windows.Forms.TextBox();
            this.mnożenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Button();
            this.dodawanie = new System.Windows.Forms.Button();
            this.odejmowanie = new System.Windows.Forms.Button();
            this.poleWynik = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(376, 285);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 41);
            this.button5.TabIndex = 6;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(326, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(276, 285);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 41);
            this.button7.TabIndex = 4;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(376, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "9";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(326, 332);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 41);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(276, 332);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 41);
            this.button9.TabIndex = 7;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // poleLiczbowe1
            // 
            this.poleLiczbowe1.Location = new System.Drawing.Point(276, 191);
            this.poleLiczbowe1.Name = "poleLiczbowe1";
            this.poleLiczbowe1.Size = new System.Drawing.Size(144, 20);
            this.poleLiczbowe1.TabIndex = 10;
            this.poleLiczbowe1.TextChanged += new System.EventHandler(this.wynik_TextChanged);
            // 
            // mnożenie
            // 
            this.mnożenie.Location = new System.Drawing.Point(441, 238);
            this.mnożenie.Name = "mnożenie";
            this.mnożenie.Size = new System.Drawing.Size(44, 41);
            this.mnożenie.TabIndex = 11;
            this.mnożenie.Text = "*";
            this.mnożenie.UseVisualStyleBackColor = true;
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(441, 285);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(44, 41);
            this.dzielenie.TabIndex = 12;
            this.dzielenie.Text = "/";
            this.dzielenie.UseVisualStyleBackColor = true;
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(441, 332);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(44, 41);
            this.wynik.TabIndex = 13;
            this.wynik.Text = "=";
            this.wynik.UseVisualStyleBackColor = true;
            this.wynik.Click += new System.EventHandler(this.przyciskWynik_Click);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(491, 238);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(44, 41);
            this.dodawanie.TabIndex = 14;
            this.dodawanie.Text = "+";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // odejmowanie
            // 
            this.odejmowanie.Location = new System.Drawing.Point(491, 285);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(44, 41);
            this.odejmowanie.TabIndex = 15;
            this.odejmowanie.Text = "-";
            this.odejmowanie.UseVisualStyleBackColor = true;
            // 
            // poleWynik
            // 
            this.poleWynik.Location = new System.Drawing.Point(441, 191);
            this.poleWynik.Name = "poleWynik";
            this.poleWynik.Size = new System.Drawing.Size(126, 20);
            this.poleWynik.TabIndex = 16;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(491, 332);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(44, 41);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.poleWynik);
            this.Controls.Add(this.odejmowanie);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnożenie);
            this.Controls.Add(this.poleLiczbowe1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox poleLiczbowe1;
        private System.Windows.Forms.Button mnożenie;
        private System.Windows.Forms.Button dzielenie;
        private System.Windows.Forms.Button wynik;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button odejmowanie;
        private System.Windows.Forms.TextBox poleWynik;
        private System.Windows.Forms.Button clear;
    }
}

