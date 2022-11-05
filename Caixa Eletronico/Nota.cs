using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico
{
    internal class Nota
    {
        public int Nota2;
        public int Nota5;
        public int Nota10;
        public int Nota20;
        public int Nota100;

        public Nota(int nota2, int nota5, int nota10, int nota20, int nota100)
        {

            Nota2 = 2;
            Nota5 = 5;
            Nota10 = 10;
            Nota20 = 20;
            Nota100 = 100;

        }
    }
}
