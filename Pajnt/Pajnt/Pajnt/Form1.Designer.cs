﻿namespace Pajnt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtr1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtr2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtr3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bColor = new System.Windows.Forms.Button();
            this.tbRozmiar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.obrazToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.SizeChanged += new System.EventHandler(this.menuStrip1_SizeChanged);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz...";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // obrazToolStripMenuItem
            // 
            this.obrazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrToolStripMenuItem});
            this.obrazToolStripMenuItem.Name = "obrazToolStripMenuItem";
            this.obrazToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.obrazToolStripMenuItem.Text = "Obraz";
            // 
            // filtrToolStripMenuItem
            // 
            this.filtrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtr1ToolStripMenuItem,
            this.filtr2ToolStripMenuItem,
            this.filtr3ToolStripMenuItem});
            this.filtrToolStripMenuItem.Name = "filtrToolStripMenuItem";
            this.filtrToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.filtrToolStripMenuItem.Text = "Filtr";
            // 
            // filtr1ToolStripMenuItem
            // 
            this.filtr1ToolStripMenuItem.Name = "filtr1ToolStripMenuItem";
            this.filtr1ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.filtr1ToolStripMenuItem.Text = "Filtr1";
            // 
            // filtr2ToolStripMenuItem
            // 
            this.filtr2ToolStripMenuItem.Name = "filtr2ToolStripMenuItem";
            this.filtr2ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.filtr2ToolStripMenuItem.Text = "Filtr2";
            // 
            // filtr3ToolStripMenuItem
            // 
            this.filtr3ToolStripMenuItem.Name = "filtr3ToolStripMenuItem";
            this.filtr3ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.filtr3ToolStripMenuItem.Text = "Filtr3";
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(15, 9);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(75, 44);
            this.bColor.TabIndex = 2;
            this.bColor.Text = "Kolor";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // tbRozmiar
            // 
            this.tbRozmiar.Location = new System.Drawing.Point(15, 117);
            this.tbRozmiar.Name = "tbRozmiar";
            this.tbRozmiar.Size = new System.Drawing.Size(75, 20);
            this.tbRozmiar.TabIndex = 3;
            this.tbRozmiar.Text = "20";
            this.tbRozmiar.TextChanged += new System.EventHandler(this.tbRozmiar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rozmiar";
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbImage.Location = new System.Drawing.Point(162, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(656, 394);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Controls.Add(this.bColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 394);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRozmiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtr1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtr2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtr3ToolStripMenuItem;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.TextBox tbRozmiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel1;
    }
}
