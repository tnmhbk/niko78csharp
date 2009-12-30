namespace AccesoDatosApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.TestConexion = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlRigth = new System.Windows.Forms.Panel();
            this.btnSimpleQuery = new System.Windows.Forms.Button();
            this.bdsMain = new System.Windows.Forms.BindingSource(this.components);
            this.lblSimpleQuery = new System.Windows.Forms.Label();
            this.btnDataReaderQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlRigth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TestConexion
            // 
            this.TestConexion.Location = new System.Drawing.Point(12, 12);
            this.TestConexion.Name = "TestConexion";
            this.TestConexion.Size = new System.Drawing.Size(94, 28);
            this.TestConexion.TabIndex = 0;
            this.TestConexion.Text = "Test Conexión";
            this.TestConexion.UseVisualStyleBackColor = true;
            this.TestConexion.Click += new System.EventHandler(this.TestConexion_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 59);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(404, 299);
            this.dgvMain.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.TestConexion);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(575, 59);
            this.pnlTop.TabIndex = 2;
            // 
            // pnlRigth
            // 
            this.pnlRigth.Controls.Add(this.btnDataReaderQuery);
            this.pnlRigth.Controls.Add(this.lblSimpleQuery);
            this.pnlRigth.Controls.Add(this.btnSimpleQuery);
            this.pnlRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRigth.Location = new System.Drawing.Point(404, 59);
            this.pnlRigth.Name = "pnlRigth";
            this.pnlRigth.Size = new System.Drawing.Size(171, 299);
            this.pnlRigth.TabIndex = 3;
            // 
            // btnSimpleQuery
            // 
            this.btnSimpleQuery.Location = new System.Drawing.Point(9, 22);
            this.btnSimpleQuery.Name = "btnSimpleQuery";
            this.btnSimpleQuery.Size = new System.Drawing.Size(150, 28);
            this.btnSimpleQuery.TabIndex = 1;
            this.btnSimpleQuery.Text = "Get Personas (DataTable)";
            this.btnSimpleQuery.UseVisualStyleBackColor = true;
            this.btnSimpleQuery.Click += new System.EventHandler(this.SimpleQuery_Click);
            // 
            // lblSimpleQuery
            // 
            this.lblSimpleQuery.AutoSize = true;
            this.lblSimpleQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimpleQuery.Location = new System.Drawing.Point(6, 3);
            this.lblSimpleQuery.Name = "lblSimpleQuery";
            this.lblSimpleQuery.Size = new System.Drawing.Size(114, 16);
            this.lblSimpleQuery.TabIndex = 2;
            this.lblSimpleQuery.Text = "Simple Queries";
            // 
            // btnDataReaderQuery
            // 
            this.btnDataReaderQuery.Location = new System.Drawing.Point(9, 67);
            this.btnDataReaderQuery.Name = "btnDataReaderQuery";
            this.btnDataReaderQuery.Size = new System.Drawing.Size(150, 28);
            this.btnDataReaderQuery.TabIndex = 3;
            this.btnDataReaderQuery.Text = "Get Personas (DataReader)";
            this.btnDataReaderQuery.UseVisualStyleBackColor = true;
            this.btnDataReaderQuery.Click += new System.EventHandler(this.DataReaderQuery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 358);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.pnlRigth);
            this.Controls.Add(this.pnlTop);
            this.Name = "MainForm";
            this.Text = "DCE - Tercera Estrella - Acceso a Datos ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlRigth.ResumeLayout(false);
            this.pnlRigth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestConexion;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlRigth;
        private System.Windows.Forms.Button btnSimpleQuery;
        private System.Windows.Forms.BindingSource bdsMain;
        private System.Windows.Forms.Label lblSimpleQuery;
        private System.Windows.Forms.Button btnDataReaderQuery;
    }
}

