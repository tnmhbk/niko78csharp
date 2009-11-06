// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="FrmMain.cs" company="ABB Argentina">
//   Copyright (c) ABB. All rights reserved.
// </copyright>
// <summary>
//   Defines the FrmMain type.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------
namespace ReportHelloWorld
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using System.Xml;

    using Datasets;
    using Microsoft.Reporting.WinForms;

    using ReportParameter = Microsoft.Reporting.WinForms.ReportParameter;

    /// <summary>
    /// Formulario principal de la aplicacion
    /// </summary>
    public partial class FrmMain : Form
    {
        #region "Atributos Privados"

        /// <summary>
        /// Binding para el dataset
        /// </summary>
        private readonly BindingSource tablaReportBindingSource = new BindingSource();

        /// <summary>
        /// Tabla con los datos
        /// </summary>
        private readonly DataSetPrueba dataSet = new DataSetPrueba();

        /// <summary>
        /// Report data Source
        /// </summary>
        private readonly ReportDataSource rds;

        #endregion

        #region "Constructor"

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmMain"/> class.
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();

            tablaReportBindingSource.DataMember = "TablaPrueba";
            tablaReportBindingSource.DataSource = dataSet;

            rds = new ReportDataSource("DataSetPrueba_TablaPrueba", tablaReportBindingSource);

            rvwMain.LocalReport.DataSources.Add(rds);
        }

        #endregion

        #region "Eventos del Form"

        /// <summary>
        /// Load del Form
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The event arguments.
        /// </param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DataRow datarow = dataSet.TablaPrueba.NewRow();
            datarow["Id"] = "2";
            datarow["Nombre"] = "niko78csharp";
            dataSet.TablaPrueba.Rows.Add(datarow);

            datarow = dataSet.TablaPrueba.NewRow();
            datarow["Id"] = "3";
            datarow["Nombre"] = "ABBcsharp";
            dataSet.TablaPrueba.Rows.Add(datarow);

            List<ReportParameter> parametros = new List<ReportParameter>();
            parametros.Add(new ReportParameter("pTitulo", "Titulo del reporte", true));
            rvwMain.LocalReport.SetParameters(parametros);

            texTipoPapel.Text = rvwMain.LocalReport.GetDefaultPageSettings().PaperSize.Kind.ToString();
            texMargenes.Text = rvwMain.LocalReport.GetDefaultPageSettings().Margins.ToString();

            XmlDocument documento = new XmlDocument();
            documento.Load(@"..\..\Reportes\Reporte.rdlc");
            XmlNode nodo = documento.SelectSingleNode("/*/*[local-name() = 'PageWidth']");
            texDimensionesReporte.Text = "Width:" + nodo.InnerText;

            nodo = documento.SelectSingleNode("/*/*[local-name() = 'PageHeight']");
            texDimensionesReporte.Text += " Height:" + nodo.InnerText;

            rvwMain.LocalReport.Refresh();

            rvwMain.RefreshReport();
        }

        #endregion
    }
}