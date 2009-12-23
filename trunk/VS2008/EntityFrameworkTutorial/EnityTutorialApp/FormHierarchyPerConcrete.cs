// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormHierarchyPerConcrete.cs" company="ABB Argentina">
//   2009
// </copyright>
// <summary>
//   Defines the FormHierarchyPerConcrete type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EnityTutorialApp
{
    using System;
    using System.Windows.Forms;
    using TutorialEntities;

    /// <summary>
    /// Formulario Hierarchy Per Concrete
    /// </summary>
    public partial class FormHierarchyPerConcrete : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormHierarchyPerConcrete"/> class.
        /// </summary>
        public FormHierarchyPerConcrete()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra los vehiculos.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowVehiculos_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Vehiculos;
            }
        }

        /// <summary>
        /// Muestra las motos.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowMotos_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Vehiculos.OfType<Moto>();
            }
        }

        /// <summary>
        /// Muestra los automoviles.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowAutomoviles_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Vehiculos.OfType<Automovil>();
            }
        }
    }
}
