using PortScanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets; // Für das Scanning
using System.Text;
using System.Threading.Tasks;

namespace PortScanner
{
    public class Scanner
    {
        public ScanResult Scan(Target target, int startPort, int endPort)
        {
            ScanResult result = new ScanResult(target);
            for (int portNummer = startPort; portNummer <= endPort; portNummer++)
            {
                Port port = new Port(portNummer);

                try // dieses Teil ist mit Copilot generiert. Hier wird es versucht, jeden einzelnen Port mit einer TCP-Verbindung zu pingen.
                {
                    using (TcpClient client = new TcpClient())
                    {
                        Console.WriteLine($"Prüfe Port {portNummer}..."); //live-Ausgabe vom Scanning (Wichtig, sonst keine Informationen, dass das Program funktioniert.)
                        client.Connect(target.Adresse, portNummer);
                        port.SetStatus(PortStatus.Offen);
                        
                    }
                }
                catch
                {
                    port.SetStatus(PortStatus.Geschlossen);
                }
                result.AddPort(port);
            }
            return result;
        }

    }
}
