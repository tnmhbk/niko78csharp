// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormMain.Designer.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Defines the FormMain type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Niko78.CSharp.RemotingHost
{
    /// <summary>
    /// </summary>
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
            this.btnInicializarPorMarsall = new System.Windows.Forms.Button();
            this.gbxMarshalling = new System.Windows.Forms.GroupBox();
            this.gbxMarshalling.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicializeHost
            // 
            this.btnInicializeHost.Location = new System.Drawing.Point(12, 12);
            this.btnInicializeHost.Name = "btnInicializeHost";
            this.btnInicializeHost.Size = new System.Drawing.Size(133, 32);
            this.btnInicializeHost.TabIndex = 0;
            this.btnInicializeHost.Text = "Inicializar por Config";
            this.btnInicializeHost.UseVisualStyleBackColor = true;
            this.btnInicializeHost.Click += new System.EventHandler(this.InicializeHost_Click);
            // 
            // texSetNombre
            // 
            this.texSetNombre.Location = new System.Drawing.Point(222, 25);
            this.texSetNombre.Name = "texSetNombre";
            this.texSetNombre.Size = new System.Drawing.Size(100, 20);
            this.texSetNombre.TabIndex = 6;
            // 
            // btnSetNombre
            // 
            this.btnSetNombre.Location = new System.Drawing.Point(138, 19);
            this.btnSetNombre.Name = "btnSetNombre";
            this.btnSetNombre.Size = new System.Drawing.Size(78, 30);
            this.btnSetNombre.TabIndex = 5;
            this.btnSetNombre.Text = "Set Nombre";
            this.btnSetNombre.UseVisualStyleBackColor = true;
            this.btnSetNombre.Click += new System.EventHandler(this.SetNombre_Click);
            // 
            // btnGetNombre
            // 
            this.btnGetNombre.Location = new System.Drawing.Point(6, 19);
            this.btnGetNombre.Name = "btnGetNombre";
            this.btnGetNombre.Size = new System.Drawing.Size(109, 34);
            this.btnGetNombre.TabIndex = 4;
            this.btnGetNombre.Text = "Obtener Nombre";
            this.btnGetNombre.UseVisualStyleBackColor = true;
            this.btnGetNombre.Click += new System.EventHandler(this.GetNombre_Click);
            // 
            // btnInicializarPorMarsall
            // 
            this.btnInicializarPorMarsall.Location = new System.Drawing.Point(18, 72);
            this.btnInicializarPorMarsall.Name = "btnInicializarPorMarsall";
            this.btnInicializarPorMarsall.Size = new System.Drawing.Size(133, 32);
            this.btnInicializarPorMarsall.TabIndex = 7;
            this.btnInicializarPorMarsall.Text = "Inicializar por Marshall";
            this.btnInicializarPorMarsall.UseVisualStyleBackColor = true;
            this.btnInicializarPorMarsall.Click += new System.EventHandler(this.InicializarPorMarsall_Click);
            // 
            // gbxMarshalling
            // 
            this.gbxMarshalling.Controls.Add(this.btnSetNombre);
            this.gbxMarshalling.Controls.Add(this.btnGetNombre);
            this.gbxMarshalling.Controls.Add(this.texSetNombre);
            this.gbxMarshalling.Enabled = false;
            this.gbxMarshalling.Location = new System.Drawing.Point(8, 119);
            this.gbxMarshalling.Name = "gbxMarshalling";
            this.gbxMarshalling.Size = new System.Drawing.Size(333, 60);
            this.gbxMarshalling.TabIndex = 8;
            this.gbxMarshalling.TabStop = false;
            this.gbxMarshalling.Text = "Metodos Objeto";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 191);
            this.Controls.Add(this.gbxMarshalling);
            this.Controls.Add(this.btnInicializarPorMarsall);
            this.Controls.Add(this.btnInicializeHost);
            this.Name = "FormMain";
            this.Text = "Niko78 CSharp - Remoting Host";
            this.gbxMarshalling.ResumeLayout(false);
            this.gbxMarshalling.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicializeHost;
        private System.Windows.Forms.TextBox texSetNombre;
        private System.Windows.Forms.Button btnSetNombre;
        private System.Windows.Forms.Button btnGetNombre;
        private System.Windows.Forms.Button btnInicializarPorMarsall;
        private System.Windows.Forms.GroupBox gbxMarshalling;
    }
}