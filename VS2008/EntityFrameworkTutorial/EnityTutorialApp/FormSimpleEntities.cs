// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormSimpleEntities.cs" company="Say No More">
//   2009
// </copyright>
// <summary>
//   Formulario para mostrar el uso basico de entidades.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EnityTutorialApp
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using TutorialEntities;

    /// <summary>
    /// Formulario para mostrar el uso basico de entidades.
    /// </summary>
    public partial class FormSimpleEntities : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormSimpleEntities"/> class.
        /// </summary>
        public FormSimpleEntities()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra todas las entidades.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowEntities_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Pallets.Select(p => new { p.Id, p.Lote, Codigo = p.Articulo.Id, Bloqueado = p.Bloqueado.Equals("Y"), p.FechaEntrada, Articulo = p.Articulo.Descripcion });
            }
        }
    }
}
