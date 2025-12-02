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

Kode: 

- https://github.com/GetAcademy/H25_3.5_Encapsulation

---

### Økt 6 – torsdag 4.12 – OO-modellering videre

- Introduksjon til WPF 
    - Eksempel på bibliotek for rike brukergrensesnitt
    - Relevant som eksempel på objektorientering + native app-utvikling (er typisk enten lignende bibliotek eller innpakking av web frontend)
    - Avalonia (https://avaloniaui.net/) for de som bruker Mac eller Linux
    - Klikker som eksempel 
        - inkl. kort introduksjon til hva arv er
- Kort om model-view-presenter og se på å gjenbruke model (inkl. metodene som endrer på model, dvs. controller i MVC) til både view i Console og WPF

---

<a id="del3"></a>

## Del 3 – API, kobling til frontend og forenklet fullstack

### Økt 7 – fredag 6.12 – Intro API

- Introduksjon til ASP.NET Minimal API
- ClaimTheSquare del 1 
    - Lage API
    - Koble til Vanilla JavaScript-frontend
    - HTTP-tunnel

---

### Økt 8 – tirsdag 9.12 – ClaimTheSquare del 2

- Mer om ASP.NET
- Enkel persistens

---

### Økt 9 – torsdag 11.12 – ClaimTheSquare del 3

- Kort introduksjon til SQL og databaser + snakke med database fra C#

---

<a id="del4"></a>

## Del 4 – Videregående objektorientering


### Økt 10 – tirsdag 16.12 – Introduksjon til interface

- Enkel polymorfisme med interface og arv

---

### Økt 11 – torsdag 18.12 – LINQ og IEnumerable

- `IEnumerable` og `IEnumerator`
- Extension methods
- Builder Pattern
- Grunnleggende LINQ

---

### Juleferie og selvstudium

- Siste undervisningsdag før jul: fredag 19.12
- Første undervisningsdag etter jul: mandag 5.1
- Selvstudiedager: 22.12, 23.12 og 2.1

---


### Økt 12 – tirsdag 6.1 – SRP og DIP

- Dependency Inversion Principle (DIP) 
    - Eksempel: ChatClient og ChatServer
- Single Responsibility Principle (SRP)
    - Eksempel: telle linjer med søketekst i fil 
    - versjon 0: kode som blandet logikk og lesing fra fil
- Vi bruker DIP til å skrive om til kode som tilfredsstiller SRP
    - Dependency _Injection_ og service-klasser
    - versjon 1a: Med interface og dependency injection
- Kort om "Functional Core, Imperative Shell" ala Scott Wlaschin, https://www.youtube.com/watch?v=P1vES9AgfC4
    - versjon 1b: Dependency Inversion manuelt uten interface

---

### Økt 13 – torsdag 8.1 – Unit testing og mocking

- Unit testing med NUnit
- Testing av service-klasser inkl. mocking 
- Testing av ClaimTheSquare-logikk hvis tid

---

### Økt 14 – tirsdag 13.1 – Arv og oppsummerende småprosjekt

- Mer om arv - eller ledig til om det er noe annet vi ikke har rukket eller ønsker mer av.
- Kort nevne objektorientert analyse og design om vi ikke har snakket om det.
