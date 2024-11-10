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

namespace TotalPagar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numeroValor = (double)numericUpDown1.Value;
            int cantidad = (int)nbCantidad.Value;
            double subtotal = 0.0;
            double descuento = 1.0;
            double total = 0.0;

            subtotal = cantidad * numeroValor;

            if (subtotal > 300)
            {
                descuento = 0.8;
                total = descuento * subtotal;
            } else if (subtotal >= 200 && subtotal <= 300)
            {
                descuento = 0.85;
                total = descuento * subtotal;
            } else
            {
                total = subtotal;
            }

            tfTotal.Text = total.ToString("F2"); //para mostrar solo 2 decimales

            labelDescuento.Text = "Desglose:" +
                    "\nSubtotal= " + cantidad + "x" + numeroValor.ToString("F2") + " = " + subtotal.ToString("F2") + "€" +
                    "\n" + (1 - descuento) * 100 + "%" + " de descuento= " + ((1 - descuento) * subtotal).ToString("F2") + "€" +
                    "\nTotal= " + total.ToString("F2") + "€";           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelDescuento_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelDescuento.Visible = cbDesglose.Checked;
            imagenDescuento.Visible = cbDesglose.Checked;

        }
    }
}
