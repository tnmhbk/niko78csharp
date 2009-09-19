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
            this.TestConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestConexion
            // 
            this.TestConexion.Location = new System.Drawing.Point(385, 37);
            this.TestConexion.Name = "TestConexion";
            this.TestConexion.Size = new System.Drawing.Size(100, 37);
            this.TestConexion.TabIndex = 0;
            this.TestConexion.Text = "Test Conexión";
            this.TestConexion.UseVisualStyleBackColor = true;
            this.TestConexion.Click += new System.EventHandler(this.TestConexion_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 358);
            this.Controls.Add(this.TestConexion);
            this.Name = "MainForm";
            this.Text = "DCE - Tercera Estrella - Acceso a Datos ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestConexion;
    }
}

