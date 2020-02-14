using System;

namespace CalculadoraDeSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            string mes;

            Console.WriteLine("Dia de nascimento: ");
            dia = Console.ReadLine();

            Console.WriteLine("Mes do nascimento: ");
            mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;

            try
            {
              diaInt = Convert.ToInt32(dia);
              mesInt = Convert.ToInt32(mes);
            }
            catch (FormatException e)
            {
              Console.Write(e.Message);
              Console.ReadLine();
              Environment.Exit(1);
            }

            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.interpretar(diaInt, mesInt);

            if (signo != null)
            {
              Console.WriteLine("Seu Signo é: "+signo.nome);
              Console.WriteLine("Caracteristicas: "+ signo.caracteristicas);
            } else
            {
              Console.WriteLine("Não foi possivel interpretar seu signo!");
            }
            Console.ReadLine();
        }
    }
}

