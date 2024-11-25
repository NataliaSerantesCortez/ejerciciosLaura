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
        private Control[] botonesLetras = new Control[27];

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

            botonesLetras[0] = btnLetraA;
            botonesLetras[1] = btnLetraB;
            botonesLetras[2] = btnLetraC;
            botonesLetras[3] = btnLetraD;
            botonesLetras[4] = btnLetraE;
            botonesLetras[5] = btnLetraF;
            botonesLetras[6] = btnLetraG;
            botonesLetras[7] = btnLetraH;
            botonesLetras[8] = btnLetraI;
            botonesLetras[9] = btnLetraJ;
            botonesLetras[10] = btnLetraK;
            botonesLetras[11] = btnLetraL;
            botonesLetras[12] = btnLetraM;
            botonesLetras[13] = btnLetraN;
            botonesLetras[14] = btnLetraGN;
            botonesLetras[15] = btnLetraO;
            botonesLetras[16] = btnLetraP;
            botonesLetras[17] = btnLetraQ;
            botonesLetras[18] = btnLetraR;
            botonesLetras[19] = btnLetraS;
            botonesLetras[20] = btnLetraT;
            botonesLetras[21] = btnLetraU;
            botonesLetras[22] = btnLetraV;
            botonesLetras[23] = btnLetraW;
            botonesLetras[24] = btnLetraX;
            botonesLetras[25] = btnLetraY;
            botonesLetras[26] = btnLetraZ;

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
            }
            else
            {
                MessageBox.Show("El archivo no existe.", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);                
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

                MessageBox.Show("Palabra añadida con éxito.", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else
            {
                MessageBox.Show("El archivo no existe.", "Error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            limpiarLetras();
            hacerInvisiblePanelInicio();
            hacerVisiblePanelPartida();

            leerPalabras();           

            String palabraRandom = palabras[new Random().Next(0, palabras.Count)];
            labelPalabraOculta.Text = palabraRandom;
            String palabraAdivinar = labelPalabraOculta.Text;

            mostrarHuecos(palabraRandom);

            if (nivelBasico.Checked)
            {
                String letraRandom1 = palabraRandom[new Random().Next(0, palabraRandom.Length)].ToString();
                String letraRandom2;

                do
                {
                    letraRandom2 = palabraRandom[new Random().Next(0, palabraRandom.Length)].ToString();
                } while (letraRandom1.Equals(letraRandom2));                

                mecanismoDeVerificacion(letraRandom1, palabraAdivinar);
                mecanismoDeVerificacion(letraRandom2, palabraAdivinar);

                for (int i = 0; i < 27; i++)
                {
                    String letraBoton = botonesLetras[i].Text;
                    if (letraBoton.Equals(letraRandom1))
                    {
                        inhabilitarBotonLetra(botonesLetras[i]);
                    }

                    if (letraBoton.Equals(letraRandom2))
                    {
                        inhabilitarBotonLetra(botonesLetras[i]);
                    }
                }
            }

            if (nivelMedio.Checked)
            {
                String letraRandom = palabraRandom[ new Random().Next(0, palabraRandom.Length)].ToString();             
                mecanismoDeVerificacion(letraRandom, palabraAdivinar);
                for (int i = 0; i < 27; i++)
                {
                    String letraBoton = botonesLetras[i].Text;
                    if (letraBoton.Equals(letraRandom))
                    {
                        inhabilitarBotonLetra(botonesLetras[i]);
                    }
                }                
            }
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
            if (i >= 0 && i < controles.Length)
            {
                controles[i].Visible = true;
            }
        }

        public void hacerInvisibleControl(int i, Control[] controles)
        {
            if (i >= 0 && i < controles.Length)
            {
                controles[i].Visible = false;
            }
        }

        public void escribirLetraEnControl(String letra, int i, Control[] controles)
        {
            if (i >= 0 && i < controles.Length)
            {
                controles[i].Visible = true;
                controles[i].Text = letra;
                controles[i].Visible = false;
            }
        }

        public void hacerInvisiblePanelPartida()
        {
            hacerInvisibleAbecedario();
            hacerInvisibles(panelAbecedario, btnAbandonarPartida, imagenVoldemort, labelNodejes, labelHorrocruxes, 
                fallosPermitidos, mensajes);
            hacerInvisibleHorrocruxes();
            hacerInvisibleHuecosYLetras();
        }

        public void hacerInvisibleHorrocruxes() 
        {
            hacerInvisibles(controlesHorrocruxes);
            hacerInvisibles(panelHorrocruxes);
        }

        public void limpiarLetras()
        {
            foreach (var control in controlesLetras)
            {
                control.Text = "";
            }
        }

        public void hacerInvisibleHuecosYLetras()
        {
            hacerInvisibles(controlesLetras);
            hacerInvisibles(controlesHuecos);
        }

        public void hacerVisiblePanelPartida()
        {
            fallosPermitidos.Text = "7";
            labelContadorOculto.Text = "0";
            hacerVisibleAbecedario();
            hacerVisibles(panelAbecedario, panelHorrocruxes, btnAbandonarPartida, imagenVoldemort, labelNodejes, labelHorrocruxes, fallosPermitidos);
        }

        public void hacerInvisiblePanelInicio()
        {
            hacerInvisibles(labelAhorcado, labelSubtitulo, gbDificultad, nivelBasico, nivelMedio
                , nivelAvanzado, imagenSombrero, btnIniciarPartida, imagenLlave);
        }

        public void hacerVisiblePanelInicio()
        {
            nivelMedio.Checked = true;
            hacerVisibles(labelAhorcado, labelSubtitulo, gbDificultad, nivelBasico, nivelMedio
                , nivelAvanzado, imagenSombrero, btnIniciarPartida, imagenLlave);
        }

        public void hacerInvisiblePanelLogin()
        {
            hacerInvisibles(panelLogin, labelUsuario, labelContrasenia, tfUsuario, tfPassword, imagenGafasLuna,
                btnIniciarSesion, btnAtras);
        }

        public void hacerVisiblePanelLogin()
        {
            tfPassword.PasswordChar = '*';
            hacerVisibles(panelLogin, labelUsuario, labelContrasenia, tfUsuario, tfPassword, imagenGafasLuna,
                btnIniciarSesion, btnAtras);
        }

        public void hacerInvisiblePanelAdmin()
        {
            hacerInvisibles(panelAdmin, imagenPluma, labelaniadir, labelAclaracion, labelNuevaPalabra, tfPalabra,
                btnCerrarSesion, btnAgregar);
        }

        public void hacerVisiblePanelAdmin()
        {
            hacerVisibles(panelAdmin, imagenPluma, labelaniadir, labelAclaracion, labelNuevaPalabra, tfPalabra,
                btnCerrarSesion, btnAgregar);
        }

        public void hacerInvisibleAbecedario()
        {
            hacerInvisibles(botonesLetras);
        }

        public void hacerVisibleAbecedario()
        {
            habilitarBotonLetra(botonesLetras);
            hacerVisibles(botonesLetras);
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
                    if (palabraNueva.Length > 13)
                    {
                        MessageBox.Show("Palabra inválida. Debe tener como máximo 13 letras.", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (palabraNueva.Contains(" "))
                    {
                        MessageBox.Show("Palabra inválida. No debe tener espacios entre medias.", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        public async void mecanismoDeVerificacion( String letraSeleccionada, String palabraAdivinar)
        {
            int fallos = int.Parse(fallosPermitidos.Text);
            int tamanio = palabraAdivinar.Length;
            int contador = int.Parse(labelContadorOculto.Text);

            if (palabraAdivinar.Contains(letraSeleccionada))
            {
                for (int i = 0; i < 13; i++)
                {
                    String letra = controlesLetras[i].Text;
                    if (letra.Equals(letraSeleccionada))
                    {
                        hacerVisibleControl(i, controlesLetras);
                        contador++;
                        labelContadorOculto.Text = contador.ToString();
                        //MessageBox.Show("" +contador);
                    }
                }

                mensajes.Text = "¡La letra " + letraSeleccionada + " es correcta!";
            }
            else
            {
                hacerVisibleControl(7 - fallos, controlesHorrocruxes);

                mensajes.Text = "¡La letra " + letraSeleccionada + " es incorrecta!";

                fallosPermitidos.Text = (fallos - 1).ToString();
            }

            hacerVisibles(mensajes);

            fallos = int.Parse(fallosPermitidos.Text);

            if ( fallos == 0)
            {
                await Task.Delay(400);
                hacerInvisiblePanelPartida();
                mostrarMensajePerdedor(palabraAdivinar);
            }

            if ( contador == tamanio)
            {
                await Task.Delay(400);
                hacerInvisiblePanelPartida();
                mostrarMensajeGanador();
            }     
        }

        public void mostrarMensajePerdedor ( String palabra )
        {
            labelLapalabra.Text = "La palabra era " + palabra + ".";
            hacerVisibles(panelMensaje, imagenMarcaTeneborsa, labelAvada, labelSubtAvada, labelLapalabra , btnSalir);
        }
        public void mostrarMensajeGanador()
        {
            hacerVisibles(panelMensaje, imagenTrofeo, labelFelicitaciones, labelSubtFelicitaciones, btnSalir);
        }

        public void hacerInvisiblePanelMensaje()
        {
            hacerInvisibles(panelMensaje, imagenTrofeo, labelFelicitaciones, labelSubtFelicitaciones, btnSalir,
                imagenMarcaTeneborsa, labelAvada, labelSubtAvada, labelLapalabra);
        }

        public void inhabilitarBotonLetra( Control boton)
        {
            boton.Enabled = false;
            boton.BackColor = Color.FromArgb(192, 0, 0);
        }

        public void habilitarBotonLetra(params Control[] controles)
        {
            foreach (var control in controles)
            {
                control.Enabled = true;
                control.BackColor = Color.DarkOrange;
            }      
        }

        private void btnLetraA_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "A";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);           

            inhabilitarBotonLetra(btnLetraA);
        }

        private void btnLetraB_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "B";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraB);
        }

        private void btnLetraC_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "C";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraC);
        }

        private void btnLetraD_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "D";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraD);
        }

        private void btnLetraE_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "E";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraE);
        }

        private void btnLetraF_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "F";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraF);
        }

        private void btnLetraG_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "G";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraG);
        }

        private void btnLetraH_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "H";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraH);
        }

        private void btnLetraI_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "I";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraI);
        }

        private void btnLetraJ_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "J";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraJ);
        }

        private void btnLetraK_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "K";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraK);
        }

        private void btnLetraL_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "L";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraL);
        }

        private void btnLetraM_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "M";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraM);
        }

        private void btnLetraN_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "N";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraN);
        }

        private void btnLetraGN_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "Ñ";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraGN);
        }

        private void btnLetraO_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "O";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraO);
        }

        private void btnLetraP_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "P";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraP);
        }

        private void btnLetraQ_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "Q";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraQ);
        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "R";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraR);
        }

        private void btnLetraS_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "S";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraS);
        }

        private void btnLetraT_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "T";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraT);
        }

        private void btnLetraU_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "U";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraU);
        }

        private void btnLetraV_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "V";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraV);
        }

        private void btnLetraW_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "W";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraW);
        }

        private void btnLetraX_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "X";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraX);
        }

        private void btnLetraY_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "Y";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraY);
        }

        private void btnLetraZ_Click(object sender, EventArgs e)
        {
            String letraSeleccionada = "Z";
            String palabraAdivinar = labelPalabraOculta.Text;

            mecanismoDeVerificacion(letraSeleccionada, palabraAdivinar);

            inhabilitarBotonLetra(btnLetraZ);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            hacerVisiblePanelInicio();
            hacerInvisiblePanelMensaje();
        }
    }
}
