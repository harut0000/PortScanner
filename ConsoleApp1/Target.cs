using PortScanner;
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
       public string Name { get; private set; } // get - ablesbar. private set - von außen nicht überschreibbar.
        public string Adresse { get; private set; } // get - ablesbar. private set - von außen nicht überschreibbar.
        public Target(string target_name, string target_adresse) // Jeder Target bekommt einen Namen und eine Adresse.
        {
            Name = target_name;
            Adresse = target_adresse;
        }



    }
}