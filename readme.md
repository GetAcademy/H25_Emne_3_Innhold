# Emne 3 – C# og Objektorientert Programmering

Fire hoveddeler:

1. [Fra JavaScript til C#](#del1)
1. [Grunnleggende objektorientering](#del2)
1. [API, kobling til frontend og forenklet fullstack](#del3)
1. [Videregående objektorientering](#del4)

---

<a id="del1"></a>

## Del 1 – Fra JavaScript til C#

### Økt 1 – tirsdag 18.11 – Fra JavaScript til C#

- Gå gjennom pensum
- Visual Studio - Community Edition
- Likheter og forskjeller mellom JavaScript og C#
- Første konsoll-applikasjon
- Input med `Console.ReadLine`
- Spørsmål og Svar - og noen datatyper
- Refactoring
    - Trekke ut metoder
    - Resharper - https://account.jetbrains.com/a/dc693qyu
    - Samle metoder i egen klasse `MyConsole`
- Mer om Console
    - Farger
    - Posisjon
- Enkel tastestyring - input med  `Console.ReadKey()`
    - Flytte
    - Styre retning
    - Endre farge
- Legge ut C# på GitHub - .gitignore!

Opptak: 

- https://photos.app.goo.gl/92xAU2FfBBe42hZD7

Kode: 

- https://github.com/GetAcademy/H25_3.1_ConsoleApp2
---

### Økt 2 – torsdag 20.11 – Grunnleggende C#

- Datatyper: `bool`, `int`, `char`, `string`, `float`/`double`
- `var`
- Spørre-metoder i MyConsole
    - AskForBool
    - AskForChar
    - AskForFloat
- `null`-verdier og nullable types
- Eksempel: Bruker velger tegn, posisjon og invertering eller ikke
- Arrays og lister. 
    - Bruker velger del av ascii-tabellen
    - Loope gjennom ConsoleColors
    - Printe flere linjer med tekst i en bestemt posisjon (inkl. `params`)
    - `enum`
- Overloads og default parameters - Vi utvider MyConsole
- Tilfeldige tall 
- Game of life


Kode: 

- https://github.com/GetAcademy/H25_3.2_DemoDatatypesArrayOverloadRandom

Opptak: 

- https://photos.app.goo.gl/LtzUPsU5RxMXgaVH7

---

### Økt 3 – tirsdag 25.11 – Fra JS-objekter til C#-klasser

- Klasse som mal for objekter ala JavaScript - inkl. felt/objektvariable
- Liste av objekter!
- Lage `GameObject`
- Enkel konsoll-animasjon
- Flytte metoder inn i klasser

Shortcuts: 

- https://resources.jetbrains.com/storage/products/resharper/docs/ReSharper_DefaultKeymap_VSscheme.pdf
- https://visualstudio.microsoft.com/keyboard-shortcuts.pdf

Kode: 

- https://github.com/GetAcademy/H25_3.3_IntroObjects

Opptak: 

- https://photos.app.goo.gl/oDq3gbA4NBgZHcnd6

---

<a id="del2"></a>

## Del 2 – Grunnleggende objektorientering

### Økt 4 – torsdag 27.11 – Strukturerte klasser og serialisering

- Constructor
- Enkel klikker knyttet til en bestemt tast i tre versjoner
    - en klikker uten klasse
    - en klikker med klasse
    - mange klikkere med klasse
- Static vs. non-static
    - flere eksempler: https://chatgpt.com/share/692847e0-ccfc-8012-8a07-4fb97c02d80e
- JSON save/load

Opptak: 

- https://photos.app.goo.gl/BQpEm6SBsmwb8ab98

Kode: 

- https://github.com/GetAcademy/H25_3.4_MoreClassAndStatic

---

### Økt 5 – tirsdag 2.12 – Introduksjon til objektorientering

- Innkapsling (encapsulation)
- Properties
- Trafikklys som eksempel
    - Kan gjøre refactoring internt uten å påvirke koden rundt
- Innpakking av ikke-fleksibel array i klasse + enkel generics 
- Towers of Hanoi (kort gjennomgang av ferdig kode)
    - https://github.com/GetAcademy/TowersOfHanoi2024

Opptak: 

- https://photos.app.goo.gl/Sc3zVDpAENYHD8mQA

Kode: 

- https://github.com/GetAcademy/H25_3.5_Encapsulation

---

### Økt 6 – torsdag 4.12 – OO-modellering videre

- Introduksjon til WPF 
    - Eksempel på bibliotek for rike brukergrensesnitt
    - Relevant som eksempel på objektorientering + native app-utvikling (er typisk enten lignende bibliotek eller innpakking av web frontend)
    - Avalonia (https://avaloniaui.net/) for de som bruker Mac eller Linux
        - https://chatgpt.com/share/693182ef-36c0-8012-a340-3be55cef5211
    - Klikker som eksempel 
        - inkl. kort introduksjon til hva arv er
- Kort om model-view-presenter og se på å gjenbruke model (inkl. metodene som endrer på model, dvs. controller i MVC) til både view i Console og WPF

Opptak: 

- https://photos.app.goo.gl/ejAz2abQbABfYVsX7

Kode: 

- https://github.com/GetAcademy/H25_3.6_WpfDemoA
- https://github.com/GetAcademy/H25_3.6_MultiViewClicker

---

<a id="del3"></a>

## Del 3 – API, kobling til frontend og forenklet fullstack

### Økt 7 – tirsdag 9.12 – Intro API

- Hva er API? Hva er backend?
- Introduksjon til ASP.NET Minimal API
- ClaimTheSquare del 1 
    - Bygge API til ferdig frontend
        - https://getacademy.github.io/ClaimTheSquare
        - https://github.com/GetAcademy/ClaimTheSquare
    - Lage API med in-memory db    
    - Koble til Vanilla JavaScript-frontend
        - Axios https://axios-http.com/docs/intro
        - `async` og `await`
    - HTTP-tunnel 
    - Hvis tid, persistens til fil

Opptak: 

- https://photos.app.goo.gl/2WXXqkijoQuRL8XF9

Kode: 

- https://github.com/GetAcademy/H25_3.7_ClaimTheSquareFullstack
- https://github.com/GetAcademy/AsyncAwait

Artikkel om callbacks, promises og async/await: 

- https://www.toptal.com/javascript/asynchronous-javascript-async-await-tutorial

---

### Økt 8 – torsdag 11.12 – ClaimTheSquare del 2

- Claim the Square - enkel persistens til fil
- Om forskjell mellom kjøremiljøet i JavaScript vs C#
    - JavaScript single threaded, async = en nødvendighet for at språket skal fungere i det hele tatt
    - C# er multi-threaded, async = frigjør én tråd, ikke “magisk parallellitet”
- API med sync vs async - https://github.com/GetAcademy/H25_E3.8_AsyncVsSyncAPI
- [Hva er minuset med fil-persistens?](./details/8_fil_persistens.md)


Opptak: 

- https://photos.app.goo.gl/cY1rm3KXqBrUu7uz8

Kode: 

- https://github.com/GetAcademy/H25_3.8_ClaimTheSquareFullstackWithFilePersitence

---

### Økt 9 – tirsdag 16.12 – ClaimTheSquare del 3

- Kort introduksjon til SQL og databaser + snakke med database fra C#
- SQL Server Management Studio: https://learn.microsoft.com/en-us/ssms/install/install
- Videre på SQL: https://sqlbolt.com

Opptak: 

- https://photos.app.goo.gl/Banm8nkYJxzoUFB76

Kode: 

- https://github.com/GetAcademy/H25_3.9_ClaimTheSquareFullstackWithDb

---

<a id="del4"></a>

## Del 4 – Videregående objektorientering


### Økt 10 – torsdag 18.12 – Introduksjon til interface og arv

- Enkel polymorfisme med interface og arv
- TextElements
    - helt enkelt
    - med interface
    - med arv
- Stars
    - helt enkelt
    - med interface
    - med arv
- Om hvorfor ikke arv skal over-brukes: 
    - https://en.wikipedia.org/wiki/Composition_over_inheritance
    - Bruk ChatGPT eller tilsvarende og be om forklaring i C# eller ditt foretrukne språk

Opptak: 

- https://photos.app.goo.gl/Xq11cQVPicPp8iNT8

Kode: 

- https://github.com/GetAcademy/StarsAndTextElementsAsIntroToInterfaceAndInheritance
- Todo-liste med kommandoer: https://github.com/GetAcademy/IntroToInterfaceWithTextAndCommands/tree/main/Todo

---

### Juleferie og selvstudium

- Siste undervisningsdag før jul: fredag 19.12
- Første undervisningsdag etter jul: mandag 5.1
- Selvstudiedager: 22.12, 23.12 og 2.1

---

### Økt 11 – tirsdag 6.1 – LINQ og IEnumerable

- `IEnumerable` og `IEnumerator`
- Extension methods
- Builder Pattern
- Grunnleggende LINQ
    - https://vslapp.wordpress.com/wp-content/uploads/2011/11/linq-cheatsheet.pdf
    - https://www.scribd.com/document/857676101/LINQ-Cheat-Sheet

Opptak: 

- https://photos.app.goo.gl/sMcfKzUBTBRCT8A88

Kode: 

- https://github.com/GetAcademy/H25_3.11_IEnumerableAndIntroLinq

---


### Økt 12 – torsdag 8.1 – SRP og DIP

- Motivasjon: løse koblinger (DIP-intuisjon)
  - ChatServer / ChatClient: fra hard kobling til avhengighet av abstraksjon
- Problemstilling: brudd på Single Responsibility
  - Tekststatistikk v0: lesing av fil + logikk + aggregering i samme metode
- Første opprydding: “Imperative Shell, Core Logic”
  - Flytt all beregning til én ren metode (`ComputeStats`)
  - IO-kode blir kun ansvarlig for å hente linjer
  - Dette er faktisk å følge Dependency Inversion Principle (uten interfaces)
- Ev. kort om streaming og ReadLines og IEnumerable<string>
- OO-løsning: Dependency Injection med interface
  - Introduser `ILineReader` og konkrete implementasjoner
  - `StatService` som tydelig service-klasse
- Variasjon og fleksibilitet
  - Bytt mellom fil, web og tastatur uten å endre logikk
    - KeyboardLineReader 
    - WebLineReader (WebClient, OpenRead)
- Oppsummering
  - SRP oppnås ved hjelp av DIP
  - Interfaces er et verktøy – ikke målet
  

- Kort om "Functional Core, Imperative Shell" ala Scott Wlaschin, https://www.youtube.com/watch?v=P1vES9AgfC4


Opptak: 

- https://photos.app.goo.gl/crbdLFQCbHkpXHbm9

Kode: 

- https://github.com/GetAcademy/IntroSrpAandDip
- https://github.com/GetAcademy/LineStats (gammel med streaming)


---

### Økt 13 – tirsdag 13.1 – Unit testing og mocking

1. API for å registrere brukernavn helt enkel kode
1. API for å registrere brukernavn med dependency injection
1. Testing av siste API med NUnit og mocking
1. API for å registrere brukernavn med "imperative shell + pure core"
1. Testing av siste API med NUnit (vi trenger ikke mocking)

Opptak: 

- https://photos.app.goo.gl/LnZqAceDQRxzCSGy7

Kode: 

- https://github.com/GetAcademy/TestingAfterDependencyInversion