using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraAplicacion
{
    internal class clsCuentaBancaria
    {
        //Campos
        private string nombre, apellidos, direccion, rfc;
        private double saldo;

        //Constructor
        public clsCuentaBancaria(string nombrePa, string apellidosPa, double saldoPa, string direccionPa, string rfcPa)
        {
            nombre = nombrePa;
            apellidos = apellidosPa;
            saldo = saldoPa;
            direccion = direccionPa;
            rfc = rfcPa;
        }

        //Metodos
        public double Depositos(double montoPa)
        {
            saldo += montoPa;
            return saldo;
        }

        public double retiro(double montoPa)
        {
            if (saldo >= montoPa) 
            {
                saldo -= montoPa;
            }
            else
            {
                return -1; //Saldo insuficiente!!!!
            }
            return saldo;
        }

        public double ConsultaSaldo()
        {
            return saldo;
        }

        public override string ToString()
        {
            string mensaje;
            mensaje = "Titular: " + nombre + " " + apellidos + "\nRFC:" + rfc + "\nDirección " + direccion + "\nSaldo: $" + saldo;
            return mensaje;
        }
    }
}
