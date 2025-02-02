using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aRTICULOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aRTICULOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pedidosDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pedidosDataSet.ARTICULOS' Puede moverla o quitarla según sea necesario.
            this.aRTICULOSTableAdapter.Fill(this.pedidosDataSet.ARTICULOS);    
           
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "ARTICULOS"; 
            reportDataSource.Value = pedidosDataSet.ARTICULOS; 
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\natal\\source\\repos\\inventario\\inventario\\InformeRealizadoPorNSC.rdlc";
            reportViewer1.RefreshReport();
        }

    }
}
