// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormHierachyPerType.cs" company="ABB Argentina">
//   2009
// </copyright>
// <summary>
//   Formulario Hierachy Per Type
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EnityTutorialApp
{
    using System;
    using System.Linq;
    using System.Transactions;
    using System.Windows.Forms;
    using TutorialEntities;

    /// <summary>
    /// Formulario Hierachy Per Type
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

        /// <summary>
        /// Muestra las personas.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowPersonas_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas;
            }
        }

        /// <summary>
        /// Muestra los desarrolladores.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowDesarrolladores_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas.OfType<Desarrollador>();
            }
        }

        /// <summary>
        /// Actualiza solo un campo de un desarrollador impactando en una sola tabla.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void UpdateDesarrollador_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                Desarrollador desarrollador = entities.Personas.OfType<Desarrollador>().Where(d => d.Id == 4).First();
                desarrollador.Nivel = "Senior";

                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Muestra los gerentes.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowGerentes_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas.OfType<Gerente>();
            }
        }

        /// <summary>
        /// Actualiza todos los campos de un gerente, impactando en dos tablas.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void UpdateGerente_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                Gerente gerente = entities.Personas.OfType<Gerente>().Where(d => d.Id == 1).First();
                gerente.Nombre = "Jorge";
                gerente.Apellido = "Bourdette";
                gerente.Cargo = "Gerente Sistemas Gestion Calidad";

                entities.SaveChanges();
            }
        }

        /// <summary>
        /// Muestra los lideres tecnicos.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowLiderTecnicos_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas.OfType<LiderTecnico>();
            }
        }

        /// <summary>
        /// Ingresa un lider tecnico sin realizar commit.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void InsertLiderTecnico_Click(object sender, EventArgs e)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
                {
                    LiderTecnico liderTecnico = new LiderTecnico
                                                    {
                                                        Id = DateTime.Now.Ticks % 1000000,
                                                        Nombre = "Dummy",
                                                        Apellido = "Boy",
                                                        Nivel = "Junior",
                                                        Projecto = "My ePlant"
                                                    };

                    entities.AddToPersonas(liderTecnico);
                    entities.SaveChanges();
                }

                ts.Dispose();
            }
        }

        /// <summary>
        /// Muestra los pasantes.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ShowPasantes_Click(object sender, EventArgs e)
        {
            using (TutorialObjectContext entities = new TutorialObjectContext(ConnectionManager.ConnectionString))
            {
                dgvMain.DataSource = entities.Personas.OfType<Pasante>();
            }
        }
    }
}
