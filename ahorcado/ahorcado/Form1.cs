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
        private Control[] controlesLetras = new Control[13];
        private Control[] controlesHuecos = new Control[13];
        private Control[] controlesHorrocruxes = new Control[7];

        public Form1()
        {
            InitializeComponent();

            controlesLetras[0] = letra0;
            controlesLetras[1] = letra1;
            controlesLetras[2] = letra2;
            controlesLetras[3] = letra3;
            controlesLetras[4] = letra4;
            controlesLetras[5] = letra5;
            controlesLetras[6] = letra6;
            controlesLetras[7] = letra7;
            controlesLetras[8] = letra8;
            controlesLetras[9] = letra9;
            controlesLetras[10] = letra10;
            controlesLetras[11] = letra11;
            controlesLetras[12] = letra12;

            controlesHuecos[0] = guion0;
            controlesHuecos[1] = guion1;
            controlesHuecos[2] = guion2;
            controlesHuecos[3] = guion3;
            controlesHuecos[4] = guion4;
            controlesHuecos[5] = guion5;
            controlesHuecos[6] = guion6;
            controlesHuecos[7] = guion7;
            controlesHuecos[8] = guion8;
            controlesHuecos[9] = guion9;
            controlesHuecos[10] = guion10;
            controlesHuecos[11] = guion11;
            controlesHuecos[12] = guion12;

            controlesHorrocruxes[0] = imagenHorrocrux1;
            controlesHorrocruxes[1] = imagenHorrocrux2;
            controlesHorrocruxes[2] = imagenHorrocrux3;
            controlesHorrocruxes[3] = imagenHorrocrux4;
            controlesHorrocruxes[4] = imagenHorrocrux5;
            controlesHorrocruxes[5] = imagenHorrocrux6;
            controlesHorrocruxes[6] = imagenHorrocrux7;

        }

        private void leerPalabras()
        {
            string projectDirectory = Path.GetDirectoryName(Application.ExecutablePath); 
            string url = Path.Combine(projectDirectory, "..", "..", "Archivos", "harryPotter.txt");

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
            string projectDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(projectDirectory, "..", "..", "Archivos", "harryPotter.txt");

            if (File.Exists(filePath))
            {
                palabras.Add(nuevaPalabra);
                File.AppendAllText(filePath, Environment.NewLine + nuevaPalabra);

                MessageBox.Show("Palabra añadida con éxito.");
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
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

            String palabraRandom = palabras[new Random().Next(0, palabras.Count)];
            MessageBox.Show(palabraRandom);
            labelPalabraOculta.Text = palabraRandom;

            mostrarHuecos(palabraRandom);
        }

        public void mostrarHuecos(String palabra)
        {
            int tamanio = palabra.Length;

            if (tamanio == 13)
            {
                for (int i = 0; i < tamanio; i++)
                {
                    hacerVisibleControl(i, controlesHuecos);
                    escribirLetraEnControl(palabra[i].ToString(), i, controlesLetras);

                }
            }
            else if (tamanio == 12 || tamanio == 11 )
            {
                for (int i = 1; i < tamanio+1; i++)
                {
                    hacerVisibleControl(i, controlesHuecos);
                    escribirLetraEnControl(palabra[i-1].ToString(), i, controlesLetras);
                }
            }
            else if (tamanio == 10 || tamanio == 9 || tamanio == 8)
            {
                for (int i = 2; i < tamanio+2; i++)
                {
                    hacerVisibleControl(i, controlesHuecos);
                    escribirLetraEnControl(palabra[i-2].ToString(), i, controlesLetras);
                }
            }
            else if (tamanio == 7 || tamanio == 6)
            {
                for (int i = 3; i < tamanio + 3; i++)
                {
                    hacerVisibleControl(i, controlesHuecos);
                    escribirLetraEnControl(palabra[i-3].ToString(), i, controlesLetras);
                }
            } else
            {
                for (int i = 4; i < tamanio + 4; i++)
                {
                    hacerVisibleControl(i, controlesHuecos);
                    escribirLetraEnControl(palabra[i-4].ToString(), i, controlesLetras);
                }
            }
        }

        public void hacerVisibleControl( int i, Control[] controles)
        {
            controles[i].Visible = true;
        }

        public void escribirLetraEnControl(String letra, int i, Control[] controles)
        {
            controles[i].Text = letra;
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
            hacerInvisibles(controlesHorrocruxes);
        }

        public void hacerInvisibleHuecosYLetras()
        {
            hacerInvisibles(controlesLetras);
            hacerInvisibles(controlesHuecos);
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
            //tengo que habilitarlos y ponerles el color amarillo
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void mecanismoDeVerificacion( String letraSeleccionada, String palabraAdivinar)
        {
            if (palabraAdivinar.Contains(letraSeleccionada))
            {
                for (int i = 0; i < 13; i++)
                {
                    if (controlesLetras[i].Equals(letraSeleccionada))
                    {
                        hacerVisibleControl(i, controlesLetras);
                    }
                }

                mensajes.Text = "¡La letra " + letraSeleccionada + " es correcta!";
            }
            else
            {
                int fallos = int.Parse(fallosPermitidos.Text);
                hacerVisibleControl(7 - fallos, controlesHorrocruxes);

                mensajes.Text = "¡La letra " + letraSeleccionada + " es incorrecta!";

                fallosPermitidos.Text = (fallos - 1).ToString();
            }

        }

        public void inhabilitarBotonLetra( Control boton)
        {
            boton.Enabled = false;
            boton.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void btnLetraA_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "A";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);           

            inhabilitarBotonLetra(btnLetraA);
        }
    }
}
