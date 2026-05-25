using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortScanner
    
{
    public enum PortStatus { Offen, Geschlossen, Unbekannt }
    
        public class Port
        {
            
            public int Nummer { get; private set; } //private: das Port darf nur lesbar sein, nicht überschreibbar.
            public PortStatus Status { get; private set; } //Konstruktor
            public Port(int nummer) // Methode, die jedem Port eine Nummer und eine Status gibt.
            {
                Nummer = nummer;
                Status = PortStatus.Unbekannt;

            }
            public void SetStatus(PortStatus status)
            {
                Status = status;
            }
        }

    }

