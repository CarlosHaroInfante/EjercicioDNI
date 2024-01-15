using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDNI.Servicios
{
    internal class DNIimplementacion : DNIinterfaz
    {
        public long numDNI()
        {

            Console.WriteLine("Dame las letras de tu DNI");
            long num = Convert.ToInt64(Console.ReadLine());
            return num;
        }

        public char letDNI()
        {
            Console.WriteLine("Dame la letra de tu DNI");
            char letra = Convert.ToChar(Console.ReadLine());
            return letra;
        }
    }
}
