using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//diese Klasse ist dafür zuständig, alle anderen Klassen ins funktionsfähigen Programm umzuwandeln.
namespace PortScanner
{
    internal class PortScannerApp
    {
        static void Main(string[] args) // Startet das Programm, kein Objekt ist nötig und nichts wird zurückgegeben.
        {
            Target target = new Target("Localhost", "127.0.0.1"); //Das Ziel Target wird gescannt.
            Scanner scanner = new Scanner(); //Dieser Scanner führt das Scanning aus.
            ScanResult result = scanner.Scan(target, 8080, 8080); //Startet das Scanning. Prüft TCP-Ports, erstellt ein ScanResult und gibt das Ergebnis zurück.
            Console.WriteLine($"Scan-Ergebnis für: {result.Target.Name} ({result.Target.Adresse})\n"); // result mit Target und Eigenschaften Name und Adresse.

            foreach (Port port in result.Ports) //das Ergebnis für alle Ports ablesen.
            {
                Console.WriteLine($"Port {port.Nummer}: {port.Status}");
            }
            Console.ReadKey();

        }
    }
}
