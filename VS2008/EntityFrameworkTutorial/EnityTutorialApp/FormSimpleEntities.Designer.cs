namespace EnityTutorialApp
{
    partial class FormSimpleEntities
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
            this.btnShowEntities = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowEntities
            // 
            this.btnShowEntities.Location = new System.Drawing.Point(23, 21);
            this.btnShowEntities.Name = "btnShowEntities";
            this.btnShowEntities.Size = new System.Drawing.Size(140, 40);
            this.btnShowEntities.TabIndex = 0;
            this.btnShowEntities.Text = "Get All Entities";
            this.btnShowEntities.UseVisualStyleBackColor = true;
            this.btnShowEntities.Click += new System.EventHandler(this.ShowEntities_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(23, 84);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(607, 359);
            this.dgvMain.TabIndex = 1;
            // 
            // FormSimpleEntities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 468);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnShowEntities);
            this.Name = "FormSimpleEntities";
            this.Text = "FormSimpleEntities";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowEntities;
        private System.Windows.Forms.DataGridView dgvMain;
    }
}