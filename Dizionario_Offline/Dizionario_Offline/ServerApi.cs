using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dizionario_Offline
{
    class ServerApi
    {

        private string urlGetAuth = "/getAuth.php";

        /*
         * Legge il JSON e invia il risultato del campo response
         */
        public Boolean getResponseByJson(string json)
        {
            return true;
        }

        public Boolean getAuth(string key) {
            string url = this.urlGetAuth;

            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.ContentType = "application/x-www-form-urlencoded";

            string data = "key=" + key;

            using (StreamWriter streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                return getResponseByJson(result);
            }

            Console.WriteLine(httpResponse.StatusCode);

        }

        /**
         * Questa funzione e' implementata solo a scopo di testing in 
         * quanto assumiamo che il risultato della chiamata e' True 
         * perche' non possiamo testare l'api in un server pubblico
         */
        public Boolean getAuthFree(string key) {
            if (key != null)
            {
                return true;
            }
            else {
                return false;
            }
        }

    }
}
