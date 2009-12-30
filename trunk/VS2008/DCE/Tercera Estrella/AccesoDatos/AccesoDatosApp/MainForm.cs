// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Niko78">
//   2009
// </copyright>
// <summary>
//   Main form of application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AccesoDatosApp
{
    using System;
    using System.Windows.Forms;
    using DCE.TerceraEstrella.SQLAppLayer;

    /// <summary>
    /// Main form of application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            dgvMain.DataSource = bdsMain;
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

        /// <summary>
        /// Simple query a la Base de Datos.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void SimpleQuery_Click(object sender, EventArgs e)
        {
            try
            {
                bdsMain.DataSource = DataAccesServices.GetPersonasAsDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error en query.\nDetalles:\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataReaderQuery_Click(object sender, EventArgs e)
        {
            try
            {
                bdsMain.DataSource = DataAccesServices.GetPersonasAsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error en query.\nDetalles:\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
