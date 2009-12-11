// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FormMain.cs" company="Say No More">
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

    /// <summary>
    /// Main form of application.
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        private void SimpleEntities_Click(object sender, EventArgs e)
        {
            (new FormSimpleEntities()).ShowDialog();
        }

        private void HierarchyPerType_Click(object sender, EventArgs e)
        {
            (new FormHierachyPerType()).ShowDialog();
        }

        private void HierarchyPerConcrete_Click(object sender, EventArgs e)
        {
            (new FormHierarchyPerConcrete()).ShowDialog();
        }
    }
}
