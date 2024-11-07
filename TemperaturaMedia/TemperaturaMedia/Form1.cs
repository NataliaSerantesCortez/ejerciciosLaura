using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperaturaMedia
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
            double temperaturaMedia = 0.0;
            
            int temperaturaLunes = (int) nbLunes.Value;
            int temperaturaMartes = (int)nbMartes.Value;
            int temperaturaMiercoles = (int)nbMiercoles.Value;
            int temperaturaJueves = (int)nbJueves.Value;
            int temperaturaViernes = (int)nbViernes.Value;
            int temperaturaSabado = (int)nbSabado.Value;
            int temperaturaDomingo = (int)nbDomingo.Value;

            temperaturaMedia = (temperaturaLunes + temperaturaMartes + temperaturaMiercoles
                + temperaturaJueves + temperaturaViernes + temperaturaSabado + temperaturaDomingo)/7.0;

            tfMedia.Text = "" + temperaturaMedia;
        }
    }
}
