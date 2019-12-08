namespace Pruefung2.userControl
{
    partial class VentControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbVent = new System.Windows.Forms.PictureBox();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnStage1 = new System.Windows.Forms.Button();
            this.btnStag2 = new System.Windows.Forms.Button();
            this.btnStage3 = new System.Windows.Forms.Button();
            this.pgbSpeed = new System.Windows.Forms.ProgressBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pgbVoltage = new System.Windows.Forms.ProgressBar();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.pgbUseage = new System.Windows.Forms.ProgressBar();
            this.lblUsage = new System.Windows.Forms.Label();
            this.btnStage4 = new System.Windows.Forms.Button();
            this.lblStage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbVent)).BeginInit();
            this.SuspendLayout();
            // 
            // pbVent
            // 
            this.pbVent.Location = new System.Drawing.Point(0, 34);
            this.pbVent.Name = "pbVent";
            this.pbVent.Size = new System.Drawing.Size(114, 115);
            this.pbVent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVent.TabIndex = 0;
            this.pbVent.TabStop = false;
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(124, 3);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(62, 24);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Aus";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnStage1
            // 
            this.btnStage1.Location = new System.Drawing.Point(124, 35);
            this.btnStage1.Name = "btnStage1";
            this.btnStage1.Size = new System.Drawing.Size(62, 24);
            this.btnStage1.TabIndex = 2;
            this.btnStage1.Text = "Stufe 1";
            this.btnStage1.UseVisualStyleBackColor = true;
            this.btnStage1.Click += new System.EventHandler(this.btnStage1_Click);
            // 
            // btnStag2
            // 
            this.btnStag2.Location = new System.Drawing.Point(124, 65);
            this.btnStag2.Name = "btnStag2";
            this.btnStag2.Size = new System.Drawing.Size(62, 24);
            this.btnStag2.TabIndex = 3;
            this.btnStag2.Text = "Stufe 2";
            this.btnStag2.UseVisualStyleBackColor = true;
            this.btnStag2.Click += new System.EventHandler(this.btnStag2_Click);
            // 
            // btnStage3
            // 
            this.btnStage3.Location = new System.Drawing.Point(124, 95);
            this.btnStage3.Name = "btnStage3";
            this.btnStage3.Size = new System.Drawing.Size(62, 24);
            this.btnStage3.TabIndex = 4;
            this.btnStage3.Text = "Stufe 3";
            this.btnStage3.UseVisualStyleBackColor = true;
            this.btnStage3.Click += new System.EventHandler(this.btnStage3_Click);
            // 
            // pgbSpeed
            // 
            this.pgbSpeed.Location = new System.Drawing.Point(3, 173);
            this.pgbSpeed.Maximum = 5000;
            this.pgbSpeed.Name = "pgbSpeed";
            this.pgbSpeed.Size = new System.Drawing.Size(182, 23);
            this.pgbSpeed.TabIndex = 6;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(80, 157);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "Speed";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pgbVoltage
            // 
            this.pgbVoltage.Location = new System.Drawing.Point(3, 215);
            this.pgbVoltage.Maximum = 600;
            this.pgbVoltage.Name = "pgbVoltage";
            this.pgbVoltage.Size = new System.Drawing.Size(182, 23);
            this.pgbVoltage.TabIndex = 8;
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Location = new System.Drawing.Point(75, 199);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(43, 13);
            this.lblVoltage.TabIndex = 9;
            this.lblVoltage.Text = "Voltage";
            this.lblVoltage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pgbUseage
            // 
            this.pgbUseage.Location = new System.Drawing.Point(3, 257);
            this.pgbUseage.Name = "pgbUseage";
            this.pgbUseage.Size = new System.Drawing.Size(181, 23);
            this.pgbUseage.TabIndex = 10;
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.Location = new System.Drawing.Point(74, 241);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(44, 13);
            this.lblUsage.TabIndex = 11;
            this.lblUsage.Text = "Useage";
            this.lblUsage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnStage4
            // 
            this.btnStage4.Location = new System.Drawing.Point(124, 125);
            this.btnStage4.Name = "btnStage4";
            this.btnStage4.Size = new System.Drawing.Size(62, 24);
            this.btnStage4.TabIndex = 12;
            this.btnStage4.Text = "Stufe 4";
            this.btnStage4.UseVisualStyleBackColor = true;
            this.btnStage4.Click += new System.EventHandler(this.btnStage4_Click);
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.Location = new System.Drawing.Point(3, 9);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(32, 13);
            this.lblStage.TabIndex = 13;
            this.lblStage.Text = "Stufe";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStage);
            this.Controls.Add(this.btnStage4);
            this.Controls.Add(this.lblUsage);
            this.Controls.Add(this.pgbUseage);
            this.Controls.Add(this.lblVoltage);
            this.Controls.Add(this.pgbVoltage);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.pgbSpeed);
            this.Controls.Add(this.btnStage3);
            this.Controls.Add(this.btnStag2);
            this.Controls.Add(this.btnStage1);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.pbVent);
            this.Name = "VentControl";
            this.Size = new System.Drawing.Size(189, 285);
            this.Load += new System.EventHandler(this.VentControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVent;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnStage1;
        private System.Windows.Forms.Button btnStag2;
        private System.Windows.Forms.Button btnStage3;
        private System.Windows.Forms.ProgressBar pgbSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ProgressBar pgbVoltage;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.ProgressBar pgbUseage;
        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Button btnStage4;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.Timer timer1;
    }
}
