using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//diese Klasse ist dafür zuständig, alle anderen Klassen ins funktionsfähigen Programm umzuwandeln.

using System;
using System.Data;

namespace PortScanner
   
{
    internal class PortScannerApp
    {
        static void Main(string[] args)

        {
            Program.Willkommen();
            Console.ForegroundColor = ConsoleColor.Green; //26.05.2026 // der Text in der Konsole MUSS grün sein.
            Console.WriteLine("PortScanner v. 1.0");
            Console.WriteLine("by harut0000");
            Console.WriteLine("");
            Console.WriteLine("");
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
            DateTime startTime = DateTime.Now;
            switch (auswahl)
            {
                case 1:
                    result = scanner.Scan(target, 1, 1024);
                    break;

                case 2:
                    startTime = DateTime.Now;








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
                

                if (port.Status == PortStatus.Offen)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                //Copilot-generiert: Anfang
                string serviceName = portServices.ContainsKey(port.Nummer)
                    ? portServices[port.Nummer]
                    : "Unbekannter Dienst";


                Console.WriteLine($"Port {port.Nummer} ({serviceName}): {port.Status}");
            }

            //Copilot-generiert: Ende

            DateTime endTime = DateTime.Now;
            TimeSpan duration = endTime - startTime;

            int openPorts = result.Ports.Count(p => p.Status == PortStatus.Offen); //Lambda
            int closedPorts = result.Ports.Count(p => p.Status == PortStatus.Geschlossen);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n--- Zusammenfassung ---");
            Console.WriteLine($"Offene Ports: {openPorts}");
            Console.WriteLine($"Geschlossene Ports: {closedPorts}");
            Console.WriteLine($"Gesamt geprüft: {result.Ports.Count}");
            Console.WriteLine($"Scan-Dauer: {duration.TotalSeconds:F1} Sekunden");


            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            
            Console.WriteLine("\nScan abgeschlossen. Taste drücken zum Beenden.");
            

            Console.WriteLine("");
            Console.WriteLine("                             .::---==========---:.                              ");
            Console.WriteLine("                    .-++*#%%%%%%%%%%%%%%%%%%%%%%%%%%%#**+=:.                    ");
            Console.WriteLine("             .:++*##%#%%##***+********++**********+***##%%#%##*++:.              ");
            Console.WriteLine("       .:=**##%#%###**#####*********+=-=--=+*********#####**###%#%##*+=:.        ");
            Console.WriteLine("  .:+*##%##%#**##%%%%%%%%######****=-==**-=-=****######%%%%%%%%###*####%#**=..   ");
            Console.WriteLine(" .*###***#**#%%%%%%%%%%%%%#######****=-=---****#######%%%%%%%%%%%%#**##*+*###*.  ");
            Console.WriteLine("     .::-===+******+*###%%%%##########****##########%%%###******#*++==--:..      ");
            Console.WriteLine("                  .:=++**#****************************#**++-:.                  ");
            Console.WriteLine("                          :-==++**+++**###*****+=++=-...               ");
            Console.ReadKey();
        }
    }
}

