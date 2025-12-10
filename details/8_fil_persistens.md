# Del 3 – Fil-persistens: hvorfor det ikke er godt nok

I denne delen lagrer vi data i fil med JSON.  
Det fungerer – men bare til en viss grad.

Poenget er ikke at fil-lagring er “feil”,  
men å forstå **hva som blir vanskelig** når programmet vokser.

---

## 1. Dataene er sårbare

Når vi lagrer i fil:

- Hvis filen slettes → alle data er borte
- Hvis appen krasjer midt i skriving → filen kan bli ødelagt
- Hvis noen åpner filen manuelt → ingen sikkerhet

Vi må selv:
- sørge for at filen alltid skrives ferdig
- håndtere feil under lagring

Dette er mulig, men lett å gjøre feil.

---

## 2. Flere brukere samtidig blir et problem

I dag kan én bruker legge til data.
Men hva hvis mange gjør det samtidig?

Med fil-lagring:
- To forespørsler kan prøve å skrive til filen samtidig
- En kan overskrive det den andre skrev
- Data kan forsvinne uten at vi merker det

Vi må da:
- låse filen
- vente på tur
- passe på rekkefølge

Dette blir fort komplisert.

---

## 3. Programmet tåler dårlig at det vokser

Når all data ligger i én fil:

- Hele filen må leses hver gang vi trenger data
- Hele filen må skrives på nytt når noe endres
- Jo større filen blir, jo tregere blir alt

Det fungerer fint med:
- 10 elementer
- 100 elementer

Men det merkes fort når det blir mer.

---

## 4. Det er vanskelig å finne riktig data

Tenk at vi vil:
- hente bare én bestemt ting
- filtrere på farge
- sortere etter navn
- finne “de 10 siste”

Med fil-lagring må vi:
1. lese hele filen
2. gjøre alt arbeidet selv i kode

Det er mye manuell jobb, og lett å gjøre feil.

---

## 5. Endring av eksisterende data er klønete

Hvis vi vil oppdatere én ting:

- lese hele filen
- finne riktig element
- endre det
- skrive hele filen på nytt

Hvis flere gjør dette samtidig, kan endringer forsvinne.

---

## 6. Ingen regler for hva som er gyldig data

Med fil-lagring:
- Alt kan lagres
- Ingenting stopper ugyldige verdier
- Du må selv passe på alle regler i kode

For eksempel:
- tomme verdier
- duplikater
- ugyldige kombinasjoner

Alt ansvar ligger hos programmet.

---

## 7. Vanskelig å dele data mellom flere programmer

Med fil-lagring:
- Hvem eier filen?
- Hva hvis to programmer trenger samme data?
- Hva hvis vi har flere servere?

Vi ender fort med:
- kopierte filer
- usynkroniserte data
- spesialløsninger

---

## 8. Fil-lagring blander ansvar

Når vi lagrer i fil:
- API-kode
- domene-logikk
- lagring

blandes lett sammen.

Det blir vanskeligere:
- å teste
- å endre senere
- å bytte løsning

---

## Viktig oppsummering

Fil-lagring fungerer:
- når programmet er lite
- når det bare er én bruker
- når kravene er enkle

Men det blir raskt vanskelig når:
- mange bruker systemet samtidig
- data må være sikre
- vi vil søke, sortere og oppdatere effektivt

---

## Overgang til neste økt

Neste steg er ikke å endre API-et.

Neste steg er bare å spørre:

**“Hva om det fantes et system som var laget for å lagre data trygt,
for mange brukere, samtidig?”**

Det er der databaser kommer inn.
