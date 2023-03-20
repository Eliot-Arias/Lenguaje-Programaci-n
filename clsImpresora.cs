using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraAplicacion
{
    public class clsImpresora
    {
        private static clsImpresora impresora;
        private int NumeroPaginas = 0;
        private clsImpresora()
        {
        }
        public static clsImpresora GetImpresora() 
        {
            return impresora == null ?
                impresora = new clsImpresora() :
                impresora;
        }
        public String print(String text)
        {
            return "Impresora ABC: " + text + "  " + ": número de páginas impresas hoy: " + NumeroPaginas++ + "\r\n";
        }
    }
}
