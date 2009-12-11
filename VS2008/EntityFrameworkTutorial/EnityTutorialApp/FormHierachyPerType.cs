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
    public partial class FormHierachyPerType : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormHierachyPerType"/> class.
        /// </summary>
        public FormHierachyPerType()
        {
            InitializeComponent();
        }

        private void ShowPersonas_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas;
            }
        }

        private void ShowDesarrolladores_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas.OfType<Desarrollador>();
            }
        }

        private void ShowGerentes_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas.OfType<Gerente>();
            }
        }

        private void ShowLiderTecnicos_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas.OfType<LiderTecnico>();
            }
        }
    }
}
