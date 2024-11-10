using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FechaNacimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = calendario.SelectionStart;
            DateTime fechaActual = DateTime.Today;
            DateTime proximoCumpleaños = new DateTime(fechaActual.Year, fechaSeleccionada.Month, 
                fechaSeleccionada.Day);

            if (proximoCumpleaños < fechaActual)
            {
                proximoCumpleaños = proximoCumpleaños.AddYears(1);
            }

            int diasParaProximoCumpleaños = (proximoCumpleaños - fechaActual).Days;

            labelDias.Text = "¡Faltan " + diasParaProximoCumpleaños + " días para tu cumpleaños!";

            int edad = fechaActual.Year - fechaSeleccionada.Year;

            if (fechaSeleccionada.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            labelEdad.Text = "Tu edad es " + edad + " años.";

        }
    }
}
