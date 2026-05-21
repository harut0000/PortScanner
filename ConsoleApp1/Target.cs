using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Erstelle eine Klasse Target mit:
//🔹 Properties

//Address(string)

//public get
//private set


//Name(string)

//public get
//private set



//🔹 Konstruktor

//mindestens ein Parameter: address
//optional: name
//setzt die Properties sinnvoll

//🔹 Regeln

//❌ keine Scanner‑Logik
//❌ keine Methoden außer Konstruktor
//✅ saubere Kapselung
//✅ eigene Datei Target.cs (empfohlen)
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