using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teatro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double valorEntrada = 8.20;
            int entradaTipo1 = (int)primerDescuento.Value;
            int entradaTipo2 = (int)segundoDescuento.Value;
            int entradaTipo3 = (int)tercerDescuento.Value;
            int entradaTipo4 = (int)cuartoDescuento.Value;
            int entradaTipo5 = (int)quintoDescuento.Value;
            int entradaTipo6 = (int)sextoDescuento.Value;

            int numeroTotalEntradas = entradaTipo1 + entradaTipo2 + entradaTipo3 +
                entradaTipo4 + entradaTipo5 + entradaTipo6;

            if (numeroTotalEntradas > 0 && numeroTotalEntradas <= 5)
            {
                double precioTotal = 0.65 * valorEntrada * entradaTipo1 + 0.75 * valorEntrada * entradaTipo2 +
                    0.90 * valorEntrada * entradaTipo3 + 0.75 * valorEntrada * entradaTipo4 +
                    0.65 * valorEntrada * entradaTipo5 + 0.5 * valorEntrada * entradaTipo6;

                tbTotal.Text = precioTotal.ToString("F2") + " €";
            }
            else if ( numeroTotalEntradas > 5 )
            {
                MessageBox.Show("El número máximo de entradas por cliente es 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                MessageBox.Show("No has seleccionado ninguna entrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
