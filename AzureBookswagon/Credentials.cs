using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureBookswagon
{
   public class Credentials
    {
        public string email = "";
        public string password = "";
        public string json = "";
        public string sendPassword = "";
        public string recEmail = "";

        /// <summary>
        /// create Credentials constructor
        /// </summary>
        public Credentials()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string uptobinpath = path.Substring(0, path.LastIndexOf("bin"))  + "Amitswaraj.json";
            string localPath = new Uri(uptobinpath).LocalPath;
            using (StreamReader r = new StreamReader(localPath))
            {
                json = r.ReadToEnd();
            }
            dynamic array = JsonConvert.DeserializeObject(json);
            Console.WriteLine("Array::::" + array["email"]);
            email = array["email"];
            password = array["password"];
            sendPassword = array["sender-password"];
            recEmail = array["receiver-email"];
        }
    }
}
