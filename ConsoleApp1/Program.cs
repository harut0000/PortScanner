using System;
namespace PortScanner;
class Program
{
    static void Willkommen()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"");

        Console.WriteLine(@"██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗");
        Console.WriteLine(@"██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝");
        Console.WriteLine(@"██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗  ");
        Console.WriteLine(@"██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝  ");
        Console.WriteLine(@"╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗");
        Console.WriteLine(@" ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝");

        Console.WriteLine();

        Console.WriteLine(@"████████╗ ██████╗ ");
        Console.WriteLine(@"╚══██╔══╝██╔═══██╗");
        Console.WriteLine(@"   ██║   ██║   ██║");
        Console.WriteLine(@"   ██║   ██║   ██║");
        Console.WriteLine(@"   ██║   ╚██████╔╝");
        Console.WriteLine(@"   ╚═╝    ╚═════╝ ");

        Console.WriteLine();

        Console.WriteLine(@"██████╗  ██████╗ ██████╗ ████████╗███████╗ ██████╗ █████╗ ███╗   ██╗███╗   ██╗███████╗██████╗ ");
        Console.WriteLine(@"██╔══██╗██╔═══██╗██╔══██╗╚══██╔══╝██╔════╝██╔════╝██╔══██╗████╗  ██║████╗  ██║██╔════╝██╔══██╗");
        Console.WriteLine(@"██████╔╝██║   ██║██████╔╝   ██║   ███████╗██║     ███████║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝");
        Console.WriteLine(@"██╔═══╝ ██║   ██║██╔══██╗   ██║   ╚════██║██║     ██╔══██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗");
        Console.WriteLine(@"██║     ╚██████╔╝██║  ██║   ██║   ███████║╚██████╗██║  ██║██║ ╚████║██║ ╚████║███████╗██║  ██║");
        Console.WriteLine(@"╚═╝      ╚═════╝ ╚═╝  ╚═╝   ╚═╝   ╚══════╝ ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝");

        Console.ResetColor(); // * "Welcome to portscanner" ist generiert mit ChatGPT

        Console.ReadKey();
    }
}