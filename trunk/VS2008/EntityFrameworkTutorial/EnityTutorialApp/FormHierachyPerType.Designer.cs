namespace EnityTutorialApp
{
    partial class FormHierachyPerType
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
            this.btnShowPersonas = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.btnShowDesarrolladores = new System.Windows.Forms.Button();
            this.btnShowGerentes = new System.Windows.Forms.Button();
            this.btnShowLiderTecnicos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowPersonas
            // 
            this.btnShowPersonas.Location = new System.Drawing.Point(12, 12);
            this.btnShowPersonas.Name = "btnShowPersonas";
            this.btnShowPersonas.Size = new System.Drawing.Size(106, 37);
            this.btnShowPersonas.TabIndex = 0;
            this.btnShowPersonas.Text = "Show Personas";
            this.btnShowPersonas.UseVisualStyleBackColor = true;
            this.btnShowPersonas.Click += new System.EventHandler(this.ShowPersonas_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 68);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(607, 359);
            this.dgvMain.TabIndex = 2;
            // 
            // btnShowDesarrolladores
            // 
            this.btnShowDesarrolladores.Location = new System.Drawing.Point(136, 12);
            this.btnShowDesarrolladores.Name = "btnShowDesarrolladores";
            this.btnShowDesarrolladores.Size = new System.Drawing.Size(132, 37);
            this.btnShowDesarrolladores.TabIndex = 3;
            this.btnShowDesarrolladores.Text = "Show Desarrolladores";
            this.btnShowDesarrolladores.UseVisualStyleBackColor = true;
            this.btnShowDesarrolladores.Click += new System.EventHandler(this.ShowDesarrolladores_Click);
            // 
            // btnShowGerentes
            // 
            this.btnShowGerentes.Location = new System.Drawing.Point(287, 12);
            this.btnShowGerentes.Name = "btnShowGerentes";
            this.btnShowGerentes.Size = new System.Drawing.Size(106, 37);
            this.btnShowGerentes.TabIndex = 4;
            this.btnShowGerentes.Text = "Show Gerentes";
            this.btnShowGerentes.UseVisualStyleBackColor = true;
            this.btnShowGerentes.Click += new System.EventHandler(this.ShowGerentes_Click);
            // 
            // btnShowLiderTecnicos
            // 
            this.btnShowLiderTecnicos.Location = new System.Drawing.Point(409, 12);
            this.btnShowLiderTecnicos.Name = "btnShowLiderTecnicos";
            this.btnShowLiderTecnicos.Size = new System.Drawing.Size(139, 37);
            this.btnShowLiderTecnicos.TabIndex = 5;
            this.btnShowLiderTecnicos.Text = "Show Lider Tecnicos";
            this.btnShowLiderTecnicos.UseVisualStyleBackColor = true;
            this.btnShowLiderTecnicos.Click += new System.EventHandler(this.ShowLiderTecnicos_Click);
            // 
            // FormHierachyPerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 444);
            this.Controls.Add(this.btnShowLiderTecnicos);
            this.Controls.Add(this.btnShowGerentes);
            this.Controls.Add(this.btnShowDesarrolladores);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnShowPersonas);
            this.Name = "FormHierachyPerType";
            this.Text = "Entity Framewrok - HierachyPerType";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPersonas;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnShowDesarrolladores;
        private System.Windows.Forms.Button btnShowGerentes;
        private System.Windows.Forms.Button btnShowLiderTecnicos;
    }
}