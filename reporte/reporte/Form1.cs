using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventarioDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.inventarioDataSet.productos);

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "productos";
            reportDataSource.Value = inventarioDataSet.productos;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\natal\\source\\repos\\ejerciciosLaura\\reporte\\reporte\\InformeRealizadoPorNSC.rdlc";
            reportViewer1.RefreshReport();

        }

        private void productosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
