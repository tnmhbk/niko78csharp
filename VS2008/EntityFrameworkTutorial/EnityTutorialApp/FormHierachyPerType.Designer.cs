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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnInsertLiderTecnico = new System.Windows.Forms.Button();
            this.btnUpdateGerente = new System.Windows.Forms.Button();
            this.btnUpdateDesarrollador = new System.Windows.Forms.Button();
            this.btnShowPasantes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowPersonas
            // 
            this.btnShowPersonas.Location = new System.Drawing.Point(3, 3);
            this.btnShowPersonas.Name = "btnShowPersonas";
            this.btnShowPersonas.Size = new System.Drawing.Size(106, 26);
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
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 79);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.Size = new System.Drawing.Size(688, 365);
            this.dgvMain.TabIndex = 2;
            // 
            // btnShowDesarrolladores
            // 
            this.btnShowDesarrolladores.Location = new System.Drawing.Point(115, 2);
            this.btnShowDesarrolladores.Name = "btnShowDesarrolladores";
            this.btnShowDesarrolladores.Size = new System.Drawing.Size(132, 27);
            this.btnShowDesarrolladores.TabIndex = 3;
            this.btnShowDesarrolladores.Text = "Show Desarrolladores";
            this.btnShowDesarrolladores.UseVisualStyleBackColor = true;
            this.btnShowDesarrolladores.Click += new System.EventHandler(this.ShowDesarrolladores_Click);
            // 
            // btnShowGerentes
            // 
            this.btnShowGerentes.Location = new System.Drawing.Point(253, 3);
            this.btnShowGerentes.Name = "btnShowGerentes";
            this.btnShowGerentes.Size = new System.Drawing.Size(106, 26);
            this.btnShowGerentes.TabIndex = 4;
            this.btnShowGerentes.Text = "Show Gerentes";
            this.btnShowGerentes.UseVisualStyleBackColor = true;
            this.btnShowGerentes.Click += new System.EventHandler(this.ShowGerentes_Click);
            // 
            // btnShowLiderTecnicos
            // 
            this.btnShowLiderTecnicos.Location = new System.Drawing.Point(365, 4);
            this.btnShowLiderTecnicos.Name = "btnShowLiderTecnicos";
            this.btnShowLiderTecnicos.Size = new System.Drawing.Size(139, 25);
            this.btnShowLiderTecnicos.TabIndex = 5;
            this.btnShowLiderTecnicos.Text = "Show Lideres Tecnicos";
            this.btnShowLiderTecnicos.UseVisualStyleBackColor = true;
            this.btnShowLiderTecnicos.Click += new System.EventHandler(this.ShowLiderTecnicos_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnShowPasantes);
            this.pnlTop.Controls.Add(this.btnInsertLiderTecnico);
            this.pnlTop.Controls.Add(this.btnUpdateGerente);
            this.pnlTop.Controls.Add(this.btnUpdateDesarrollador);
            this.pnlTop.Controls.Add(this.btnShowDesarrolladores);
            this.pnlTop.Controls.Add(this.btnShowLiderTecnicos);
            this.pnlTop.Controls.Add(this.btnShowPersonas);
            this.pnlTop.Controls.Add(this.btnShowGerentes);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(688, 79);
            this.pnlTop.TabIndex = 6;
            // 
            // btnInsertLiderTecnico
            // 
            this.btnInsertLiderTecnico.Location = new System.Drawing.Point(365, 35);
            this.btnInsertLiderTecnico.Name = "btnInsertLiderTecnico";
            this.btnInsertLiderTecnico.Size = new System.Drawing.Size(139, 27);
            this.btnInsertLiderTecnico.TabIndex = 8;
            this.btnInsertLiderTecnico.Text = "Insert Lider Tecnico";
            this.btnInsertLiderTecnico.UseVisualStyleBackColor = true;
            this.btnInsertLiderTecnico.Click += new System.EventHandler(this.InsertLiderTecnico_Click);
            // 
            // btnUpdateGerente
            // 
            this.btnUpdateGerente.Location = new System.Drawing.Point(253, 35);
            this.btnUpdateGerente.Name = "btnUpdateGerente";
            this.btnUpdateGerente.Size = new System.Drawing.Size(106, 27);
            this.btnUpdateGerente.TabIndex = 7;
            this.btnUpdateGerente.Text = "Update Gerente";
            this.btnUpdateGerente.UseVisualStyleBackColor = true;
            this.btnUpdateGerente.Click += new System.EventHandler(this.UpdateGerente_Click);
            // 
            // btnUpdateDesarrollador
            // 
            this.btnUpdateDesarrollador.Location = new System.Drawing.Point(115, 35);
            this.btnUpdateDesarrollador.Name = "btnUpdateDesarrollador";
            this.btnUpdateDesarrollador.Size = new System.Drawing.Size(132, 27);
            this.btnUpdateDesarrollador.TabIndex = 6;
            this.btnUpdateDesarrollador.Text = "Update Desarrollador";
            this.btnUpdateDesarrollador.UseVisualStyleBackColor = true;
            this.btnUpdateDesarrollador.Click += new System.EventHandler(this.UpdateDesarrollador_Click);
            // 
            // btnShowPasantes
            // 
            this.btnShowPasantes.Location = new System.Drawing.Point(510, 3);
            this.btnShowPasantes.Name = "btnShowPasantes";
            this.btnShowPasantes.Size = new System.Drawing.Size(139, 25);
            this.btnShowPasantes.TabIndex = 9;
            this.btnShowPasantes.Text = "Show Pasantes";
            this.btnShowPasantes.UseVisualStyleBackColor = true;
            this.btnShowPasantes.Click += new System.EventHandler(this.ShowPasantes_Click);
            // 
            // FormHierachyPerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 444);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "FormHierachyPerType";
            this.Text = "Entity Framewrok - HierachyPerType";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowPersonas;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnShowDesarrolladores;
        private System.Windows.Forms.Button btnShowGerentes;
        private System.Windows.Forms.Button btnShowLiderTecnicos;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnUpdateDesarrollador;
        private System.Windows.Forms.Button btnUpdateGerente;
        private System.Windows.Forms.Button btnInsertLiderTecnico;
        private System.Windows.Forms.Button btnShowPasantes;
    }
}