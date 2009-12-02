namespace Niko78.CSharp.RemotingHost
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
            this.btnInicializeHost = new System.Windows.Forms.Button();
            this.texSetNombre = new System.Windows.Forms.TextBox();
            this.btnSetNombre = new System.Windows.Forms.Button();
            this.btnGetNombre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicializeHost
            // 
            this.btnInicializeHost.Location = new System.Drawing.Point(23, 12);
            this.btnInicializeHost.Name = "btnInicializeHost";
            this.btnInicializeHost.Size = new System.Drawing.Size(90, 32);
            this.btnInicializeHost.TabIndex = 0;
            this.btnInicializeHost.Text = "Inicializar";
            this.btnInicializeHost.UseVisualStyleBackColor = true;
            this.btnInicializeHost.Click += new System.EventHandler(this.InicializeHost_Click);
            // 
            // texSetNombre
            // 
            this.texSetNombre.Location = new System.Drawing.Point(23, 130);
            this.texSetNombre.Name = "texSetNombre";
            this.texSetNombre.Size = new System.Drawing.Size(100, 20);
            this.texSetNombre.TabIndex = 6;
            // 
            // btnSetNombre
            // 
            this.btnSetNombre.Location = new System.Drawing.Point(139, 124);
            this.btnSetNombre.Name = "btnSetNombre";
            this.btnSetNombre.Size = new System.Drawing.Size(78, 30);
            this.btnSetNombre.TabIndex = 5;
            this.btnSetNombre.Text = "Set Nombre";
            this.btnSetNombre.UseVisualStyleBackColor = true;
            this.btnSetNombre.Click += new System.EventHandler(this.SetNombre_Click);
            // 
            // btnGetNombre
            // 
            this.btnGetNombre.Location = new System.Drawing.Point(23, 75);
            this.btnGetNombre.Name = "btnGetNombre";
            this.btnGetNombre.Size = new System.Drawing.Size(109, 34);
            this.btnGetNombre.TabIndex = 4;
            this.btnGetNombre.Text = "Obtener Nombre";
            this.btnGetNombre.UseVisualStyleBackColor = true;
            this.btnGetNombre.Click += new System.EventHandler(this.GetNombre_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 167);
            this.Controls.Add(this.texSetNombre);
            this.Controls.Add(this.btnSetNombre);
            this.Controls.Add(this.btnGetNombre);
            this.Controls.Add(this.btnInicializeHost);
            this.Name = "FormMain";
            this.Text = "Niko78 CSharp - Remoting Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicializeHost;
        private System.Windows.Forms.TextBox texSetNombre;
        private System.Windows.Forms.Button btnSetNombre;
        private System.Windows.Forms.Button btnGetNombre;
    }
}