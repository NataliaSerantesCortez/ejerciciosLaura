using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class CuentaAhorro : Cuenta
    {
        //atributos
        private double cuotaMantenimiento;

        //propiedad
        public double CuotaMantenimiento { get => cuotaMantenimiento; set => cuotaMantenimiento = value; }

        //metodo
        public void mostrarEstado()
        {
           base.mostrarEstado();
            Console.WriteLine("Cuota Mantenimiento: " + this.CuotaMantenimiento + " euros");
        }
    }
}
