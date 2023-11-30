using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glicose {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double medida;

            Console.Write("Digite a medida da glicose: ");
            medida = double.Parse(Console.ReadLine(), CI);

            if (medida <= 100) {
                Console.WriteLine("Classificaçao: normal.");
            }
            else if (medida > 100 && medida <= 140) {
                Console.WriteLine("Classificaçao: elevado.");
            }
            else {
                Console.WriteLine("Classificaçao: diabetes.");
            }

        }
    }
}
