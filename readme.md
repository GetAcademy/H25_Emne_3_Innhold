# Emne 3 – C# og Objektorientert Programmering

Fire hoveddeler:
1. Fra JavaScript til C#
2. Grunnleggende objektorientering
3. Backend & Fullstack
4. Videregående objektorientering

---

## Navigasjon

- [Del 1 – Fra JavaScript til C#](#del1)
- [Del 2 – Grunnleggende objektorientering](#del2)
- [Del 3 – Backend & Fullstack](#del3)
- [Del 4 – Videregående objektorientering](#del4)

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

---

### Økt 2 – torsdag 20.11 – Grunnleggende C#

- Datatyper
- Arrays og lister
- Overloads og default parameters
- Casting, parsing og `enum`
- Tilfeldige tall og små konsoll-oppgaver

---

### Økt 3 – tirsdag 25.11 – Fra JS-objekter til C#-klasser

- Klassen som byggekloss
- Fields, properties og constructor
- Lage `GameObject`
- Metoder i klasser
- Enkel konsoll-animasjon

---

<a id="del2"></a>

## Del 2 – Grunnleggende objektorientering

### Økt 4 – torsdag 27.11 – Strukturerte klasser og serialisering

- Mange objekter i spill / modell
- Static vs. non-static
- JSON save/load
- Mini-prosjekt: «Clicker» med persistens

---

### Økt 5 – tirsdag 2.12 – Introduksjon til objektorientering

- Innkapsling (encapsulation)
- Koblinger mellom objekter
- Kort intro til Model–View–Presenter (MVP)
- Towers of Hanoi (som ren OO-demo)

---

### Økt 6 – torsdag 4.12 – OO-modellering videre

- Objektorientert design på små systemer
- Trafikklys som modell (eller lignende lite system)
- Separasjon av logikk og UI
- Lett refaktorering (flytte logikk ut av presentasjon)

---

<a id="del3"></a>

## Del 3 – Backend & Fullstack

### Økt 7 – fredag 6.12 – Intro backend & fullstack (ClaimTheSquare del 1)

- HTTP og JSON: request/response
- Minimal API i C#
- DTO-er og mapping
- Første endepunkt
- Testing i Postman

---

### Økt 8 – tirsdag 9.12 – ClaimTheSquare del 2

- Flere endepunkter (f.eks. GET/POST/PUT)
- Service-lag (forretningslogikk)
- Enkel JavaScript-klient
- Studentene kobler seg til felles server (HTTP-tunnel)

---

### Økt 9 – torsdag 11.12 – ClaimTheSquare del 3

- Persistens via JSON-fil eller repository
- Introduksjon til interfaces
- Forbedring av klienten
- Egen variant av spillet i par/duo

---

### Økt 10 – tirsdag 16.12 – Videre objektorientering i fullstack-kontekst

- Interfaces i praksis
- Enkel bruk av Strategy pattern
- Eksempel: `TextElement`-hierarki (f.eks. overskrift, punkt, avsnitt)

---

### Økt 11 – torsdag 18.12 – LINQ og IEnumerable

- `IEnumerable` og `IEnumerator`
- Extension methods
- Grunnleggende LINQ (Where, Select, Any, GroupBy)
- Statistikk-endepunkt i ClaimTheSquare (f.eks. oversikt over «claims»)

---

### Juleferie og selvstudium

- Siste undervisningsdag før jul: fredag 19.12
- Første undervisningsdag etter jul: mandag 5.1
- Selvstudiedager: 22.12, 23.12 og 2.1

---

<a id="del4"></a>

## Del 4 – Videregående objektorientering

### Økt 12 – tirsdag 6.1 – SRP og DIP

- Single Responsibility Principle (SRP)
- Dependency Inversion Principle (DIP)
- Mock repository
- Struktur: UI → service → repository → fil

---

### Økt 13 – torsdag 8.1 – Unit testing og mocking

- xUnit/NUnit (oppsett og bruk)
- Test av domenelogikk
- Test av service-lag
- Mocking av repository
- Testing av ClaimTheSquare-logikk

---

### Økt 14 – tirsdag 13.1 – Arv og oppsummerende småprosjekt

- Grunnleggende arv
- Riktig bruk av arv vs. komposisjon
- Lage et lite arvehierarki i par/duo
- Oppsummering av OO-prinsipper i emnet
