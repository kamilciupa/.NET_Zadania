namespace Server
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
            this.lStatus = new System.Windows.Forms.Label();
            this.tbFolder = new System.Windows.Forms.TextBox();
            this.lFolder = new System.Windows.Forms.Label();
            this.bFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tPort = new System.Windows.Forms.Label();
            this.bSet = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tIp = new System.Windows.Forms.Label();
            this.lStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(131, 13);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 13);
            this.lStatus.TabIndex = 0;
            // 
            // tbFolder
            // 
            this.tbFolder.Location = new System.Drawing.Point(61, 13);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.Size = new System.Drawing.Size(100, 20);
            this.tbFolder.TabIndex = 1;
            // 
            // lFolder
            // 
            this.lFolder.AutoSize = true;
            this.lFolder.Location = new System.Drawing.Point(13, 19);
            this.lFolder.Name = "lFolder";
            this.lFolder.Size = new System.Drawing.Size(36, 13);
            this.lFolder.TabIndex = 2;
            this.lFolder.Text = "Folder";
            // 
            // bFolder
            // 
            this.bFolder.Location = new System.Drawing.Point(167, 11);
            this.bFolder.Name = "bFolder";
            this.bFolder.Size = new System.Drawing.Size(75, 23);
            this.bFolder.TabIndex = 3;
            this.bFolder.Text = "Browse";
            this.bFolder.UseVisualStyleBackColor = true;
            this.bFolder.Click += new System.EventHandler(this.bFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(61, 75);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 13;
            this.tbPort.Text = "8888";
            // 
            // tPort
            // 
            this.tPort.AutoSize = true;
            this.tPort.Location = new System.Drawing.Point(6, 79);
            this.tPort.Name = "tPort";
            this.tPort.Size = new System.Drawing.Size(26, 13);
            this.tPort.TabIndex = 12;
            this.tPort.Text = "Port";
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(167, 72);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(75, 23);
            this.bSet.TabIndex = 11;
            this.bSet.Text = "Connect";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(61, 49);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 20);
            this.tbIP.TabIndex = 10;
            this.tbIP.Text = "127.0.0.1";
            // 
            // tIp
            // 
            this.tIp.AutoSize = true;
            this.tIp.Location = new System.Drawing.Point(6, 53);
            this.tIp.Name = "tIp";
            this.tIp.Size = new System.Drawing.Size(58, 13);
            this.tIp.TabIndex = 9;
            this.tIp.Text = "Address IP";
            // 
            // lStats
            // 
            this.lStats.AutoSize = true;
            this.lStats.Location = new System.Drawing.Point(101, 102);
            this.lStats.Name = "lStats";
            this.lStats.Size = new System.Drawing.Size(13, 13);
            this.lStats.TabIndex = 15;
            this.lStats.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.lStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tPort);
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tIp);
            this.Controls.Add(this.bFolder);
            this.Controls.Add(this.lFolder);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.lStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.TextBox tbFolder;
        private System.Windows.Forms.Label lFolder;
        private System.Windows.Forms.Button bFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label tPort;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label tIp;
        private System.Windows.Forms.Label lStats;
    }
}

