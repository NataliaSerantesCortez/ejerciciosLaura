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

namespace CuentaBancaria
{
    public partial class Form1 : Form
    {
        private BindingList<Cuenta> listaCuentas;
        public Form1()
        {
            InitializeComponent();

            listaCuentas = new BindingList<Cuenta>();

            Cuenta cuenta1 = new Cuenta();
            cuenta1.NumCuenta = "ES-1526-8596-2536";
            cuenta1.Nombre = "Natalia Serantes";
            cuenta1.Saldo = 2361.45;
            cuenta1.TipoInteres = 5;
            listaCuentas.Add(cuenta1);

            Cuenta cuenta2 = new Cuenta();
            cuenta2.NumCuenta = "ES-7600-0096-2536";
            cuenta2.Nombre = "Héctor Navas";
            cuenta2.Saldo = 4599.20;
            cuenta2.TipoInteres = 4.5;
            listaCuentas.Add(cuenta2);

            CuentaAhorro cuentaAhorro1 = new CuentaAhorro();
            cuentaAhorro1.NumCuenta = "ES-5947-0200-1484";
            cuentaAhorro1.Nombre = "Nahuel Serantes";
            cuentaAhorro1.Saldo = 156.32;
            cuentaAhorro1.TipoInteres = 10;
            cuentaAhorro1.CuotaMantenimiento = 23.99;
            listaCuentas.Add(cuentaAhorro1);

            CuentaAhorro cuentaAhorro2 = new CuentaAhorro();
            cuentaAhorro2.NumCuenta = "ES-755-0200-0084";
            cuentaAhorro2.Nombre = "Susana Cortez";
            cuentaAhorro2.Saldo = 1831.99;
            cuentaAhorro2.TipoInteres = 7.5;
            cuentaAhorro2.CuotaMantenimiento = 15.65;
            listaCuentas.Add(cuentaAhorro2);

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            cbCuentas.DataSource = listaCuentas;  
            cbCuentas.DisplayMember = "ToString";
        }

        private void cbCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta cuentaSeleccionada = (Cuenta)cbCuentas.SelectedItem;

            if (cuentaSeleccionada is CuentaAhorro cuentaAhorro)
            {
                cbCuentaAhorro.Checked = true;
                tfNumeroCuenta.Text = cuentaAhorro.NumCuenta;
                tfTitular.Text = cuentaAhorro.Nombre;
                tfSaldo.Text = cuentaAhorro.Saldo.ToString();
                tfInteres.Text = cuentaAhorro.TipoInteres.ToString();
                tfCuotaMantenimiento.Text = cuentaAhorro.CuotaMantenimiento.ToString();
            }
            else
            {
                cbCuentaAhorro.Checked = false;
                tfNumeroCuenta.Text = cuentaSeleccionada.NumCuenta;
                tfTitular.Text = cuentaSeleccionada.Nombre;
                tfSaldo.Text = cuentaSeleccionada.Saldo.ToString();
                tfInteres.Text = cuentaSeleccionada.TipoInteres.ToString();                
            }
        }

        private void cbCuentaAhorro_CheckedChanged(object sender, EventArgs e)
        {
            labelCuotaMantenimiento.Visible = cbCuentaAhorro.Checked;
            tfCuotaMantenimiento.Visible = cbCuentaAhorro.Checked;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            //los dejo vacios
            tfNumeroCuenta.Text = "";
            tfTitular.Text = "";
            tfSaldo.Text = "";
            tfInteres.Text = "";
            tfCuotaMantenimiento.Text = "";

            //habilito para poder escribir
            tfNumeroCuenta.ReadOnly = false;
            tfTitular.ReadOnly = false;
            tfSaldo.ReadOnly = false;
            tfInteres.ReadOnly = false;
            tfCuotaMantenimiento.ReadOnly = false;

            //habilito el check box de la opción cuenta de ahorror
            cbCuentaAhorro.Enabled = true;
            cbCuentaAhorro.Checked = false;

            //deshabilito el boton de nueva
            btnNueva.Enabled = false;
            btnNueva.Visible = false;

            //deshabilito combo box con la lista
            cbCuentas.Enabled = false;

            //habilito el boton de guardar
            imagenGuardar.Enabled = true;
            imagenGuardar.Visible = true;

            labelRegistro.Visible = false;
        }

        private void imagenGuardar_Click(object sender, EventArgs e)
        {
            String saldoString = tfSaldo.Text;
            double saldo;
            bool sePuedeConvertirSaldo;

            String interesString = tfInteres.Text;
            double interes;
            bool sePuedeConvertirInteres;

            String cuotaString = tfCuotaMantenimiento.Text;
            double cuota;
            bool sePuedeConvertirCuota;

            if (cbCuentaAhorro.Checked)
            {
                //asegurarme de que todos los campos esten rellenos
                if ( !tfNumeroCuenta.Text.Equals("") && !tfTitular.Text.Equals("") && 
                    !tfSaldo.Text.Equals("") && !tfInteres.Text.Equals("") &&
                    !tfCuotaMantenimiento.Text.Equals(""))
                {
                    //que se guarden numeros en los campos correspondientes                    
                    sePuedeConvertirSaldo = double.TryParse(saldoString.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out saldo);
                    sePuedeConvertirInteres = double.TryParse(interesString.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out interes);
                    sePuedeConvertirCuota = double.TryParse(cuotaString.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out cuota);

                    if ( sePuedeConvertirSaldo && sePuedeConvertirInteres && sePuedeConvertirCuota)
                    {
                        //guardar en un objeto
                        CuentaAhorro cuentaA = new CuentaAhorro();
                        cuentaA.NumCuenta = tfNumeroCuenta.Text;
                        cuentaA.Nombre = tfTitular.Text;
                        cuentaA.Saldo = saldo;
                        cuentaA.TipoInteres = interes;
                        cuentaA.CuotaMantenimiento = cuota;

                        //agregar a la lista
                        listaCuentas.Add(cuentaA);

                        //habilitar combo box de lista
                        cbCuentas.Enabled = true;

                        //deshabilitar el check box de la cuenta de ahorro
                        cbCuentaAhorro.Enabled = false;
                        cbCuentaAhorro.Checked = false;

                        //deshabilitar la imagen de guardar 
                        imagenGuardar.Enabled = false;
                        imagenGuardar.Visible = false;

                        //habilitar el boton de nueva
                        btnNueva.Enabled = true;
                        btnNueva.Visible = true;

                        //poner los campos a read only
                        tfNumeroCuenta.ReadOnly = true;
                        tfTitular.ReadOnly = true;
                        tfSaldo.ReadOnly = true;
                        tfInteres.ReadOnly = true;
                        tfCuotaMantenimiento.ReadOnly = true;

                        //volver a cargar formulario                 
                        cbCuentas.DataSource = listaCuentas;
                        cbCuentas.DisplayMember = "ToString";

                        labelRegistro.Visible = true;

                        //los dejo vacios
                        tfNumeroCuenta.Text = "";
                        tfTitular.Text = "";
                        tfSaldo.Text = "";
                        tfInteres.Text = "";
                        tfCuotaMantenimiento.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Los campos saldo, interés y cuota de mantenimiento son númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //asegurarme de que todos los campos esten rellenos
                if (!tfNumeroCuenta.Text.Equals("") && !tfTitular.Text.Equals("") &&
                    !tfSaldo.Text.Equals("") && !tfInteres.Text.Equals("") )
                {
                    //que se guarden numeros en los campos correspondientes
                    sePuedeConvertirSaldo = double.TryParse(saldoString.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out saldo);
                    sePuedeConvertirInteres = double.TryParse(interesString.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out interes);

                    if (sePuedeConvertirSaldo && sePuedeConvertirInteres)
                    {
                        //guardar en un objeto
                        Cuenta cuenta = new Cuenta();
                        cuenta.NumCuenta = tfNumeroCuenta.Text;
                        cuenta.Nombre = tfTitular.Text;
                        cuenta.Saldo = saldo;
                        cuenta.TipoInteres = interes;               

                        //agregar a la lista
                        listaCuentas.Add(cuenta);                   

                        //habilitar combo box de lista
                        cbCuentas.Enabled = true;

                        //deshabilitar el check box de la cuenta de ahorro
                        cbCuentaAhorro.Enabled = false;
                        cbCuentaAhorro.Checked = false;

                        //deshabilitar la imagen de guardar 
                        imagenGuardar.Enabled = false;
                        imagenGuardar.Visible = false;

                        //habilitar el boton de nueva
                        btnNueva.Enabled = true;
                        btnNueva.Visible = true;

                        //poner los campos a read only
                        tfNumeroCuenta.ReadOnly = true;
                        tfTitular.ReadOnly = true;
                        tfSaldo.ReadOnly = true;
                        tfInteres.ReadOnly = true;
                        tfCuotaMantenimiento.ReadOnly = true;

                        //volver a cargar formulario               
                        cbCuentas.DataSource = listaCuentas;
                        cbCuentas.DisplayMember = "ToString";

                        labelRegistro.Visible = true;

                        //los dejo vacios
                        tfNumeroCuenta.Text = "";
                        tfTitular.Text = "";
                        tfSaldo.Text = "";
                        tfInteres.Text = "";
                        tfCuotaMantenimiento.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Los campos saldo e interés son númericos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           

        }
    }
}
