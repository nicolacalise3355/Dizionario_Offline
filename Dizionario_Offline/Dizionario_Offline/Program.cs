using System;

namespace Dizionario_Offline
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEST 
            Console.WriteLine("Welcome");
            Console.WriteLine("Inserisci un numero");
            Console.WriteLine("1) Inserisci una parola");
            Console.WriteLine("2) Visualizza tutte le parole");
            Console.WriteLine("3) Cerca significato parolas");
            Console.WriteLine("4) Ricerca parole per iniziale");
            Dizionario dict = new Dizionario();
            dict.resetDizionario();

            int ciclo = 0;

            while (ciclo == 0)
            {
                int input = Int32.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("1 - Inserisci una parola nel dizionario");
                        string parolaTmp, descrizioneTmp;
                        Console.WriteLine("Inserisci prima la parola e dopo il significato");
                        parolaTmp = Console.ReadLine();
                        descrizioneTmp = Console.ReadLine();
                        dict.insertParola(parolaTmp, descrizioneTmp);
                        break;
                    case 2:
                        Console.WriteLine("2 - Visualizza tutto il dizionario");
                        dict.printDizionario();
                        break;
                    case 3:
                        Console.WriteLine("3");
                        break;
                    case 4:
                        Console.WriteLine("4");
                        break;
                    default:
                        ciclo = 1;
                        break;
                }
            }


            Console.WriteLine("end test");
            //-----------------------------------//

        }
    }
}
