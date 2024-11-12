using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaRefrescos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void euro2_Click(object sender, EventArgs e)
        {
            if (imagenRecoger.Visible == false)
            {
                if (tfDinero.Text.Equals("Ingresa el dinero"))
                {
                    tfDinero.Text = "2";
                }
                else
                {
                    String dineroIngresadoString = tfDinero.Text;
                    double dineroIngresado = Convert.ToDouble(dineroIngresadoString);

                    if (dineroIngresado >= 10)
                    {
                        MessageBox.Show("Ya has ingresado demasiadas monedas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dineroIngresado += 2;
                        tfDinero.Text = dineroIngresado.ToString();
                    }
                }
            } else
            {
                MessageBox.Show("Antes de continuar debes recoger la bebida y la vuelta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void euro50_Click(object sender, EventArgs e)
        {
            if (imagenRecoger.Visible == false)
            {
                if (tfDinero.Text.Equals("Ingresa el dinero"))
                {
                    tfDinero.Text = "0.50";
                }
                else
                {
                    String dineroIngresadoString = tfDinero.Text;
                    double dineroIngresado = 0.5;
                    if (!dineroIngresadoString.Equals("0.50"))
                    {
                        dineroIngresado = Convert.ToDouble(dineroIngresadoString);
                    }
                    
                    if (dineroIngresado >= 10)
                    {
                        MessageBox.Show("Ya has ingresado demasiadas monedas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dineroIngresado += 0.5;
                        tfDinero.Text = dineroIngresado.ToString();
                    }
                }
            } else
            {
                MessageBox.Show("Antes de continuar debes recoger la bebida y la vuelta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (imagenRecoger.Visible == false)
            {
                tfBebidaElegida.Text = "1";
            }
            else
            {
                MessageBox.Show("Antes de continuar debes recoger la bebida y la vuelta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

            private void pictureBox6_Click(object sender, EventArgs e)
        {
            //una vez que se recoge, reinicio todos los valores
            imagenFanta.Visible = false;
            imagenCocaCola.Visible = false;
            imagenAgua.Visible = false;
            imagenSprite.Visible = false;

            tfDinero.Text = "Ingresa el dinero";
            tfBebidaElegida.Text = "Elige tu bebida";
            tfVuelta.Text = "Vuelta";

            labelRecoger.Visible = false;
            imagenRecoger.Visible = false;

        }

        private void imagenComprar_Click(object sender, EventArgs e)
        {
            if (!imagenRecoger.Visible)
            {
                if (tfBebidaElegida.Text.Equals("Elige tu bebida"))
                {
                    MessageBox.Show("Todavía no has elegido la bebida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (tfDinero.Text.Equals("Ingresa el dinero"))
                {
                    MessageBox.Show("Todavía no has ingresado el dinero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (!tfDinero.Text.Equals("Ingresa el dinero") && !tfBebidaElegida.Text.Equals("Elige tu bebida"))
                {
                    String dineroIngresadoString = tfDinero.Text;
                    double dineroIngresado = Convert.ToDouble(dineroIngresadoString);
                    double vuelto = 0.0;
                    if (tfBebidaElegida.Text.Equals("4") && dineroIngresado >= 2)
                    {
                        //se realiza la compra
                        imagenAgua.Visible = true;
                        imagenRecoger.Visible = true;
                        labelRecoger.Visible = true;

                        //manejo el vuelto
                        vuelto = dineroIngresado - 2;
                        tfVuelta.Text = vuelto.ToString();                            
                    } else if (tfBebidaElegida.Text.Equals("4"))
                    {
                        MessageBox.Show("El dinero no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (tfBebidaElegida.Text.Equals("1") && dineroIngresado >= 2.5)
                    {
                        //se realiza la compra
                        imagenCocaCola.Visible = true;
                        imagenRecoger.Visible = true;
                        labelRecoger.Visible = true;

                        //manejo el vuelto
                        vuelto = dineroIngresado - 2.5;
                        tfVuelta.Text = vuelto.ToString();
                    }
                    else if (tfBebidaElegida.Text.Equals("1"))
                    {
                        MessageBox.Show("El dinero no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (tfBebidaElegida.Text.Equals("2") && dineroIngresado >= 2.5)
                    {
                        //se realiza la compra
                        imagenSprite.Visible = true;
                        imagenRecoger.Visible = true;
                        labelRecoger.Visible = true;

                        //manejo el vuelto
                        vuelto = dineroIngresado - 2.5;
                        tfVuelta.Text = vuelto.ToString();
                    }
                    else if (tfBebidaElegida.Text.Equals("2"))
                    {
                        MessageBox.Show("El dinero no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (tfBebidaElegida.Text.Equals("3") && dineroIngresado >= 2.5)
                    {
                        //se realiza la compra
                        imagenFanta.Visible = true;
                        imagenRecoger.Visible = true;
                        labelRecoger.Visible = true;

                        //manejo el vuelto
                        vuelto = dineroIngresado - 2.5;
                        tfVuelta.Text = vuelto.ToString();
                    }
                    else if (tfBebidaElegida.Text.Equals("3"))
                    {
                        MessageBox.Show("El dinero no es suficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            } else
            {
                MessageBox.Show("Antes de continuar debes recoger la bebida y la vuelta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void labelBebida2_Click(object sender, EventArgs e)
        {
            if (imagenRecoger.Visible == false)
            {
                tfBebidaElegida.Text = "2";
            }
            else
            {
                MessageBox.Show("Antes de continuar debes recoger la bebida y la vuelta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelBebida3_Click(object sender, EventArgs e)
        {
            if (imagenRecoger.Visible == false)
            {
                tfBebidaElegida.Text = "3";
            }
            else
            {
                MessageBox.Show("Antes de continuar debes recoger la bebida y la vuelta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelBebida4_Click(object sender, EventArgs e)
        {
            if (imagenRecoger.Visible == false)
            {
                tfBebidaElegida.Text = "4";
            }
            else
            {
                MessageBox.Show("Antes de continuar debes recoger la bebida y la vuelta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
