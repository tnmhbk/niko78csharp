namespace Niko78.CSharp.RemotingClient
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
            this.btnGetNombre = new System.Windows.Forms.Button();
            this.btnSetNombre = new System.Windows.Forms.Button();
            this.texSetNombre = new System.Windows.Forms.TextBox();
            this.btnObtenerObjetoContexto = new System.Windows.Forms.Button();
            this.btnSetObjetoContextoLocal = new System.Windows.Forms.Button();
            this.btnSetObjetoContextoRemoto = new System.Windows.Forms.Button();
            this.gbxMetodosSimples = new System.Windows.Forms.GroupBox();
            this.gbxObjetosDeContexto = new System.Windows.Forms.GroupBox();
            this.gbxMetodosSimples.SuspendLayout();
            this.gbxObjetosDeContexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetNombre
            // 
            this.btnGetNombre.Location = new System.Drawing.Point(15, 19);
            this.btnGetNombre.Name = "btnGetNombre";
            this.btnGetNombre.Size = new System.Drawing.Size(109, 34);
            this.btnGetNombre.TabIndex = 0;
            this.btnGetNombre.Text = "Obtener Nombre";
            this.btnGetNombre.UseVisualStyleBackColor = true;
            this.btnGetNombre.Click += new System.EventHandler(this.GetNombre_Click);
            // 
            // btnSetNombre
            // 
            this.btnSetNombre.Location = new System.Drawing.Point(223, 21);
            this.btnSetNombre.Name = "btnSetNombre";
            this.btnSetNombre.Size = new System.Drawing.Size(78, 30);
            this.btnSetNombre.TabIndex = 2;
            this.btnSetNombre.Text = "Set Nombre";
            this.btnSetNombre.UseVisualStyleBackColor = true;
            this.btnSetNombre.Click += new System.EventHandler(this.SetNombre_Click);
            // 
            // texSetNombre
            // 
            this.texSetNombre.Location = new System.Drawing.Point(313, 27);
            this.texSetNombre.Name = "texSetNombre";
            this.texSetNombre.Size = new System.Drawing.Size(100, 20);
            this.texSetNombre.TabIndex = 3;
            // 
            // btnObtenerObjetoContexto
            // 
            this.btnObtenerObjetoContexto.Location = new System.Drawing.Point(6, 19);
            this.btnObtenerObjetoContexto.Name = "btnObtenerObjetoContexto";
            this.btnObtenerObjetoContexto.Size = new System.Drawing.Size(142, 34);
            this.btnObtenerObjetoContexto.TabIndex = 4;
            this.btnObtenerObjetoContexto.Text = "Obtener Objeto Contexto";
            this.btnObtenerObjetoContexto.UseVisualStyleBackColor = true;
            this.btnObtenerObjetoContexto.Click += new System.EventHandler(this.ObtenerObjetoContexto_Click);
            // 
            // btnSetObjetoContextoLocal
            // 
            this.btnSetObjetoContextoLocal.Location = new System.Drawing.Point(154, 19);
            this.btnSetObjetoContextoLocal.Name = "btnSetObjetoContextoLocal";
            this.btnSetObjetoContextoLocal.Size = new System.Drawing.Size(111, 34);
            this.btnSetObjetoContextoLocal.TabIndex = 5;
            this.btnSetObjetoContextoLocal.Text = "Set Objeto Contexto Local";
            this.btnSetObjetoContextoLocal.UseVisualStyleBackColor = true;
            this.btnSetObjetoContextoLocal.Click += new System.EventHandler(this.SetObjetoContexto_Click);
            // 
            // btnSetObjetoContextoRemoto
            // 
            this.btnSetObjetoContextoRemoto.Location = new System.Drawing.Point(271, 19);
            this.btnSetObjetoContextoRemoto.Name = "btnSetObjetoContextoRemoto";
            this.btnSetObjetoContextoRemoto.Size = new System.Drawing.Size(142, 34);
            this.btnSetObjetoContextoRemoto.TabIndex = 7;
            this.btnSetObjetoContextoRemoto.Text = "Set Objeto Contexto Remoto";
            this.btnSetObjetoContextoRemoto.UseVisualStyleBackColor = true;
            this.btnSetObjetoContextoRemoto.Click += new System.EventHandler(this.SetObjetoContextoRemoto_Click);
            // 
            // gbxMetodosSimples
            // 
            this.gbxMetodosSimples.Controls.Add(this.btnGetNombre);
            this.gbxMetodosSimples.Controls.Add(this.btnSetNombre);
            this.gbxMetodosSimples.Controls.Add(this.texSetNombre);
            this.gbxMetodosSimples.Location = new System.Drawing.Point(12, 12);
            this.gbxMetodosSimples.Name = "gbxMetodosSimples";
            this.gbxMetodosSimples.Size = new System.Drawing.Size(419, 66);
            this.gbxMetodosSimples.TabIndex = 8;
            this.gbxMetodosSimples.TabStop = false;
            this.gbxMetodosSimples.Text = "Ejecucion de Metodos Simples";
            // 
            // gbxObjetosDeContexto
            // 
            this.gbxObjetosDeContexto.Controls.Add(this.btnObtenerObjetoContexto);
            this.gbxObjetosDeContexto.Controls.Add(this.btnSetObjetoContextoLocal);
            this.gbxObjetosDeContexto.Controls.Add(this.btnSetObjetoContextoRemoto);
            this.gbxObjetosDeContexto.Location = new System.Drawing.Point(12, 84);
            this.gbxObjetosDeContexto.Name = "gbxObjetosDeContexto";
            this.gbxObjetosDeContexto.Size = new System.Drawing.Size(419, 71);
            this.gbxObjetosDeContexto.TabIndex = 9;
            this.gbxObjetosDeContexto.TabStop = false;
            this.gbxObjetosDeContexto.Text = "Objetos de Contexto";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 172);
            this.Controls.Add(this.gbxObjetosDeContexto);
            this.Controls.Add(this.gbxMetodosSimples);
            this.Name = "FormMain";
            this.Text = "Niko78 CSharp - Remoting Client";
            this.gbxMetodosSimples.ResumeLayout(false);
            this.gbxMetodosSimples.PerformLayout();
            this.gbxObjetosDeContexto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetNombre;
        private System.Windows.Forms.Button btnSetNombre;
        private System.Windows.Forms.TextBox texSetNombre;
        private System.Windows.Forms.Button btnObtenerObjetoContexto;
        private System.Windows.Forms.Button btnSetObjetoContextoLocal;
        private System.Windows.Forms.Button btnSetObjetoContextoRemoto;
        private System.Windows.Forms.GroupBox gbxMetodosSimples;
        private System.Windows.Forms.GroupBox gbxObjetosDeContexto;
    }
}