namespace AndroidAudioRaw
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
            this.btnLoadPoints = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.avFFT = new AndroidAudioRaw.ArrayViewer();
            this.avWave = new AndroidAudioRaw.ArrayViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.avFFt2 = new AndroidAudioRaw.ArrayViewer();
            this.avWave2 = new AndroidAudioRaw.ArrayViewer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLoadPoints2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadPoints
            // 
            this.btnLoadPoints.Location = new System.Drawing.Point(6, 12);
            this.btnLoadPoints.Name = "btnLoadPoints";
            this.btnLoadPoints.Size = new System.Drawing.Size(101, 35);
            this.btnLoadPoints.TabIndex = 1;
            this.btnLoadPoints.Text = "Load Points";
            this.btnLoadPoints.UseVisualStyleBackColor = true;
            this.btnLoadPoints.Click += new System.EventHandler(this.LoadPointsClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.avFFT);
            this.panel1.Controls.Add(this.avWave);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 296);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoadPoints);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(786, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 296);
            this.panel2.TabIndex = 2;
            // 
            // avFFT
            // 
            this.avFFT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avFFT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avFFT.Location = new System.Drawing.Point(0, 148);
            this.avFFT.Name = "avFFT";
            this.avFFT.Size = new System.Drawing.Size(786, 148);
            this.avFFT.TabIndex = 2;
            // 
            // avWave
            // 
            this.avWave.BackColor = System.Drawing.Color.White;
            this.avWave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avWave.Dock = System.Windows.Forms.DockStyle.Top;
            this.avWave.Location = new System.Drawing.Point(0, 0);
            this.avWave.Name = "avWave";
            this.avWave.Size = new System.Drawing.Size(786, 148);
            this.avWave.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.avFFt2);
            this.panel3.Controls.Add(this.avWave2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 296);
            this.panel3.TabIndex = 4;
            // 
            // avFFt2
            // 
            this.avFFt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avFFt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avFFt2.Location = new System.Drawing.Point(0, 148);
            this.avFFt2.Name = "avFFt2";
            this.avFFt2.Size = new System.Drawing.Size(786, 148);
            this.avFFt2.TabIndex = 2;
            // 
            // avWave2
            // 
            this.avWave2.BackColor = System.Drawing.Color.White;
            this.avWave2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avWave2.Dock = System.Windows.Forms.DockStyle.Top;
            this.avWave2.Location = new System.Drawing.Point(0, 0);
            this.avWave2.Name = "avWave2";
            this.avWave2.Size = new System.Drawing.Size(786, 148);
            this.avWave2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLoadPoints2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(786, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 296);
            this.panel4.TabIndex = 2;
            // 
            // btnLoadPoints2
            // 
            this.btnLoadPoints2.Location = new System.Drawing.Point(6, 12);
            this.btnLoadPoints2.Name = "btnLoadPoints2";
            this.btnLoadPoints2.Size = new System.Drawing.Size(101, 35);
            this.btnLoadPoints2.TabIndex = 1;
            this.btnLoadPoints2.Text = "Load Points";
            this.btnLoadPoints2.UseVisualStyleBackColor = true;
            this.btnLoadPoints2.Click += new System.EventHandler(this.btnLoadPoints2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 625);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Adroid Array View";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ArrayViewer avWave;
        private System.Windows.Forms.Button btnLoadPoints;
        private ArrayViewer avFFT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private ArrayViewer avFFt2;
        private ArrayViewer avWave2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLoadPoints2;
    }
}

