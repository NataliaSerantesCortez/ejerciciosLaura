using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vuelos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = checkBox1.Checked;
            labelFechaVuelta.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String origen = comboBox1.Text;
            String destino = comboBox2.Text;
            DateTime fechaIdaSeleccionada = dateTimePicker2.Value;
            DateTime fechaVueltaSeleccionada = dateTimePicker1.Value;

           

            if (origen.Equals("") || destino.Equals(""))
            {
                MessageBox.Show("No puede estar vacío el origen o destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (origen.Equals(destino))
            {
                MessageBox.Show("El destino no puede ser igual al origen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkBox1.Checked)
                {
                    if (fechaIdaSeleccionada > fechaVueltaSeleccionada)
                    {
                        MessageBox.Show("La fecha de vuelta no puede ser anterior a la fecha de ida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else /*if (!origen.Equals(destino))*/
                    {
                        MessageBox.Show("Estamos buscando su vuelo...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else /*if (!origen.Equals(destino))*/
                {
                    MessageBox.Show("Estamos buscando su vuelo...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }
    }
}
