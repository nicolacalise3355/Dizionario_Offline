using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizionario_Offline
{
    class Dizionario
    {

        private Dictionary<string, string> dizionario;

        public Dictionary<string, string> getDizionario()
        {
            return this.dizionario;
        }

        public void setDizionario(Dictionary<string, string> newD) {
            this.dizionario = newD;
        }

        public void resetDizionario()
        {
            this.dizionario = new Dictionary<string, string>();
        }

        public string getDesc(string parola)
        {
            string value;
            this.dizionario.TryGetValue(parola, out value);
            return value;
        }

        public void insertParola(string parola, string desc)
        {
            if (!this.dizionario.ContainsKey(parola))
            {
                this.dizionario.Add(parola, desc);
            }
        }

        public void printDizionario()
        {
            if(this.dizionario == null)
            {
                Console.WriteLine("Dizionario null");
                return;
            }
            Console.WriteLine("******DIZIONARIO******");
            foreach (KeyValuePair<string, string> entry in this.dizionario)
            {

                Console.WriteLine("Parola: " + entry.Key);
                Console.WriteLine("Significato: " + entry.Value);
                Console.WriteLine("--------------------------------");
            }
            Console.WriteLine("******FINE******");
        }

    }
}
