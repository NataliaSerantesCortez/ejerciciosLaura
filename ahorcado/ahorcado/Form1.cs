using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahorcado
{
    public partial class Form1 : Form
    {
        private List<string> palabras = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void leerPalabras()
        {
            string url = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "harryPotter.txt");

            if (File.Exists(url))
            {
                palabras.Clear();
                foreach (string line in File.ReadAllLines(url))
                {
                    palabras.Add(line.Trim());
                }

                MessageBox.Show("Palabras cargadas con éxito.");
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }

        private void escribirPalabra( String nuevaPalabra )
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "harryPotter.txt");

            if (!string.IsNullOrWhiteSpace(nuevaPalabra))
            {
                palabras.Add(nuevaPalabra);
                File.AppendAllText(filePath, Environment.NewLine + nuevaPalabra);

                MessageBox.Show("Palabra añadida con éxito.");
            }
            else
            {
                MessageBox.Show("Por favor, introduce una palabra válida.");
            }

            // Verifica el contenido del archivo
            //if (File.Exists(filePath))
            //{
            //    string[] lines = File.ReadAllLines(filePath);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);  // O muestra en un MessageBox
            //    }
            //}
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

            leerPalabras();

            //String palabraRandom = palabras[new Random().Next(0, palabras.Count)];
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
            limpiarCamposLogin();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String usuario = tfUsuario.Text;
            String password = tfPassword.Text;

            if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(password))
            {
                if (usuario.Equals("admin") && password.Equals("1234"))
                {
                    hacerInvisiblePanelLogin();
                    hacerVisiblePanelAdmin();
                } else
                {
                    MessageBox.Show("Credenciales incorrectas.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                limpiarCamposLogin();
            }
            else
            {
                MessageBox.Show("Los campos son obligatorios.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            hacerInvisiblePanelAdmin();
            hacerVisiblePanelInicio();
            tfPalabra.Text = "";
        }

        private void imagenGafasLuna_Click(object sender, EventArgs e)
        {
            if ( tfPassword.PasswordChar == '*')
            {
                tfPassword.PasswordChar = '\0';
            } else
            {
                tfPassword.PasswordChar = '*';
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {            
            String palabraNueva = tfPalabra.Text;

            if (!string.IsNullOrWhiteSpace(palabraNueva))
            {
                if (palabraNueva.Length <= 13 && !palabraNueva.Contains(" "))
                {
                    leerPalabras();
                    palabraNueva = palabraNueva.ToUpper().Trim();

                    if (palabras.Contains(palabraNueva))
                    {
                        MessageBox.Show("La palabra YA pertenece a la lista.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        escribirPalabra(palabraNueva);
                    }
                }
                else
                {
                    MessageBox.Show("Palabra inválida.", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El campo nueva palabra es obligatorio.", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tfPalabra.Text = "";
        }
    }
}
