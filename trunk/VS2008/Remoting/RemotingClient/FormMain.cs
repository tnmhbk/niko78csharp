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
    using System.Runtime.Remoting.Messaging;
    using System.Windows.Forms;
    using RemotingObject;

    /// <summary>
    /// Formulario principal de la App.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Objeto remoto.
        /// </summary>
        private readonly MyObjetoRemoto _myObjetoRemoto;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            RemotingConfiguration.Configure("ConfigClienteRemoting.xml", false);
            _myObjetoRemoto = new MyObjetoRemoto();
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
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obtiene el objeto de contexto local y remoto
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void ObtenerObjetoContexto_Click(object sender, EventArgs e)
        {
            try
            {
                string messageRemoto = _myObjetoRemoto.GetObjetoContexto();

                object objetoLocal = CallContext.GetData("MyContextData");
                string messageLocal = "nulo";

                if (messageRemoto == null)
                {
                    messageRemoto = "nulo";
                }

                if (objetoLocal != null)
                {
                    messageLocal = ((CallContextData) objetoLocal).Message;
                }

                MessageBox.Show("remoto: " + messageRemoto + "\n local: " + messageLocal, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Setea el objeto de contexto en forma local
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void SetObjetoContexto_Click(object sender, EventArgs e)
        {
            try
            {
                CallContext.SetData("MyContextData", new CallContextData("Hola desde Local"));
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Setea el objeto de contexto en forma remota
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event argument.</param>
        private void SetObjetoContextoRemoto_Click(object sender, EventArgs e)
        {
            try
            {
                _myObjetoRemoto.SetObjetoContextoRemoto();
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProbarExcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                _myObjetoRemoto.GenerarExcepcion();
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("Error:\n{0}", er.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}