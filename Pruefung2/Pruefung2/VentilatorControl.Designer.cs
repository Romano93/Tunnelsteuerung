namespace Pruefung2
{
    partial class VentilatorControl
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentilatorControl));
            this.pbTunnel = new System.Windows.Forms.PictureBox();
            this.ventControl4 = new Pruefung2.userControl.VentControl();
            this.ventControl3 = new Pruefung2.userControl.VentControl();
            this.ventControl2 = new Pruefung2.userControl.VentControl();
            this.ventControl1 = new Pruefung2.userControl.VentControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbTunnel)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTunnel
            // 
            this.pbTunnel.InitialImage = null;
            this.pbTunnel.Location = new System.Drawing.Point(350, 12);
            this.pbTunnel.Name = "pbTunnel";
            this.pbTunnel.Size = new System.Drawing.Size(300, 646);
            this.pbTunnel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTunnel.TabIndex = 4;
            this.pbTunnel.TabStop = false;
            // 
            // ventControl4
            // 
            this.ventControl4.Location = new System.Drawing.Point(657, 357);
            this.ventControl4.Name = "ventControl4";
            this.ventControl4.Size = new System.Drawing.Size(189, 285);
            this.ventControl4.TabIndex = 3;
            // 
            // ventControl3
            // 
            this.ventControl3.Location = new System.Drawing.Point(155, 357);
            this.ventControl3.Name = "ventControl3";
            this.ventControl3.Size = new System.Drawing.Size(189, 285);
            this.ventControl3.TabIndex = 2;
            // 
            // ventControl2
            // 
            this.ventControl2.Location = new System.Drawing.Point(657, 28);
            this.ventControl2.Name = "ventControl2";
            this.ventControl2.Size = new System.Drawing.Size(189, 285);
            this.ventControl2.TabIndex = 1;
            // 
            // ventControl1
            // 
            this.ventControl1.Location = new System.Drawing.Point(155, 28);
            this.ventControl1.Name = "ventControl1";
            this.ventControl1.Size = new System.Drawing.Size(189, 285);
            this.ventControl1.TabIndex = 0;
            // 
            // VentilatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 670);
            this.Controls.Add(this.ventControl4);
            this.Controls.Add(this.ventControl3);
            this.Controls.Add(this.ventControl2);
            this.Controls.Add(this.ventControl1);
            this.Controls.Add(this.pbTunnel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentilatorControl";
            this.Text = "Ventilator Steuerung";
            this.Load += new System.EventHandler(this.VentilatorControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTunnel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private userControl.VentControl ventControl1;
        private userControl.VentControl ventControl2;
        private userControl.VentControl ventControl3;
        private userControl.VentControl ventControl4;
        private System.Windows.Forms.PictureBox pbTunnel;
    }
}

