
# Local Port Scanner (C#)

## Projektbeschreibung
Dieses Projekt ist ein Lernprojekt zur objektorientierten Programmierung (OOP) in C#.
Ziel ist es, schrittweise einen lokalen Port-Scanner aufzubauen und dabei sauberes
OOP-Design zu üben (Klassen, Kapselung, Konstruktoren, Verantwortlichkeiten).

## Projektstatus
🚧 Work in Progress  
Das Projekt wird Schritt für Schritt aufgebaut. Aktuell liegt der Fokus auf dem
sauberen Modellieren der Kernobjekte, nicht auf echter Netzwerktechnik.

## Klasse: Port
Die Klasse `Port` repräsentiert einen einzelnen Netzwerkport.

Ein Port:
- hat eine feste Portnummer
- besitzt einen Status (Offen, Geschlossen, Unbekannt)
- kontrolliert seinen eigenen Zustand

Die Portnummer kann nach der Erstellung nicht mehr geändert werden.
Der Status ist von außen nur lesbar und kann ausschließlich über eine Methode
gesetzt werden.

## OOP-Prinzipien
- **Kapselung:** Eigenschaften sind geschützt (`private set`)
- **Kontrollierte Zustände:** Änderungen erfolgen über Methoden
- **Enums statt Strings:** Klare, sichere Statuswerte
- **Single Responsibility:** Die Klasse `Port` ist nur für einen Port zuständig

Weitere Klassen (z. B. Target, ScanResult, Scanner) werden schrittweise ergänzt.
