using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado
{
    public partial class Form1 : Form
    {
        private BindingList<string> palabras = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void leerPalabras()
        {
            string url = "ruta_del_archivo.txt";

            if (File.Exists(url))
            {
                palabras.Clear(); // Limpia la lista antes de cargar nuevas palabras
                foreach (string line in File.ReadAllLines(url))
                {
                    palabras.Add(line); // Añade cada línea a la BindingList
                }

                MessageBox.Show("Palabras cargadas con éxito.");
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }

        private void escribirPalabra()
        {
            string filePath = "ruta_del_archivo.txt"; // Ruta del archivo
            string nuevaPalabra = tfPalabra.Text; // TextBox para ingresar nueva palabra

            if (!string.IsNullOrWhiteSpace(nuevaPalabra))
            {
                palabras.Add(nuevaPalabra); // Añade a la BindingList (UI se actualiza automáticamente)
                File.AppendAllText(filePath, nuevaPalabra + Environment.NewLine); // Añade al archivo

                MessageBox.Show("Palabra añadida con éxito.");
                tfPalabra.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, introduce una palabra válida.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            hacerInvisiblePanelInicio();
            hacerVisiblePanelPartida();
        }
        public void hacerInvisiblePanelPartida()
        {
            hacerInvisibleAbecedario();
            hacerInvisibles(btnAbandonarPartida, imagenVoldemort, labelNodejes, labelHorrocruxes, 
                fallosPermitidos, mensajes);
            hacerInvisibleHorrocruxes();
            hacerInvisibleHuecosYLetras();
        }

        public void hacerInvisibleHorrocruxes() 
        {
            hacerInvisibles(imagenHorrocrux1, imagenHorrocrux2, imagenHorrocrux3, imagenHorrocrux4, imagenHorrocrux5,
                imagenHorrocrux6, imagenHorrocrux7);
        }

        public void hacerInvisibleHuecosYLetras()
        {
            hacerInvisibles(letra0, letra1, letra2, letra3, letra4, letra5, letra6, letra7, letra8,
                letra9, letra10, letra11, letra12);
            hacerInvisibles(guion0, guion1, guion2, guion3, guion4, guion5, guion6, guion7, guion8,
               guion9, guion10, guion11, guion12);
        }

        public void hacerVisiblePanelPartida()
        {
            hacerVisibleAbecedario();
            hacerVisibles(btnAbandonarPartida, imagenVoldemort, labelNodejes, labelHorrocruxes, fallosPermitidos );
        }

        public void hacerInvisiblePanelInicio()
        {
            hacerInvisibles(labelAhorcado, labelSubtitulo, gbDificultad, nivelBasico, nivelMedio
                , nivelAvanzado, imagenSombrero, btnIniciarPartida, imagenLlave);
        }

        public void hacerVisiblePanelInicio()
        {
            hacerVisibles(labelAhorcado, labelSubtitulo, gbDificultad, nivelBasico, nivelMedio
                , nivelAvanzado, imagenSombrero, btnIniciarPartida, imagenLlave);
        }

        public void hacerInvisiblePanelLogin()
        {
            hacerInvisibles(labelUsuario, labelContrasenia, tfUsuario, tfPassword, imagenGafasLuna,
                btnIniciarSesion, btnAtras);
        }

        public void hacerVisiblePanelLogin()
        {
            hacerVisibles(labelUsuario, labelContrasenia, tfUsuario, tfPassword, imagenGafasLuna,
                btnIniciarSesion, btnAtras);
        }

        public void hacerInvisiblePanelAdmin()
        {
            hacerInvisibles(imagenPluma, labelaniadir, labelAclaracion, labelNuevaPalabra, tfPalabra,
                btnCerrarSesion, btnAgregar);
        }

        public void hacerVisiblePanelAdmin()
        {
            hacerVisibles(imagenPluma, labelaniadir, labelAclaracion, labelNuevaPalabra, tfPalabra,
                btnCerrarSesion, btnAgregar);
        }

        public void hacerInvisibleAbecedario()
        {
            hacerInvisibles(btnLetraA, btnLetraB, btnLetraC, btnLetraD, btnLetraD, btnLetraE, btnLetraF, btnLetraG,
                btnLetraH, btnLetraI, btnLetraJ, btnLetraK, btnLetraL, btnLetraM, btnLetraN, btnLetraGN, btnLetraO,
                btnLetraP, btnLetraQ, btnLetraR, btnLetraS, btnLetraT, btnLetraU, btnLetraV, btnLetraW, btnLetraX,
                btnLetraY, btnLetraZ);
        }

        public void hacerVisibleAbecedario()
        {
            hacerVisibles(btnLetraA, btnLetraB, btnLetraC, btnLetraD, btnLetraD, btnLetraE, btnLetraF, btnLetraG,
                btnLetraH, btnLetraI, btnLetraJ, btnLetraK, btnLetraL, btnLetraM, btnLetraN, btnLetraGN, btnLetraO,
                btnLetraP, btnLetraQ, btnLetraR, btnLetraS, btnLetraT, btnLetraU, btnLetraV, btnLetraW, btnLetraX,
                btnLetraY, btnLetraZ);
        }

        public void hacerInvisibles(params Control[] controles)
        {
            foreach (var control in controles)
            {
                control.Visible = false;
            }
        }

        public void hacerVisibles(params Control[] controles)
        {
            foreach (var control in controles)
            {
                control.Visible = true;
            }
        }

        public void limpiarCamposLogin()
        {
            tfUsuario.Text = "";
            tfPassword.Text = "";
        }

        private void btnAbandonarPartida_Click(object sender, EventArgs e)
        {
            hacerVisiblePanelInicio();
            hacerInvisiblePanelPartida();
        }

        private void imagenLlave_Click(object sender, EventArgs e)
        {
            hacerInvisiblePanelInicio();
            hacerVisiblePanelLogin();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            hacerVisiblePanelInicio();
            hacerInvisiblePanelLogin();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String usuario = tfUsuario.Text;
            String password = tfPassword.Text;

            //if (usuario == null)
            //{
            //    MessageBox.Show("El campo Usuario es obligatorio.", "Error", 
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //if (password == null)
            //{
            //    MessageBox.Show("El campo Contraseña es obligatorio.", "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (usuario != null && password != null)
            {
                if (usuario.Equals("admin") && password.Equals("1234"))
                {
                    hacerInvisiblePanelLogin();
                    hacerVisiblePanelAdmin();
                } else
                {
                    MessageBox.Show("Las credenciales son incorrectas.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                limpiarCamposLogin();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            hacerInvisiblePanelAdmin();
            hacerVisiblePanelInicio();
        }
    }
}
