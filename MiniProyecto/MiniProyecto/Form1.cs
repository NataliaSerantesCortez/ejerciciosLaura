using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Reflection.Emit;

using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;
using PdfiumViewer;

namespace MiniProyecto
{
    public partial class Form1 : Form
    {
        private PdfViewer pdfViewer;
        private bool modoAdmin;
        private String rutaPDF;
        public Form1()
        {
            InitializeComponent();

            modoAdmin = false;
            rutaPDF = "C:\\Users\\natal\\source\\repos\\ejerciciosLaura\\MiniProyecto\\MiniProyecto\\Resources\\Normas Convivencia 23-24.pdf";

            panelBienvenida.Visible = true;
            panelIniciosesion.Visible = false;
            panelInteres.Visible = false;
            panelPersonal.Visible = false;
            panelPlanos.Visible = false;
            panelFormulario.Visible = false;
            panelPDF.Visible = false;


            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            panelPDF.Controls.Add(pdfViewer);


            /*PrivateFontCollection pfc = new PrivateFontCollection();
            byte[] fontData = Properties.Resources.dosis_semibold__allfont_es_; 
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            pfc.AddMemoryFont(fontPtr, fontData.Length);

            label1.Font = new Font(pfc.Families[0], 12);*/

            /* PrivateFontCollection pfc = new PrivateFontCollection();

             // Obtener los bytes de la fuente desde los recursos
             byte[] fontData = Properties.Resources.dosis_semibold__allfont_es_;

             // Reservar memoria para la fuente
             IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
             Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

             // Agregar la fuente a la colección
             pfc.AddMemoryFont(fontPtr, fontData.Length);

             // Liberar la memoria asignada
             Marshal.FreeCoTaskMem(fontPtr);

             // Aplicar la fuente a un Label u otro control
             labelTitulo.Font = new Font(pfc.Families[0], 12);*/
        }

        private void CargarPDF(string ruta)
        {
            try
            {
                pdfViewer.Document?.Dispose(); // Liberar documento anterior si hay uno cargado
                pdfViewer.Document = PdfDocument.Load(ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelWeb.LinkVisited = true;
            System.Diagnostics.Process.Start("https://cescristorey.com/");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbUsuario.Text = "";
            tbContrasenia.Text = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String usuario = tbUsuario.Text;
            String contrasenia = tbContrasenia.Text;

            if (usuario.Equals("admin") && contrasenia.Equals("admin"))
            {
                modoAdmin = true;
                MessageBox.Show("Bienvenido usuario admin", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //logo 
            panelBienvenida.Visible = true;
            panelIniciosesion.Visible = false;
            panelInteres.Visible = false;
            panelPersonal.Visible = false;
            panelPlanos.Visible = false;
            panelFormulario.Visible = false;
            panelPDF.Visible = false;

        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            panelBienvenida.Visible = false;
            panelIniciosesion.Visible = false;
            panelInteres.Visible = false;
            panelPersonal.Visible = true;
            panelPlanos.Visible = false;
            panelFormulario.Visible = false;
            panelPDF.Visible = false;
        }

        private void buttonPlanos_Click(object sender, EventArgs e)
        {
            panelBienvenida.Visible = false;
            panelIniciosesion.Visible = false;
            panelInteres.Visible = false;
            panelPersonal.Visible = false;
            panelPlanos.Visible = true;
            panelFormulario.Visible = false;
            panelPDF.Visible=false;
        }

        private void buttonInteres_Click(object sender, EventArgs e)
        {
            panelBienvenida.Visible = false;
            panelIniciosesion.Visible = false;
            panelInteres.Visible = true;
            panelPersonal.Visible = false;
            panelPlanos.Visible = false;
            panelFormulario.Visible = false;
            panelPDF.Visible=false;
        }

        private void linkLabelAlbaicin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelAlbaicin.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.viajeroscallejeros.com/que-ver-en-el-albaicin-granada/#:~:text=16%20lugares%20que%20ver%20en%20el%20Albaic%C3%ADn%20%28Granada%29,...%207%207.%20Plaza%20Larga%20...%20M%C3%A1s%20elementos");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            panelBienvenida.Visible = false;
            panelIniciosesion.Visible = true;
            panelInteres.Visible = false;
            panelPersonal.Visible = false;
            panelPlanos.Visible = false;
            panelFormulario.Visible = false;
            panelPDF.Visible=false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("natalia.serantes17@gmail.com"); //remitente
                mail.To.Add("nataliaserantescortez@gmail.com"); //destinatario
                mail.Subject = "Nueva Sugerencia";
                mail.Body = $"Nombre: {tbNombre.Text}\n" +
                            $"Correo: {tbCorreo.Text}\n" +
                            $"Mensaje:\n{tbMensaje.Text}";
                mail.IsBodyHtml = false;

                // Configuración del servidor SMTP
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("natalia.serantes17@gmail.com", "mbak agdo sekc fovo");
                smtp.EnableSsl = true;

                // Enviar el correo
                smtp.Send(mail);
                MessageBox.Show("Sugerencia enviada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
    
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbCorreo.Text = "";
            tbMensaje.Text = "";
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            panelBienvenida.Visible = false;
            panelIniciosesion.Visible = false;
            panelInteres.Visible = false;
            panelPersonal.Visible = false;
            panelPlanos.Visible = false;
            panelFormulario.Visible = true;
            panelPDF.Visible = false;
        }

        private void buttonNormas_Click(object sender, EventArgs e)
        {
            panelBienvenida.Visible = false;
            panelIniciosesion.Visible = false;
            panelInteres.Visible = false;
            panelPersonal.Visible = false;
            panelPlanos.Visible = false;
            panelFormulario.Visible = false;
            panelPDF.Visible = true;

            if (modoAdmin)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Archivos PDF|*.pdf",
                    Title = "Seleccionar un archivo PDF"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaPDF = openFileDialog.FileName;
                    CargarPDF(openFileDialog.FileName);
                }
            } else
            {
                CargarPDF(rutaPDF);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (modoAdmin)
            {
                modoAdmin = false;
                MessageBox.Show("Hasta pronto usuario admin", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No hay ningún usuario conectado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
