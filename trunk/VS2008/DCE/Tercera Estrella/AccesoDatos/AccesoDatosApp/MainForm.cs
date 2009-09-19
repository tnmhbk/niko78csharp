using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DCE.TerceraEstrella.SQLAppLayer;

namespace AccesoDatosApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Test de conexión a la base de datos.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void TestConexion_Click(object sender, EventArgs e)
        {
            try
            {
                DataServer dataServer = new DataServer();
                dataServer.TestConeccionDB();
                MessageBox.Show("Conexión exitosa !!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("No se pudo conectar a la DB.\nDetalles:\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
