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

    }
}
