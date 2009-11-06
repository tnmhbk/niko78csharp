namespace PrinterTest
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private readonly System.ComponentModel.IContainer components = null;

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
            this.cbxPrinters = new System.Windows.Forms.ComboBox();
            this.pdcDocumento = new System.Drawing.Printing.PrintDocument();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colPropiedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvalor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlDock = new System.Windows.Forms.Panel();
            this.ppcDocumento = new System.Windows.Forms.PrintPreviewControl();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxPrinters
            // 
            this.cbxPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrinters.FormattingEnabled = true;
            this.cbxPrinters.Location = new System.Drawing.Point(24, 12);
            this.cbxPrinters.Name = "cbxPrinters";
            this.cbxPrinters.Size = new System.Drawing.Size(279, 21);
            this.cbxPrinters.TabIndex = 0;
            this.cbxPrinters.SelectedIndexChanged += new System.EventHandler(this.cbxPrinters_SelectedIndexChanged);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPropiedad,
            this.colvalor});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 44);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(220, 229);
            this.dgvMain.TabIndex = 1;
            // 
            // colPropiedad
            // 
            this.colPropiedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPropiedad.DataPropertyName = "Propiedad";
            this.colPropiedad.HeaderText = "Propiedad";
            this.colPropiedad.Name = "colPropiedad";
            this.colPropiedad.ReadOnly = true;
            this.colPropiedad.Width = 78;
            // 
            // colvalor
            // 
            this.colvalor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colvalor.DataPropertyName = "Valor";
            this.colvalor.HeaderText = "Valor";
            this.colvalor.Name = "colvalor";
            this.colvalor.ReadOnly = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnPrint);
            this.pnlTop.Controls.Add(this.cbxPrinters);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(447, 50);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(220, 44);
            this.pnlLeftTop.TabIndex = 3;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.dgvMain);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 50);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(220, 273);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlDock
            // 
            this.pnlDock.Controls.Add(this.ppcDocumento);
            this.pnlDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDock.Location = new System.Drawing.Point(220, 50);
            this.pnlDock.Name = "pnlDock";
            this.pnlDock.Size = new System.Drawing.Size(227, 273);
            this.pnlDock.TabIndex = 5;
            // 
            // ppcDocumento
            // 
            this.ppcDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppcDocumento.Document = this.pdcDocumento;
            this.ppcDocumento.Location = new System.Drawing.Point(0, 0);
            this.ppcDocumento.Name = "ppcDocumento";
            this.ppcDocumento.Size = new System.Drawing.Size(227, 273);
            this.ppcDocumento.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(328, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(447, 323);
            this.Controls.Add(this.pnlDock);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "FrmMain";
            this.Text = "niko78csharp - Printer Test";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlDock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPrinters;
        private System.Drawing.Printing.PrintDocument pdcDocumento;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPropiedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvalor;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlDock;
        private System.Windows.Forms.PrintPreviewControl ppcDocumento;
        private System.Windows.Forms.Button btnPrint;
    }
}

