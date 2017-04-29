namespace Zabawki
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
            this.ObjectTypeBox = new System.Windows.Forms.ComboBox();
            this.ObjectBox = new System.Windows.Forms.ComboBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SpeedBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.HighBox = new System.Windows.Forms.TextBox();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ObjectTypeBox
            // 
            this.ObjectTypeBox.FormattingEnabled = true;
            this.ObjectTypeBox.Location = new System.Drawing.Point(106, 24);
            this.ObjectTypeBox.Name = "ObjectTypeBox";
            this.ObjectTypeBox.Size = new System.Drawing.Size(121, 21);
            this.ObjectTypeBox.TabIndex = 0;
            this.ObjectTypeBox.SelectedIndexChanged += new System.EventHandler(this.ObjectTypeBox_SelectedIndexChanged);
            // 
            // ObjectBox
            // 
            this.ObjectBox.FormattingEnabled = true;
            this.ObjectBox.Location = new System.Drawing.Point(106, 51);
            this.ObjectBox.Name = "ObjectBox";
            this.ObjectBox.Size = new System.Drawing.Size(121, 21);
            this.ObjectBox.TabIndex = 1;
            this.ObjectBox.SelectedIndexChanged += new System.EventHandler(this.ObjectBox_SelectedIndexChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(139, 121);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create New Object";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SpeedBox
            // 
            this.SpeedBox.Location = new System.Drawing.Point(12, 219);
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.Size = new System.Drawing.Size(100, 20);
            this.SpeedBox.TabIndex = 3;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(139, 286);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // HighBox
            // 
            this.HighBox.Location = new System.Drawing.Point(118, 219);
            this.HighBox.Name = "HighBox";
            this.HighBox.Size = new System.Drawing.Size(100, 20);
            this.HighBox.TabIndex = 5;
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(224, 219);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(100, 20);
            this.DepthBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 321);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.HighBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SpeedBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.ObjectBox);
            this.Controls.Add(this.ObjectTypeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ObjectTypeBox;
        private System.Windows.Forms.ComboBox ObjectBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox SpeedBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox HighBox;
        private System.Windows.Forms.TextBox DepthBox;
    }
}

