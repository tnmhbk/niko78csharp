namespace EnityTutorialApp
{
    partial class FormHierarchyPerConcrete
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
            this.btnShowMotos = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnShowVehiculos = new System.Windows.Forms.Button();
            this.btnShowAutomoviles = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowMotos
            // 
            this.btnShowMotos.Location = new System.Drawing.Point(115, 7);
            this.btnShowMotos.Name = "btnShowMotos";
            this.btnShowMotos.Size = new System.Drawing.Size(101, 28);
            this.btnShowMotos.TabIndex = 6;
            this.btnShowMotos.Text = "Show Motos";
            this.btnShowMotos.UseVisualStyleBackColor = true;
            this.btnShowMotos.Click += new System.EventHandler(this.ShowMotos_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 49);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(470, 353);
            this.dgvMain.TabIndex = 5;
            // 
            // btnShowVehiculos
            // 
            this.btnShowVehiculos.Location = new System.Drawing.Point(3, 7);
            this.btnShowVehiculos.Name = "btnShowVehiculos";
            this.btnShowVehiculos.Size = new System.Drawing.Size(106, 28);
            this.btnShowVehiculos.TabIndex = 4;
            this.btnShowVehiculos.Text = "Show Vehiculos";
            this.btnShowVehiculos.UseVisualStyleBackColor = true;
            this.btnShowVehiculos.Click += new System.EventHandler(this.ShowVehiculos_Click);
            // 
            // btnShowAutomoviles
            // 
            this.btnShowAutomoviles.Location = new System.Drawing.Point(222, 7);
            this.btnShowAutomoviles.Name = "btnShowAutomoviles";
            this.btnShowAutomoviles.Size = new System.Drawing.Size(119, 28);
            this.btnShowAutomoviles.TabIndex = 7;
            this.btnShowAutomoviles.Text = "Show Automoviles";
            this.btnShowAutomoviles.UseVisualStyleBackColor = true;
            this.btnShowAutomoviles.Click += new System.EventHandler(this.ShowAutomoviles_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnShowAutomoviles);
            this.pnlTop.Controls.Add(this.btnShowMotos);
            this.pnlTop.Controls.Add(this.btnShowVehiculos);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(470, 49);
            this.pnlTop.TabIndex = 8;
            // 
            // FormHierarchyPerConcrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 402);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormHierarchyPerConcrete";
            this.Text = "Hierarchy Per Concrete Sample";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMotos;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnShowVehiculos;
        private System.Windows.Forms.Button btnShowAutomoviles;
        private System.Windows.Forms.Panel pnlTop;
    }
}