// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormMain.cs" company="ABB Argentina">
//   2009
// </copyright>
// <summary>
//   Main form of application.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EnityTutorialApp
{
    using System;
    using System.Windows.Forms;
    using Devart.Data.Oracle;

    /// <summary>
    /// Main form of application.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Montor de DB de Devart.
        /// </summary>
        private readonly OracleMonitor _oracleMonitor = new OracleMonitor();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load del Form.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            cbxOracleMonitor.Checked = _oracleMonitor.IsActive;
        }

        /// <summary>
        /// Cambio en el monitoreo de oracle.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OracleMonitor_CheckedChanged(object sender, EventArgs e)
        {
            _oracleMonitor.IsActive = cbxOracleMonitor.Checked;
        }

        /// <summary>
        /// Muestra el formulario de Simple 
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void SimpleEntities_Click(object sender, EventArgs e)
        {
            (new FormSimpleEntities()).ShowDialog();
        }

        /// <summary>
        /// Muestra el formulario de Hierarchy Per Type
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void HierarchyPerType_Click(object sender, EventArgs e)
        {
            (new FormHierachyPerType()).ShowDialog();
        }

        /// <summary>
        /// Muestra el formulario de Hierarchy Per Concrete
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void HierarchyPerConcrete_Click(object sender, EventArgs e)
        {
            (new FormHierarchyPerConcrete()).ShowDialog();
        }
    }
}
