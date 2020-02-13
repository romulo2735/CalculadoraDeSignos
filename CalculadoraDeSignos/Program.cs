using System;

namespace CalculadoraDeSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            String dia;
            String mes;

            Console.WriteLine("Dia de nascimento: ");
            dia = Console.ReadLine();

            Console.WriteLine("Mẽs do nascimento: ");
            mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;

            try
            {
              diaInt = Convert.ToInt32(diaInt);
              mesInt = Convert.ToInt32(mesInt);
            }
            catch (FormatException e)
            {
              Console.Write(e.Message);
              Console.ReadLine();
              Environment.Exit(1);
            }

            InterpreatadorSigno interpreatador = new InterpreatadorSigno();
            Signo signo = interpreatador.interpretar(diaInt, mesInt);

            if (signo != null)
            {
              Console.WriteLine("Seu Signo é: "+signo.nome+" "+signo.caracteristicas);
            } else
            {
              Console.WriteLine("Não foi possivel interpretar seu signo!");
            }
            Console.ReadLine();
        }
    }
}

