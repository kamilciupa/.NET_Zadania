namespace Client
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
            this.tIp = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.bSet = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tPort = new System.Windows.Forms.Label();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.lFile = new System.Windows.Forms.Label();
            this.bBrowse = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.bSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tIp
            // 
            this.tIp.AutoSize = true;
            this.tIp.Location = new System.Drawing.Point(12, 20);
            this.tIp.Name = "tIp";
            this.tIp.Size = new System.Drawing.Size(58, 13);
            this.tIp.TabIndex = 0;
            this.tIp.Text = "Address IP";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(67, 16);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 1;
            this.tbIP.Text = "127.0.0.1";
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(173, 39);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(75, 23);
            this.bSet.TabIndex = 2;
            this.bSet.Text = "Connect";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(67, 42);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 4;
            this.tbPort.Text = "8888";
            // 
            // tPort
            // 
            this.tPort.AutoSize = true;
            this.tPort.Location = new System.Drawing.Point(12, 46);
            this.tPort.Name = "tPort";
            this.tPort.Size = new System.Drawing.Size(26, 13);
            this.tPort.TabIndex = 3;
            this.tPort.Text = "Port";
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(67, 102);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(171, 20);
            this.tbFile.TabIndex = 6;
            // 
            // lFile
            // 
            this.lFile.AutoSize = true;
            this.lFile.Location = new System.Drawing.Point(15, 105);
            this.lFile.Name = "lFile";
            this.lFile.Size = new System.Drawing.Size(23, 13);
            this.lFile.TabIndex = 5;
            this.lFile.Text = "File";
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(244, 102);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 7;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(67, 69);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 13);
            this.lStatus.TabIndex = 8;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(325, 102);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 9;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 261);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.tbFile);
            this.Controls.Add(this.lFile);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tPort);
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tIp;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label tPort;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Label lFile;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bSend;
    }
}

