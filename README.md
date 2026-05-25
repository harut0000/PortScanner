
# Local Port Scanner (C#)

## Projektübersicht
Dieses Projekt ist ein objektorientiertes Lernprojekt in C#.
Ziel ist die Entwicklung eines einfachen, funktionierenden Port-Scanners
für das lokale Netzwerk (z. B. localhost), mit Fokus auf sauberes OOP-Design.

Der Scanner prüft TCP-Ports und erkennt, ob diese offen oder geschlossen sind.

## Projektstatus
✅ Grundlegende Architektur abgeschlossen  
✅ Funktionierender TCP-Port-Scan (lokal)  
🚧 Erweiterungen (Performance, Ausgabe, Komfort) optional

## Architektur & Klassenübersicht

### Port
Repräsentiert einen einzelnen Netzwerkport.

Eigenschaften:
- Portnummer
- Status (Offen, Geschlossen, Unbekannt)

Besonderheiten:
- Status ist von außen nur lesbar
- Änderungen erfolgen kontrolliert über Methoden

### Target
Repräsentiert das Ziel eines Scans.

Eigenschaften:
- Adresse (z. B. 127.0.0.1)
- Optionaler Anzeigename

Ein Target enthält keine Logik und dient nur als Datenobjekt.

### ScanResult
Speichert das Ergebnis eines Scans.

Enthält:
- Das gescannte Target
- Eine Liste aller geprüften Ports

Das ScanResult verwaltet die Ports selbst und schützt seine Daten
durch Kapselung.

### Scanner
Führt den eigentlichen Scan durch.

Aufgaben:
- Iteration über einen Portbereich
- Prüfen der Ports per TCP-Verbindung
- Erstellen und Befüllen eines ScanResult-Objekts

Der Scanner besitzt keinen eigenen Zustand und arbeitet rein funktional.

## OOP-Prinzipien
- Kapselung (private set, kontrollierte Methoden)
- Trennung von Verantwortung (Single Responsibility)
- Klare Objektbeziehungen
- Keine globale Zustände

