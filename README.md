# EquipmentBookingSystem

## Om projektet

Detta projekt är en individuell uppgift i kursen Objektorienterad analys och design (OOAD).

Projektet är en förenklad bokningsapplikation utvecklad i C# och .NET. Syftet är att modellera och implementera ett sammanhängande bokningsflöde där en kund kan boka utrustning och få ett unikt bokningsnummer.

## Valda User Stories

**US-05 – Skapa bokning**

Som kund vill jag boka ett exemplar av en utrustningsmodell under en sammanhängande period så att utrustningen reserveras för mig.

**US-06 – Få bokningsnummer**

Som kund vill jag få ett bokningsnummer direkt när min bokning är genomförd så att jag kan använda det som referens vid kontakt med personalen.

## Funktionalitet

Den planerade implementationen omfattar:

- Kontroll av bokningsperiod och startdatum.
- Kontroll av tillgängliga utrustningsexemplar.
- Skapande av bokning och reservation av ett ledigt exemplar.
- Generering av ett unikt bokningsnummer.
- Visning av bokningsbekräftelse med bokningsnummer.
- Felmeddelande om bokningen inte kan genomföras.

## Avgränsning

Projektet är en förenklad implementation av det planerade bokningssystemet.

Det omfattar inte inloggning, grafiskt användargränssnitt, riktigt webb-API eller databas. Bokningarna hanteras i minnet under programmets körning.

Avancerad hantering av samtidiga bokningar, personalsökning och visning av tidigare bokningar ingår inte.

## UML-diagram

Funktionaliteten modelleras med:

- Ett aktivitetsdiagram som beskriver bokningsflödet och alternativa flöden.
- Ett sekvensdiagram som visar kommunikationen mellan systemets delar.

Diagrammen ligger till grund för C#-implementationen.

## Teknik

- C#
- .NET
- Visual Studio
- Konsolapplikation

## Köra projektet

1. Klona eller ladda ner projektet från GitHub.
2. Öppna `EquipmentBookingSystem.sln` i Visual Studio.
3. Starta konsolapplikationen.

Alternativt kan projektet köras med `dotnet run` från projektmappen om .NET SDK är installerat.

## Testning

Följande scenarier ska verifieras:

- En giltig bokning genomförs.
- En bokning med passerat startdatum avvisas.
- En bokning avvisas om utrustningen är upptagen.
- Två genomförda bokningar får olika bokningsnummer.

Testresultaten dokumenteras när implementationen är färdig.

## Status

Projektet är under utveckling som en del av den individuella OOAD-uppgiften.


## UML-diagram

Projektet bygger på US-05 och US-06 och beskriver
ett sammanhängande bokningsflöde.

### Aktivitetsdiagram

![Aktivitetsdiagram](Diagrams/ActivityDiagram.png)

[Visa PlantUML-kod](Diagrams/ActivityDiagram.puml)

### Sekvensdiagram

![Sekvensdiagram](Diagrams/SequenceDiagram.png)

[Visa PlantUML-kod](Diagrams/SequenceDiagram.puml)
