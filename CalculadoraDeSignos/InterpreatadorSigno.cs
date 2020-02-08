using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeSignos
{
    class InterpreatadorSigno
    {
        public Signo interpretar(int dia, int mes)
        {
            Signo signo = new null;

            if ((dia >= 19 && mes == 2) || (dia >= 20 && mes == 3)) 
            {
                signo = new Signo();
                signo.nome = "Peixes";
            }

            return signo;
        }
    }
}
