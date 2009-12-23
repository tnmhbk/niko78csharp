namespace EnityTutorialApp
{
    partial class FormMain
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
            this.btnSimpleEntities = new System.Windows.Forms.Button();
            this.btnHierarchyPerType = new System.Windows.Forms.Button();
            this.btnHierarchyPerConcrete = new System.Windows.Forms.Button();
            this.cbxOracleMonitor = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSimpleEntities
            // 
            this.btnSimpleEntities.Location = new System.Drawing.Point(52, 82);
            this.btnSimpleEntities.Name = "btnSimpleEntities";
            this.btnSimpleEntities.Size = new System.Drawing.Size(131, 44);
            this.btnSimpleEntities.TabIndex = 0;
            this.btnSimpleEntities.Text = "Simple Entities";
            this.btnSimpleEntities.UseVisualStyleBackColor = true;
            this.btnSimpleEntities.Click += new System.EventHandler(this.SimpleEntities_Click);
            // 
            // btnHierarchyPerType
            // 
            this.btnHierarchyPerType.Location = new System.Drawing.Point(52, 155);
            this.btnHierarchyPerType.Name = "btnHierarchyPerType";
            this.btnHierarchyPerType.Size = new System.Drawing.Size(131, 44);
            this.btnHierarchyPerType.TabIndex = 1;
            this.btnHierarchyPerType.Text = "Hierarchy per Type";
            this.btnHierarchyPerType.UseVisualStyleBackColor = true;
            this.btnHierarchyPerType.Click += new System.EventHandler(this.HierarchyPerType_Click);
            // 
            // btnHierarchyPerConcrete
            // 
            this.btnHierarchyPerConcrete.Location = new System.Drawing.Point(52, 231);
            this.btnHierarchyPerConcrete.Name = "btnHierarchyPerConcrete";
            this.btnHierarchyPerConcrete.Size = new System.Drawing.Size(131, 44);
            this.btnHierarchyPerConcrete.TabIndex = 2;
            this.btnHierarchyPerConcrete.Text = "Hierarchy per Concrete";
            this.btnHierarchyPerConcrete.UseVisualStyleBackColor = true;
            this.btnHierarchyPerConcrete.Click += new System.EventHandler(this.HierarchyPerConcrete_Click);
            // 
            // cbxOracleMonitor
            // 
            this.cbxOracleMonitor.AutoSize = true;
            this.cbxOracleMonitor.Location = new System.Drawing.Point(21, 26);
            this.cbxOracleMonitor.Name = "cbxOracleMonitor";
            this.cbxOracleMonitor.Size = new System.Drawing.Size(95, 17);
            this.cbxOracleMonitor.TabIndex = 3;
            this.cbxOracleMonitor.Text = "Oracle Monitor";
            this.cbxOracleMonitor.UseVisualStyleBackColor = true;
            this.cbxOracleMonitor.CheckedChanged += new System.EventHandler(this.OracleMonitor_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 311);
            this.Controls.Add(this.cbxOracleMonitor);
            this.Controls.Add(this.btnHierarchyPerConcrete);
            this.Controls.Add(this.btnHierarchyPerType);
            this.Controls.Add(this.btnSimpleEntities);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleEntities;
        private System.Windows.Forms.Button btnHierarchyPerType;
        private System.Windows.Forms.Button btnHierarchyPerConcrete;
        private System.Windows.Forms.CheckBox cbxOracleMonitor;
    }
}

