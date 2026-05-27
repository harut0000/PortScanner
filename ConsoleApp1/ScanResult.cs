using System;
using PortScanner;
namespace PortScanner
{
    public class ScanResult
    {


        public Target Target { get; private set; }
        public List<Port> Ports { get; private set; }

        public ScanResult(Target target)
        {
            Target = target;
            Ports = new List<Port>();
        }

        public void AddPort(Port port)
        {
            Ports.Add(port);
        }

    

    }
}

