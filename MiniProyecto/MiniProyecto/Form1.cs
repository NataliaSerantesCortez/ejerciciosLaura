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

namespace MiniProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*PrivateFontCollection pfc = new PrivateFontCollection();
            byte[] fontData = Properties.Resources.dosis_semibold__allfont_es_; 
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            pfc.AddMemoryFont(fontPtr, fontData.Length);

            label1.Font = new Font(pfc.Families[0], 12);*/

            PrivateFontCollection pfc = new PrivateFontCollection();

            // Obtener los bytes de la fuente desde los recursos
            byte[] fontData = Properties.Resources.dosis_semibold__allfont_es_; // Usa el nombre exacto del recurso

            // Reservar memoria para la fuente
            IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
            Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

            // Agregar la fuente a la colección
            pfc.AddMemoryFont(fontPtr, fontData.Length);

            // Liberar la memoria asignada
            Marshal.FreeCoTaskMem(fontPtr);

            // Aplicar la fuente a un Label u otro control
            labelTitulo.Font = new Font(pfc.Families[0], 12);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
