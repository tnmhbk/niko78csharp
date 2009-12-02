namespace Niko78.CSharp.RemotingClient
{
    partial class Form1
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
            this.btnGetNombre = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.btnSetNombre = new System.Windows.Forms.Button();
            this.texSetNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetNombre
            // 
            this.btnGetNombre.Location = new System.Drawing.Point(46, 81);
            this.btnGetNombre.Name = "btnGetNombre";
            this.btnGetNombre.Size = new System.Drawing.Size(109, 34);
            this.btnGetNombre.TabIndex = 0;
            this.btnGetNombre.Text = "Obtener Nombre";
            this.btnGetNombre.UseVisualStyleBackColor = true;
            this.btnGetNombre.Click += new System.EventHandler(this.GetNombre_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(46, 12);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(109, 34);
            this.btnInicializar.TabIndex = 1;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.Inicializar_Click);
            // 
            // btnSetNombre
            // 
            this.btnSetNombre.Location = new System.Drawing.Point(166, 140);
            this.btnSetNombre.Name = "btnSetNombre";
            this.btnSetNombre.Size = new System.Drawing.Size(78, 30);
            this.btnSetNombre.TabIndex = 2;
            this.btnSetNombre.Text = "Set Nombre";
            this.btnSetNombre.UseVisualStyleBackColor = true;
            this.btnSetNombre.Click += new System.EventHandler(this.SetNombre_Click);
            // 
            // texSetNombre
            // 
            this.texSetNombre.Location = new System.Drawing.Point(46, 146);
            this.texSetNombre.Name = "texSetNombre";
            this.texSetNombre.Size = new System.Drawing.Size(100, 20);
            this.texSetNombre.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 248);
            this.Controls.Add(this.texSetNombre);
            this.Controls.Add(this.btnSetNombre);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.btnGetNombre);
            this.Name = "Form1";
            this.Text = "Niko78 CSharp - Remoting Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetNombre;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Button btnSetNombre;
        private System.Windows.Forms.TextBox texSetNombre;
    }
}