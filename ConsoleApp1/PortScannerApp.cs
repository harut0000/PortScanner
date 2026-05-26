using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//diese Klasse ist dafür zuständig, alle anderen Klassen ins funktionsfähigen Programm umzuwandeln.

using System;

namespace PortScanner
   
{
    internal class PortScannerApp
    {
        static void Main(string[] args)

        {
            Program.Willkommen();
            Console.ForegroundColor = ConsoleColor.Green; //26.05.2026 // der Text in der Konsole MUSS grün sein.
            Console.WriteLine("Herzlich willkommen!");
            Console.WriteLine("Bitte wählen Sie die Scan-Variante:");
            Console.WriteLine("1 - Scan von Ports 1 bis 1024");
            Console.WriteLine("2 - Scan von Standardports (22, 80, 443, 3389 etc.)");

            int auswahl = int.Parse(Console.ReadLine());

            Target target = new Target("Localhost", "127.0.0.1");
            Scanner scanner = new Scanner();
            ScanResult result;
            Dictionary<int, string> portServices = new Dictionary<int, string>() //Copilot-generiert (Anfang)
{
    { 21, "FTP" },
    { 22, "SSH" },
    { 23, "Telnet" },
    { 25, "SMTP" },
    { 53, "DNS" },
    { 80, "HTTP" },
    { 110, "POP3" },
    { 143, "IMAP" },
    { 443, "HTTPS" },
    { 445, "SMB" },
    { 3389, "RDP" }
}; // Copilot generiert (Ende)

            switch (auswahl)
            {
                case 1:
                    result = scanner.Scan(target, 1, 1024);
                    break;

                case 2:





               



                    int[] commonPorts = new int[]
                    {
        21,   // FTP
        22,   // SSH
        23,   // Telnet
        25,   // SMTP
        53,   // DNS (TCP)
        80,   // HTTP
        110,  // POP3
        143,  // IMAP
        443,  // HTTPS
        445,  // SMB
        3389  // RDP
                    };

                    result = scanner.ScanSelectedPorts(target, commonPorts);
                    break;


                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    return;
            }
  

            Console.WriteLine($"\nScan-Ergebnis für: {target.Name} ({target.Adresse})\n");

            foreach (Port port in result.Ports)
            {

                //Copilot-generiert: Anfang
                string serviceName = portServices.ContainsKey(port.Nummer)
                    ? portServices[port.Nummer]
                    : "Unbekannter Dienst";


                Console.WriteLine($"Port {port.Nummer} ({serviceName}): {port.Status}");
            }
            //Copilot-generiert: Ende

            Console.WriteLine("\nScan abgeschlossen. Taste drücken zum Beenden.");
            Console.ReadKey();
        }
    }
}

