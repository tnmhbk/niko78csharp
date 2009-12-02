// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormMain.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Defines the Form1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Niko78.CSharp.RemotingClient
{
    using System;
    using System.Runtime.Remoting;
    using System.Windows.Forms;
    using RemotingObject;

    /// <summary>
    /// Formulario principal de la App.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Objeto remoto.
        /// </summary>
        private MyObjetoRemoto _myObjetoRemoto;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicializa el objeto remoto.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void Inicializar_Click(object sender, EventArgs e)
        {
            try
            {
                RemotingConfiguration.Configure("ConfigClienteRemoting.xml", false);
                _myObjetoRemoto = new MyObjetoRemoto();
                MessageBox.Show("Objeto Inicializado con exito !", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtiene el nombre del objeto remoto.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void GetNombre_Click(object sender, EventArgs e)
        {
            try
            {
                texSetNombre.Text = _myObjetoRemoto.GetNombre();
                MessageBox.Show(texSetNombre.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("El objeto respondio:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Setea el nombre del objeto remoto.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void SetNombre_Click(object sender, EventArgs e)
        {
            try
            {
                _myObjetoRemoto.SetNombre(texSetNombre.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("El objeto respondio:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}