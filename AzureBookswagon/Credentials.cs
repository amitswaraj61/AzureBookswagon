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
            using (StreamReader r = new StreamReader("E:\\Amitswaraj.json"))
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
