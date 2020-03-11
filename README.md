# M318 SwissTransport API

## Einleitung
### Aufgabenstellung
Unsere Aufgabe ist es eine Desktop Applikation mit Hilfe der Transport API zu Programmieren. Wir haben mehrere Anforderungen bekommen, die nach Wichtigkeit priorisiert sind. Uns ist es selber überlasen welche wir umsetzten möchten doch sollten die Anforderungen mit Priorität 1 auf jeden Fall umgesetzt werden. Mein Ziel ist es bis zur Abgabe ein fertiges Programm zu haben und die Code Konventionen einzuhalten. Auch möchte ich Die Anforderung mit Priorität 1 und 2 abgeschlossen haben.
### Anforderung
| ID   | Beschreibung  | Priorität |
| -----|:-------------:| -----:|
| A001 | Als ÖV-Benutzer möchte ich Start- und Endstation mittels Textsuche suchen können, damit ich nicht alle Stationsnamen auswendig lernen muss. | 1 |
| A002 | Als ÖV-Benutzer möchte ich die aktuellen, d.h. mindestens die nächsten vier bis fünf Verbindungen zwischen den beiden gefundenen und ausgewählten Stationen sehen, damit ich weiss wann ich zur Station muss, um den für mich idealen Anschluss zu erwischen.| 1 |
| A003 | Als ÖV-Benutzer möchte ich sehen, welche Verbindungen ab einer bestimmten Station vorhanden sind, damit ich bei mir zuhause eine Art Abfahrtstafel haben kann. | 1 |
| A004 | Als ÖV-Benutzer möchte ich, dass schon während meiner Eingabe erste Such-Resultate erscheinen, damit ich effizienter nach Stationen suchen kann. | 2 |
| A005 | ALs ÖV-Benutzer möchte ich nicht nur aktuelle Verbindungen suchen können, sondern auch solche zu einem beliebigen anderen Zeitpunkt, damit ich zukünftige Reisen planen kann. | 2 |
| A006 | Als ÖV-Benutzer möchte ich sehen, wo sich eine Station befindet, damit ich mir besser vorstellen kann, wie die Situation vor Ort aussieht. | 3 |
| A007 | Als ÖV-Benutzer möchte Stationen finden, die sich ganz in der Nähe meiner aktuellen Position befinden, damit ich schnell einen Anschluss erreichen kann. | 3 |
| A008 | Ich möchte meine gefundenen Resultate via Mail weiterleiten können, damit  auch andere von meinen Recherchen profitieren können. | 3 |
### Zweck
Die Dokumentation dient dazu die Projektarbeit im Rahmen des ÜK 318 zu dokumentieren. Das Dokument enthält die Planung, allgemeine Informationen über das Projekt und das Testing der Applikation. Auch ist eine Installationsanleitung am Ende des Dokumentes enthalten.
## Funktionen
## Bugs
## Planung
### Usecase
| USE CASE | 1, START- & END-STATION SUCHEN  |
| -----|--------------|
|BESCHREIBUNG|Damit der User sich keine Stationen merken muss kann er nach Stationen suchen. Die suche muss über eine Texteingabe erfolgen. Es werden auch schon Stationen angezeigt, wenn der Name noch nicht den ganzen Namen eingegeben hat.|
|AKTEUR|SBB User|
|AUSLÖSER|SBB User möchte, Namen der Station wissen und nicht selber auswendig lernen.|
|VOBEDINGUNGEN|Internetverbindung|
|ABLAUF| <ol><li>User öffnet Programm</li><li>User klickt entweder auf «Abfahrstafel» oder «Verbindungen anzeigen»</li><li>User gibt Namen von Station ein.</li><li>User klickt auf Suchen</li><li>User bekommt Resultat auch wenn er nicht den kompletten Namen eingegeben hat</li></ol> |
|ERGEBNIS|Stationen werden trotzdem gefunden auch wenn der User nicht den Kompletten Namen eingegeben hat. z.B. Meierskappel wird zu Meierskappel Dorfplatz.|

| USE CASE | 1, VERBINDUNGEN ANZEIGEN  |
| -----|--------------|
|BESCHREIBUNG|Dem User werden die nächsten 5 Verbindungen zwischen der Start- und End-Station angezeigt|
|AKTEUR|SBB User|
|AUSLÖSER|SBB User möchte, die wissen was die besten Verbindungen zwischen den eingegebenen Stationen wissen.|
|ABLAUF| <ol><li>User öffnet Programm</li><li>User klickt entweder auf «Verbindungen anzeigen»</li><li>User gibt Namen von Start- und Endstation ein.</li><li>User klickt auf Verbindungen anzeigen</li><li>User bekommt Liste mit den 5 nächsten Verbindungen zwischen den 2 Stationen angezeigt.</li></ol> |
|ERGEBNIS|User bekommt Liste mit den 5 nächsten Verbindungen zwischen den 2 Stationen angezeigt.|

| USE CASE | 1, ABFAHRTSTAFEL |
| -----|--------------|
|BESCHREIBUNG|Dem User werden alle Anschlussmöglichkeiten einer Station angezeigt. Es sollen alle Verbindungen, egal in welche Richtung, welche an dieser Station anhalten angezeigt werden|
|AKTEUR|SBB User|
|AUSLÖSER|SBB User möchte alle Verbindungen einer Station in alle Richtungen wissen.|
|VOBEDINGUNGEN|Internetverbindung|
|ABLAUF| <ol><li>User öffnet Programm</li><li>User klickt entweder auf «Abfahrstafel»</li><li>User gibt Namen von Startstation ein.</li><li>User klickt auf Abfahrstafel anzeigen</li><li>User bekommt Liste mit den nächsten Verbindungen die von der eingegeben Stationen ausgehen angezeigt.</li></ol> |
|ERGEBNIS|User bekommt Liste mit den nächsten Verbindungen die von der eingegeben Stationen ausgehen angezeigt. Die Tafel funktioniert genauso wie die Tafel die an den Bahnhöfen stehen.|

## Programmierrichtlinen
### Namensgebung
| Stelle | Regel | Beispiel |
|-----|--------------|-------|
|Allgemein|Englische Bezeichnungen, aussagen was für Zweck sie haben.| |
|Variabel|CamelCase, Lokale und Membervariabel werden nicht unterschieden.| ```int numberOfConnections; ```|
|Methoden|PascalCase|  ```public void AreStationFieldsFilled(){ } ```|
|Klassen|Gross| ```Station``` |
|GUI|Fängt mit Kürzel von GUI-Element an.|  ```btnSearchConnections```|
### Deklaration
| Regel | Beispiel |
|--------------|-------|
|Globale Variablen unterhalb des Klassenkopfes definieren und im Konstruktor deklarieren| |
|Lokale variablen unterhalb des Methodenkopfes definieren und deklariere| |
### Kommentare
| Regel | Beispiel |
|--------------|-------|
|Code sollte auch ohne Kommentare lesbar sein. Keine Kommentare, nur bei Komplexen Code Kommentare | |
### Methoden, Schleifen, Verzweigungen, Try Catch
| Regel | Beispiel |
|--------------|-------|
|Allman, Klammern immer auf neu Line bei Statements| |
## Testing
### Testfälle
### Testprotokoll
## Installation Anleitung