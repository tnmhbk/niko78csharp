using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PrinterTest
{
    public partial class FrmMain : Form
    {
        #region "Atributos Privados"

        /// <summary>Tabla con las propiedades de impresion</summary>
        readonly DataTable _tabladatos= new DataTable();

        #endregion

        #region "Constructor"

        /// <summary>Constructor</summary>
        public FrmMain()
        {
            InitializeComponent();
            _tabladatos.Columns.Add("Propiedad", typeof (string));
            _tabladatos.Columns.Add("valor", typeof(string));
            dgvMain.DataSource = _tabladatos;
            pdcDocumento.PrintPage+=PdcDocumento_OnPrintPage;
        }

        #endregion

        #region "Metodos Privados"

        /// <summary>Print Event</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void PdcDocumento_OnPrintPage(object sender, PrintPageEventArgs e)
        {
            Pen pen= new Pen(Color.Black,1.0F);
            e.Graphics.DrawLine(pen, (25.0F / 0.254F), (10.0F / 0.254F), (25.0F / 0.254F), (287.0F / 0.254F));
            e.Graphics.DrawLine(pen, (200.0F / 0.254F), (10.0F / 0.254F), (200.0F / 0.254F), (287.0F / 0.254F));
            e.Graphics.DrawLine(pen, (25.0F / 0.254F), (10.0F / 0.254F), (200.0F / 0.254F), (10.0F / 0.254F));
            e.Graphics.DrawLine(pen, (25.0F / 0.254F), (287.0F / 0.254F), (200.0F / 0.254F), (287.0F / 0.254F));
        }

        /// <summary>Muestra una propiedad en la grilla</summary>
        /// <param name="property">Propiedad</param>
        /// <param name="value">valor</param>
        private void AddPrinterProperty(string property, string value)
        {
            DataRow datarow = _tabladatos.NewRow();
            datarow["Propiedad"] = property;
            datarow["Valor"] = value;
            _tabladatos.Rows.Add(datarow);
        }

        /// <summary>Carga los settins</summary>
        private void CargarSettings()
        {
            pdcDocumento.PrinterSettings.PrinterName = cbxPrinters.SelectedItem.ToString();
            _tabladatos.Rows.Clear();

            AddPrinterProperty("Nombre Papel", pdcDocumento.PrinterSettings.DefaultPageSettings.PaperSize.PaperName);
            AddPrinterProperty("Ancho Papel", (pdcDocumento.PrinterSettings.DefaultPageSettings.PaperSize.Width * 0.254).ToString());
            AddPrinterProperty("Alto Papel", (pdcDocumento.PrinterSettings.DefaultPageSettings.PaperSize.Height * 0.254).ToString());
            AddPrinterProperty("Margen Izquierdo", (pdcDocumento.PrinterSettings.DefaultPageSettings.Margins.Left * 0.254).ToString());
            AddPrinterProperty("Margen Derecho", (pdcDocumento.PrinterSettings.DefaultPageSettings.Margins.Right* 0.254).ToString());
            AddPrinterProperty("Margen Superior", (pdcDocumento.PrinterSettings.DefaultPageSettings.Margins.Top * 0.254).ToString());
            AddPrinterProperty("Margen Inferior", (pdcDocumento.PrinterSettings.DefaultPageSettings.Margins.Bottom * 0.254).ToString());
            AddPrinterProperty("Tipo Resolucion", pdcDocumento.PrinterSettings.DefaultPageSettings.PrinterResolution.Kind.ToString());
            AddPrinterProperty("Resolucion X", pdcDocumento.PrinterSettings.DefaultPageSettings.PrinterResolution.X.ToString());
            AddPrinterProperty("Resolucion Y", pdcDocumento.PrinterSettings.DefaultPageSettings.PrinterResolution.Y.ToString());
            AddPrinterProperty("Margen Hard X", (pdcDocumento.PrinterSettings.DefaultPageSettings.HardMarginX * 0.254).ToString());
            AddPrinterProperty("Margen Hard Y", (pdcDocumento.PrinterSettings.DefaultPageSettings.HardMarginY * 0.254).ToString());
            AddPrinterProperty("Apaisado", (pdcDocumento.PrinterSettings.DefaultPageSettings.Landscape).ToString());

            ppcDocumento.InvalidatePreview();
            

        }

        /// <summary>Carga las impresoras</summary>
        private void LoadPrinters()
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
                cbxPrinters.Items.Add(printer);
            
            if (cbxPrinters.Items.Count>0)
                cbxPrinters.SelectedIndex = 0;


        }

        #endregion

        #region "Eventos del Form"

        /// <summary>Load del form</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadPrinters();
        }

        /// <summary>Evento al seleccionar una impresora</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbxPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSettings();
        }

        /// <summary>Imprime la hoja</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            pdcDocumento.Print();
        }

        #endregion
    }
}