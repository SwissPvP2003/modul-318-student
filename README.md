# M318 SwissTransport API
## Inhaltsverzeichnis
* [Einleitung](#einleitung)
  * [Autor](#autor)
  * [Projekt](#projekt)
  * [Aufgabenstellung](#aufgabenstellung)
  * [Anforderung](#anforderung) 
  * [Zweck](#zweck) 
* [Funktionen](#funktionen)
* [Bugs](#bugs)  
* [Planung](#planung)
  * [Usecases](#usecases)
  * [UseCase Diagram](#udiagramm)
  * [Aktiviäts Diagramm](#adiagramm)
  * [Mockups](#mockups)
* [Programmierrichtlinen](#programmierrichtlinen)
  * [Namensgebung](#namensgebung)
  * [Deklaration](#deklaration)
  * [Kommentare](#kommentare)
  * [Methoden, Schleifen, Verzweigungen, Try Catch](#methoden)
* [Testing](#testing)
  * [Testfälle](#testfaelle)
  * [Testprotokoll](#testprotokoll)
* [Installation Anleitung](#installationanleitung) 

<a name="einleitung"/>

## Einleitung

<a name="autor"/>

### Autor und Dokument
* Autor: **Noah Ziltener**
* Erstelldatum: **10.03.2020**
* letzte Aktualisierung: **12.03.2020**

<a name="projekt"/>

### Projekt
* Projektstart: **10.03.2020**   
* Projektende: **12.03.2020** 

<a name="aufgabenstellung"/>

### Aufgabenstellung
Unsere Aufgabe ist es eine Desktop Applikation mit Hilfe der Transport API zu Programmieren. Wir haben mehrere Anforderungen bekommen, die nach Wichtigkeit priorisiert sind. Uns ist es selber überlasen welche wir umsetzten möchten doch sollten die Anforderungen mit Priorität 1 auf jeden Fall umgesetzt werden. Mein Ziel ist es bis zur Abgabe ein fertiges Programm zu haben und die Code Konventionen einzuhalten. Auch möchte ich Die Anforderung mit Priorität 1 und 2 abgeschlossen haben.

<a name="anforderung"/>

### Anforderung
| ID   | Beschreibung  | Priorität |
| -----|:-------------:| -----:|
| A001 | Als ÖV-Benutzer möchte ich Start- und Endstation mittels Textsuche suchen können, damit ich nicht alle Stationsnamen auswendig lernen muss. | 1 |
| A002 | Als ÖV-Benutzer möchte ich die aktuellen, d.h. mindestens die nächsten vier bis fünf Verbindungen zwischen den beiden gefundenen und ausgewählten Stationen sehen, damit ich weiss wann ich zur Station muss, um den für mich idealen Anschluss zu erwischen.| 1 |
| A003 | Als ÖV-Benutzer möchte ich sehen, welche Verbindungen ab einer bestimmten Station vorhanden sind, damit ich bei mir zuhause eine Art Abfahrtstafel haben kann. | 1 |
| A004 | Als ÖV-Benutzer möchte ich, dass schon während meiner Eingabe erste Such-Resultate erscheinen, damit ich effizienter nach Stationen suchen kann. | 2 |
| A005 | ALs ÖV-Benutzer möchte ich nicht nur aktuelle Verbindungen suchen können, sondern auch solche zu einem beliebigen anderen Zeitpunkt, damit ich zukünftige Reisen planen kann. | 2 |
| A006 | Als ÖV-Benutzer möchte ich sehen, wo sich eine Station befindet, damit ich mir besser vorstellen kann, wie die Situation vor Ort aussieht. | 3 |
| A007 | Als ÖV-Benutzer möchte Stationen finden, die sich ganz in der Nähe meiner aktuellen Position befinden, damit ich schnell einen Anschluss erreichen kann. | 3 |
| A008 | Ich möchte meine gefundenen Resultate via Mail weiterleiten können, damit  auch andere von meinen Recherchen profitieren können. | 3 |

<a name="zweck"/>

### Zweck
Die Dokumentation dient dazu die Projektarbeit im Rahmen des ÜK 318 zu dokumentieren. Das Dokument enthält die Planung, allgemeine Informationen über das Projekt und das Testing der Applikation. Auch ist eine Installationsanleitung am Ende des Dokumentes enthalten.

<a name="funktionen"/>

## Funktionen
In der Tabele ist ersichtlich welche Funktionen umgesetz wurden und welche nicht.
| Anforderung | Priorität | Status | Beschreibung                      |
| ----------- | --------- | ------ | --------------------------------- | 
| A01         | 1         | ✅      | Während der Eingabe einer Station werden Vorschläge in einem Dropdown angezeigt | 
| A02         | 1         | ✅      | Verbindungsseite: Mit Verbindung suchen werden die nächsten Verbindungen anhand der Angaben gesucht und angezeigt | 
| A03         | 1         | ✅      | Abfahrtsplansseite: Mit Abfahrtsplan anzeigen werden die nächste Abfahrten ab der eingegebenen Station gesucht und angezeigt | 
| A04         | 2         | ✅      | Während der Eingabe einer Station werden Vorschläge in einem Dropdown angezeigt | 
| A05         | 2         | ✅      | Der User kann ein belibiges Datum und Zeitpunkt eingeben|
| A06         | 3         | ✅      | Wenn eine Station im Stationboard eingegeben wird und der Button Auf Karte anzeigen gedrückt wird öffnet sich ein Browser mit Google Maps|  
| A07         | 3         | ❌      | Wurde nicht umgesetzt|  
| A08         | 3         | ✅      | Belibiges Mailprogramm wird mit Resultaten aus Verbindungs Suche geöffnet |

<a name="bugs"/>

## Bugs

<a name="planung"/>

## Planung

<a name="usecases"/>

### Usecases

#### START- & END-STATION SUCHEN
| USE CASE |          |
| ---------|----------|
|BESCHREIBUNG|Damit der User sich keine Stationen merken muss kann er nach Stationen suchen. Die suche muss über eine Texteingabe erfolgen. Es werden auch schon Stationen angezeigt, wenn der Name noch nicht den ganzen Namen eingegeben hat.|
|AKTEUR|SBB User|
|AUSLÖSER|SBB User möchte, Namen der Station wissen und nicht selber auswendig lernen.|
|VOBEDINGUNGEN|Internetverbindung|
|ABLAUF| <ol><li>User öffnet Programm</li><li>User klickt entweder auf «Abfahrstafel» oder «Verbindungen anzeigen»</li><li>User gibt Namen von Station ein.</li><li>User klickt auf Suchen</li><li>User bekommt Resultat auch wenn er nicht den kompletten Namen eingegeben hat</li></ol> |
|ERGEBNIS|Stationen werden trotzdem gefunden auch wenn der User nicht den Kompletten Namen eingegeben hat. z.B. Meierskappel wird zu Meierskappel Dorfplatz.|

#### VERBINDUNGEN ANZEIGEN
| USE CASE |          |
| ---------|----------|
|BESCHREIBUNG|Dem User werden die nächsten 5 Verbindungen zwischen der Start- und End-Station angezeigt|
|AKTEUR|SBB User|
|AUSLÖSER|SBB User möchte, die wissen was die besten Verbindungen zwischen den eingegebenen Stationen wissen.|
|ABLAUF| <ol><li>User öffnet Programm</li><li>User klickt entweder auf «Verbindungen anzeigen»</li><li>User gibt Namen von Start- und Endstation ein.</li><li>User klickt auf Verbindungen anzeigen</li><li>User bekommt Liste mit den 5 nächsten Verbindungen zwischen den 2 Stationen angezeigt.</li></ol> |
|ERGEBNIS|User bekommt Liste mit den 5 nächsten Verbindungen zwischen den 2 Stationen angezeigt.|

#### ABFAHRTSTAFEL
| USE CASE |          |
| ---------|----------|
|BESCHREIBUNG|Dem User werden alle Anschlussmöglichkeiten einer Station angezeigt. Es sollen alle Verbindungen, egal in welche Richtung, welche an dieser Station anhalten angezeigt werden|
|AKTEUR|SBB User|
|AUSLÖSER|SBB User möchte alle Verbindungen einer Station in alle Richtungen wissen.|
|VOBEDINGUNGEN|Internetverbindung|
|ABLAUF| <ol><li>User öffnet Programm</li><li>User klickt entweder auf «Abfahrstafel»</li><li>User gibt Namen von Startstation ein.</li><li>User klickt auf Abfahrstafel anzeigen</li><li>User bekommt Liste mit den nächsten Verbindungen die von der eingegeben Stationen ausgehen angezeigt.</li></ol> |
|ERGEBNIS|User bekommt Liste mit den nächsten Verbindungen die von der eingegeben Stationen ausgehen angezeigt. Die Tafel funktioniert genauso wie die Tafel die an den Bahnhöfen stehen.|

<a name="udiagramm"/>

#### UseCase Diagram

![Use Case](/img/UseCase.png)

<a name="adiagramm"/>

### Aktiviäts Diagramm
Dieses Diagramm zeigt wie die Funktionen des Programm bedient werden.

![Aktiviäts Diagramm](/img/Aktivität.png)

---

<a name="mockups"/>

### Mockups

#### Stationboard
Das Mokup zeigt wie das GUI zum Stationboard aussehen sollte
![Mockup](/img/Mockup1.png)

---

#### Menu
Die Grafik zeigt den Startpunkt der Applikation
![Mockup](/img/Mockup2.png)

---

#### Search Connections
Das Mokup zeigt wie der User Oberfläche der Verbindungssuche aussehen sollte
![Mockup](/img/Mockup3.png)

<a name="programmierrichtlinen"/>

## Programmierrichtlinen

<a name="anforderung"/>

### Namensgebung
| Stelle | Regel  | Beispiel                |
|--------|--------|-------------------------|
|Allgemein|Englische Bezeichnungen, aussagen was für Zweck sie haben.| |
|Variabel|CamelCase, Lokale und Membervariabel werden nicht unterschieden.|```int numberOfConnections; ```|
|Methoden|PascalCase| ```AreStationFieldsFilled()```|
|Klassen|Gross|```Station```|
|GUI|Fängt mit Kürzel von GUI-Element an.|```btnSearchConnections```|

<a name="Deklaration"/>

### Deklaration
Globale Variablen unterhalb des Klassenkopfes definieren und im Konstruktor deklarieren
```csharp 
int varOne;
Konstruktor() { 
varOne = 0 
}
```

Lokale variablen unterhalb des Methodenkopfes definieren und deklariere

```csharp 
 Methode() {
  int varOne = 0;
}
```

<a name="kommentare"/>

### Kommentare
Code sollte auch ohne Kommentare lesbar sein. Keine Kommentare, nur bei Komplexen Code Kommentare.

```csharp
while (x == y)
{
  somethingSimple();
  // Erklährung
  somethingComplicated();
}
 ```
 
 <a name="methoden"/>
 
### Methoden, Schleifen, Verzweigungen, Try Catch
Allman, Klammern immer auf neu Line bei Statements

```csharp
while (x == y)
{
    something();
    somethingelse();
}
```
<a name="testing"/>

## Testing

<a name="testfaelle"/>

### Testfälle

#### Station suchen

**Vorbedingung** Stationboard oder Verbindungssuche ist geöffnet & Internetverbindung

**Anforderung** A001 & A004

**Testszenario**

| Schritt | Aktivität                                                     | Erwartetes Resultat                                      |
| ------- | ------------------------------------------------------------- | -------------------------------------------------------- | 
| 1       | Ich gebe "lu" in die "From", "To" oder "Station" Textbox ein.| Es werden keine Vorschlähge angezeigt |
| 2       | Ich gebe "luz" in die "From", "To" oder "Station" Textbox ein. | Es werden alle Haltestellen die mit Luzern anfgagen angezeigt |
| 3       | Ich wähle das oberste Resultat aus | Der Stationsname wird in die Textbox eingefühlt |

#### Verbindung suchen

**Vorbedingung** Verbindungssuche ist geöffnet & Internetverbindung

**Anforderung** A002

**Testszenario**

| Schritt | Aktivität                                                     | Erwartetes Resultat                                      |
| ------- | ------------------------------------------------------------- | -------------------------------------------------------- | 
| 1       | Ich gebe "Luzern" in die "From" Textbox ein | Dropdown Menu schläg weiter Stationen vor die die Bezeichnung Luzern in Namen haben |
| 2       | Ich gebe "Sursee" in die "To" Textbox ein | Dropdown Menu schläg weiter Stationen vor die die Bezeichnung Sursee in Namen haben |
| 3       | Ich klicke auf den Button "Search" | Es wird eine Liste mit den nächsten 4 Verbindungen ausgegeben |

#### Stationboard

**Vorbedingung** Staionboard ist geöffnet & Internetverbindung

**Anforderung** A003

**Testszenario**

| Schritt | Aktivität                                                     | Erwartetes Resultat                                      |
| ------- | ------------------------------------------------------------- | -------------------------------------------------------- | 
| 1       | Ich gebe "Luzern" in die "Station" Textbox ein | Dropdown Menu schläg weiter Stationen vor die die Bezeichnung Luzern in Namen haben |
| 2       | Ich klicke auf den Button "Search" | Es wird eine Liste mit den nächsten Verbindungen von Luzern in alle Richtungen angezeigt |

#### Verbindung suchen mit Datum und Zeit

**Vorbedingung** Staionboard ist geöffnet & Internetverbindung

**Anforderung** A005

**Testszenario**

| Schritt | Aktivität                                                     | Erwartetes Resultat                                      |
| ------- | ------------------------------------------------------------- | -------------------------------------------------------- | 
| 1       | Ich gebe "Luzern" in die "From" Textbox ein | Dropdown Menu schläg weiter Stationen vor die die Bezeichnung Luzern in Namen haben |
| 2       | Ich gebe "Sursee" in die "To" Textbox ein | Dropdown Menu schläg weiter Stationen vor die die Bezeichnung Sursee in Namen haben |
| 3       | Ich gebe das Datum von Morgen über den Datepicker ein| Datum von Morgen steht im richtigen Format in Textbox |
| 4       | Ich gebe die Zeit "16:00" in die Zeit Textbox ein| Die zeit steht im richtigen Format in der Textbox|
| 4       | Ich klicke auf den Button "Search" | Es wird eine Liste mit 4 Verbindungen ausgegeben die Morgen um 16:00 in Luzern abfahren| |

#### Karte

**Vorbedingung**  Staionboard ist geöffnet & Internetverbindung

**Anforderung** A006

**Testszenario**

| Schritt | Aktivität                                                     | Erwartetes Resultat                                      |
| ------- | ------------------------------------------------------------- | -------------------------------------------------------- | 
| 1       | Ich gebe "Luzern" in die "Station" Textbox ein | Dropdown Menu schläg weiter Stationen vor die die Bezeichnung Luzern in Namen haben |
| 2       | Ich klicke auf den Button "Show Map" | Es öffnet sich ein Browser Fenster mit Googlemaps. Luzern ist auf der Karte makiert |

#### Mail

**Vorbedingung**  Verbindungssuche ist geöffnet  & Internetverbindung

**Anforderung** A008

**Testszenario**

| Schritt | Aktivität                                                     | Erwartetes Resultat                                      |
| ------- | ------------------------------------------------------------- | -------------------------------------------------------- | 
| 1       | Ich gebe "Luzern" in die "From" Textbox ein | Dropdown Menu schläg weiter Stationen vor die die Bezeichnung Luzern in Namen haben |
| 2       | Ich gebe "Sursee" in die "To" Textbox ein | Dropdown Menu schläg weiter Stationen vor die die Bezeichnung Sursee in Namen haben |
| 3       | Ich klicke auf den Button "Search" | Es wird eine Liste mit den nächsten 4 Verbindungen ausgegeben |
| 4       |Ich klicke auf den Button "Send Mail" | Es öffnet sich ein Mailprogramm und im Email Body sind alle Informationen aus der Ausgabetabel eingefüght|

<a name="testprotokoll"/>

### Testprotokoll

<a name="installationanleitung"/>

## Installation Anleitung
