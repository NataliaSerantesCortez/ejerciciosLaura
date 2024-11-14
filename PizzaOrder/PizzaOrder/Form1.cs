using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetColorScheme();
            Microsoft.Win32.SystemEvents.UserPreferenceChanged
               += new Microsoft.Win32.UserPreferenceChangedEventHandler(
            this.UserPreferenceChanged);
        }

        public void UserPreferenceChanged(object sender, Microsoft.Win32.UserPreferenceChangedEventArgs e)
        {
            SetColorScheme();
        }

        private void SetColorScheme()
        {
            if (SystemInformation.HighContrast)
            {
                labelEmpresa.BackColor = SystemColors.Window;
                labelEmpresa.ForeColor = SystemColors.WindowText;
            }
            else
            {
                labelEmpresa.BackColor = Color.Blue;
                labelEmpresa.ForeColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainMenu theMainMenu = new MainMenu();

            MenuItem fileCommands = new MenuItem("&Archivo");
            MenuItem exitApp = new MenuItem("&Salir");

            exitApp.Click += ExitApp_Click;

            fileCommands.MenuItems.Add(exitApp);
            theMainMenu.MenuItems.Add(fileCommands);

            this.Menu = theMainMenu;
        }
        private void ExitApp_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos(); 
        }

        private void limpiarCampos()
        {
            nombreCliente.Text = "";

            pizzaPequenia.Checked = false;
            pizzaGrande.Checked = false;

            for (int i = 0; i < toppings.Items.Count; i++)
            {
                toppings.SetItemChecked(i, false); //para desmarcar
            }
        }

        private void botonPedir_Click(object sender, EventArgs e)
        {
            String nombre= nombreCliente.Text;
            double precioPizzaPequenia = 6.0;
            double precioPizzaGrande = 10.0;

            double precioTopping = 0.75;
            int cantidadMarcados = toppings.CheckedIndices.Count;

            double precioPedido;

            if (!pizzaPequenia.Checked && !pizzaGrande.Checked )
            {
                MessageBox.Show("Debes elegir un tamaño de pizza.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);             
            } 
            else if (pizzaPequenia.Checked)
            {
                precioPedido = precioPizzaPequenia + precioTopping * cantidadMarcados;
                MessageBox.Show("¡Gracias por tu pedido " + nombre + "!" +
                    "\n1 Pizza pequeña con " + cantidadMarcados + " toppings. " +
                    "\nPrecio total: " + precioPedido + " euros.", "Resumen del pedido");

                limpiarCampos();
            }
            else if (pizzaGrande.Checked)
            {
                precioPedido = precioPizzaGrande + precioTopping * cantidadMarcados;
                MessageBox.Show("¡Gracias por tu pedido " + nombre + "!" +
                    "\n1 Pizza grande con " + cantidadMarcados + " toppings. " +
                   "\nPrecio total: " + precioPedido + " euros.", "Resumen del pedido");

                limpiarCampos();
            }
        }
    }
}
