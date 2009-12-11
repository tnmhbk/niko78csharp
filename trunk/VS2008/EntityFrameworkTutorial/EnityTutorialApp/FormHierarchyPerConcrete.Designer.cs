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
            this.btnShowScooters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowMotos
            // 
            this.btnShowMotos.Location = new System.Drawing.Point(137, 12);
            this.btnShowMotos.Name = "btnShowMotos";
            this.btnShowMotos.Size = new System.Drawing.Size(132, 37);
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
            this.dgvMain.Location = new System.Drawing.Point(12, 64);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(607, 359);
            this.dgvMain.TabIndex = 5;
            // 
            // btnShowVehiculos
            // 
            this.btnShowVehiculos.Location = new System.Drawing.Point(12, 12);
            this.btnShowVehiculos.Name = "btnShowVehiculos";
            this.btnShowVehiculos.Size = new System.Drawing.Size(106, 37);
            this.btnShowVehiculos.TabIndex = 4;
            this.btnShowVehiculos.Text = "Show Vehiculos";
            this.btnShowVehiculos.UseVisualStyleBackColor = true;
            this.btnShowVehiculos.Click += new System.EventHandler(this.ShowVehiculos_Click);
            // 
            // btnShowAutomoviles
            // 
            this.btnShowAutomoviles.Location = new System.Drawing.Point(286, 12);
            this.btnShowAutomoviles.Name = "btnShowAutomoviles";
            this.btnShowAutomoviles.Size = new System.Drawing.Size(132, 37);
            this.btnShowAutomoviles.TabIndex = 7;
            this.btnShowAutomoviles.Text = "Show Automoviles";
            this.btnShowAutomoviles.UseVisualStyleBackColor = true;
            this.btnShowAutomoviles.Click += new System.EventHandler(this.ShowAutomoviles_Click);
            // 
            // btnShowScooters
            // 
            this.btnShowScooters.Location = new System.Drawing.Point(433, 12);
            this.btnShowScooters.Name = "btnShowScooters";
            this.btnShowScooters.Size = new System.Drawing.Size(132, 37);
            this.btnShowScooters.TabIndex = 8;
            this.btnShowScooters.Text = "Show Scooters";
            this.btnShowScooters.UseVisualStyleBackColor = true;
            this.btnShowScooters.Click += new System.EventHandler(this.ShowScooters_Click);
            // 
            // FormHierarchyPerConcrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 436);
            this.Controls.Add(this.btnShowScooters);
            this.Controls.Add(this.btnShowAutomoviles);
            this.Controls.Add(this.btnShowMotos);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnShowVehiculos);
            this.Name = "FormHierarchyPerConcrete";
            this.Text = "FormHierarchyPerConcrete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowMotos;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnShowVehiculos;
        private System.Windows.Forms.Button btnShowAutomoviles;
        private System.Windows.Forms.Button btnShowScooters;
    }
}