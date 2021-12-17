using System;
using System.Collections;

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
            Console.WriteLine("3) Cerca significato parola");
            Console.WriteLine("4) Ricerca parole per iniziale");
            Dizionario dict = new Dizionario();
            ServerApi sa = new ServerApi();
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
                        string verifica;
                        Console.WriteLine("Inserisci una chiave per autenticarti");
                        verifica = Console.ReadLine();
                        if (sa.getAuthFree(verifica)) //Funzione di controllo da cambiare quando si effettua l auth su un server vero
                        {
                            Console.WriteLine("Autenticazione ok");
                            Console.WriteLine("Inserisci prima la parola e dopo il significato");
                            parolaTmp = Console.ReadLine();
                            descrizioneTmp = Console.ReadLine();
                            dict.insertParola(parolaTmp, descrizioneTmp);
                        }
                        else
                        {
                            Console.WriteLine("Autenticazione fallita!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("2 - Visualizza tutto il dizionario");
                        dict.printDizionario();
                        break;
                    case 3:
                        Console.WriteLine("3 - Ricerca del significato di una parola");
                        string parola;
                        Console.WriteLine("Inserisci il nome della parola");
                        parola = Console.ReadLine();
                        string res = dict.findParola(parola);
                        if (res.Equals(""))
                        {
                            Console.WriteLine("Parola non trovata");
                        }
                        else
                        {
                            Console.WriteLine("Parola " + parola + " Trovata, Significato: ");
                            Console.WriteLine(res);
                        }
                        break;
                    case 4:
                        Console.WriteLine("4 - Ricerca parole per iniziale");
                        string lettera;
                        Console.WriteLine("Inserisci la lettera");
                        lettera = Console.ReadLine();
                        Console.WriteLine("Letta inserita -> " + lettera);
                        ArrayList listaParola = dict.FindFromChar(lettera[0]);  //Gestione nel caso in cui non si trova niente 
                        for(int i = 0; i < listaParola.Count; i++)
                        {
                            Console.WriteLine(listaParola[i]);
                        }
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
