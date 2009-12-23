using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TutorialEntities;

namespace EnityTutorialApp
{
    /// <summary>
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

        private void ShowVehiculos_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Vehiculos;
            }
        }

        private void ShowMotos_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Vehiculos.OfType<Moto>();
            }
        }

        private void ShowAutomoviles_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Vehiculos.OfType<Camioneta>();
            }
        }

        private void ShowScooters_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Vehiculos.OfType<Automovil>();
            }
        }
    }
}
