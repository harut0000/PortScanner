using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PortScanner
{
    public class Target
    {
       public string Name { get; private set; }
        public string Adresse { get; private set; }
        public Target(string target_name, string target_adresse)
        {
            Name = target_name;
            Adresse = target_adresse;
        }
        Target t = new Target("localhost", "127.0.0.1");


    }
}