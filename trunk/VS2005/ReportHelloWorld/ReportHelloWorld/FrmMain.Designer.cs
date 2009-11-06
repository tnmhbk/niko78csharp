namespace ReportHelloWorld
{
    partial class FrmMain
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
            this.rvwMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMargenes = new System.Windows.Forms.Label();
            this.texTipoPapel = new System.Windows.Forms.TextBox();
            this.lblTipoPapel = new System.Windows.Forms.Label();
            this.texMargenes = new System.Windows.Forms.TextBox();
            this.texDimensionesReporte = new System.Windows.Forms.TextBox();
            this.lblDimensionesReporte = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // rvwMain
            // 
            this.rvwMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvwMain.LocalReport.ReportEmbeddedResource = "ReportHelloWorld.Reportes.Reporte.rdlc";
            this.rvwMain.Location = new System.Drawing.Point(0, 61);
            this.rvwMain.Name = "rvwMain";
            this.rvwMain.Size = new System.Drawing.Size(679, 341);
            this.rvwMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblDimensionesReporte);
            this.pnlTop.Controls.Add(this.texDimensionesReporte);
            this.pnlTop.Controls.Add(this.lblMargenes);
            this.pnlTop.Controls.Add(this.texTipoPapel);
            this.pnlTop.Controls.Add(this.lblTipoPapel);
            this.pnlTop.Controls.Add(this.texMargenes);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(679, 61);
            this.pnlTop.TabIndex = 1;
            // 
            // lblMargenes
            // 
            this.lblMargenes.AutoSize = true;
            this.lblMargenes.Location = new System.Drawing.Point(12, 38);
            this.lblMargenes.Name = "lblMargenes";
            this.lblMargenes.Size = new System.Drawing.Size(54, 13);
            this.lblMargenes.TabIndex = 3;
            this.lblMargenes.Text = "Margenes";
            // 
            // texTipoPapel
            // 
            this.texTipoPapel.Location = new System.Drawing.Point(84, 9);
            this.texTipoPapel.Name = "texTipoPapel";
            this.texTipoPapel.Size = new System.Drawing.Size(100, 20);
            this.texTipoPapel.TabIndex = 2;
            // 
            // lblTipoPapel
            // 
            this.lblTipoPapel.AutoSize = true;
            this.lblTipoPapel.Location = new System.Drawing.Point(12, 9);
            this.lblTipoPapel.Name = "lblTipoPapel";
            this.lblTipoPapel.Size = new System.Drawing.Size(58, 13);
            this.lblTipoPapel.TabIndex = 1;
            this.lblTipoPapel.Text = "Tipo Papel";
            // 
            // texMargenes
            // 
            this.texMargenes.Location = new System.Drawing.Point(84, 35);
            this.texMargenes.Name = "texMargenes";
            this.texMargenes.Size = new System.Drawing.Size(311, 20);
            this.texMargenes.TabIndex = 0;
            // 
            // texDimensionesReporte
            // 
            this.texDimensionesReporte.Location = new System.Drawing.Point(423, 9);
            this.texDimensionesReporte.Name = "texDimensionesReporte";
            this.texDimensionesReporte.Size = new System.Drawing.Size(219, 20);
            this.texDimensionesReporte.TabIndex = 4;
            // 
            // lblDimensionesReporte
            // 
            this.lblDimensionesReporte.AutoSize = true;
            this.lblDimensionesReporte.Location = new System.Drawing.Point(309, 12);
            this.lblDimensionesReporte.Name = "lblDimensionesReporte";
            this.lblDimensionesReporte.Size = new System.Drawing.Size(108, 13);
            this.lblDimensionesReporte.TabIndex = 5;
            this.lblDimensionesReporte.Text = "Dimensiones Reporte";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 402);
            this.Controls.Add(this.rvwMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox texMargenes;
        private System.Windows.Forms.Label lblTipoPapel;
        private System.Windows.Forms.Label lblMargenes;
        private System.Windows.Forms.TextBox texTipoPapel;
        private System.Windows.Forms.TextBox texDimensionesReporte;
        private System.Windows.Forms.Label lblDimensionesReporte;
    }
}

