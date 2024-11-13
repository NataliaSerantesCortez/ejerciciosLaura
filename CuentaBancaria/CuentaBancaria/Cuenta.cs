using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class Cuenta
    {
        //atributos
        private String numCuenta;
        private String nombre;
        private double saldo;
        private double tipoInteres;

        //propiedades
        public string NumCuenta { get => numCuenta; set => numCuenta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double TipoInteres { get => tipoInteres; set => tipoInteres = value; }

        //metodos
        public void mostrarEstado()
        {
            Console.WriteLine("Número Cuenta: " + this.NumCuenta);
            Console.WriteLine("Nombre Cliente: " + this.Nombre);
            Console.WriteLine("Saldo Cuenta: " + this.Saldo + " euros");
            Console.WriteLine("Tipo de Interes: " + this.TipoInteres + " %");

        }

    }
}
