# Oglasnik

## Opis projekta

**Oglasnik** je namizna aplikacija za pregledovanje, dodajanje in nakupovanje oglasov za motorna vozila. Izdelek je namenjen simulaciji enostavnega oglasa za različne tipe vozil, pri čemer uporabnik lahko:

- pregleduje oglase po kategorijah vozil,
- dodaja nove oglase,
- kupuje izbrana vozila,
- pregleduje podrobnosti posameznega vozila.

Aplikacija podpira več vrst vozil:

- avtomobile,
- tovornjake,
- traktorje,
- kombije,
- motorje.

Projekt je izdelan kot **Windows Forms** aplikacija v jeziku **C#**, pri čemer uporablja tudi objektno usmerjene principe, kot so dedovanje, dogodki, delegati in polimorfizem.

---

## Glavne funkcionalnosti

- prikaz vozil po kategorijah,
- dodajanje novih oglasov prek obrazca,
- prikaz podatkov v tabelah (`DataGridView`),
- nakup vozila z zmanjšanjem stanja v denarnici,
- prikaz podrobnosti izbranega vozila v ločenem oknu,
- uporaba podrazredov razreda `MotornoVozilo` za različne tipe vozil.

---

## Zahteve za zagon

Za uspešen zagon projekta potrebujete:

- operacijski sistem **Windows**,
- **Visual Studio 2022** ali novejši,
- nameščeno podporo za **.NET Desktop Development**,
- nameščen ustrezen .NET razvojni komplet za projekte v rešitvi.

Priporočeno je, da projekt zaženete neposredno iz okolja Visual Studio.

---

## Namestitev

1. Prenesite ali klonirajte projekt na računalnik.
2. Odprite datoteko rešitve:

   `Oglasnik.sln`

3. Počakajte, da Visual Studio naloži projekt in pripravi odvisnosti.
4. Preverite, da je kot zagonski projekt nastavljen:

   `Oglasnik`

5. Projekt po potrebi prevedite z možnostjo:

   `Build > Build Solution`

---

## Zagon aplikacije

Aplikacijo zaženete tako, da v Visual Studio izberete:

- `Start`
- ali pritisnete `F5`

Za zagon brez razhroščevanja lahko uporabite tudi:

- `Ctrl + F5`

Po uspešnem zagonu se odpre glavno okno aplikacije z oglasi vozil.

---

## Navodila za uporabo

### 1. Pregled oglasov

Ob zagonu se v aplikaciji naložijo začetni oglasi za več tipov vozil. Med kategorijami preklapljate z izbirnimi gumbi, na primer:

- Avto
- Tovornjak
- Traktor
- Kombi
- Motor

Ko izberete kategorijo, se prikaže ustrezna tabela z oglasi te vrste vozil.

---

### 2. Dodajanje novega oglasa

Za dodajanje novega oglasa:

1. Izberite tip vozila.
2. Vnesite podatke v vnosna polja.
3. Izberite ustrezne lastnosti, kot so:
   - menjalnik,
   - tip goriva,
   - število vrat,
   - dodatne posebnosti glede na tip vozila.
4. Kliknite gumb za dodajanje oglasa.

Novi oglas se po uspešnem vnosu prikaže v ustrezni tabeli, hkrati pa se posodobi tudi skupno število oglasov.

---

### 3. Nakup vozila

Za nakup vozila:

1. V tabeli izberite vrstico z želenim vozilom.
2. Kliknite gumb za nakup vozila.

Če je izbrano vozilo veljavno, se njegova cena odšteje od stanja denarnice. Novo stanje se izpiše v uporabniškem vmesniku.

Če vozilo ni izbrano, aplikacija izpiše opozorilo.

---

### 4. Prikaz podrobnosti

Za ogled podrobnosti vozila:

1. V trenutno odprti tabeli izberite vozilo.
2. Kliknite gumb `Podrobnosti`.

Odpre se novo okno z dodatnimi podatki o vozilu, kot so:

- znamka,
- model,
- leto izdelave,
- barva,
- moč,
- menjalnik,
- tip goriva,
- število vrat,
- posebna lastnost glede na vrsto vozila.

Primer:
- avto izpiše obliko in podatek o čipiranju,
- tovornjak izpiše nosilnost in priklop,
- motor izpiše prostornino motorja.

---

## Struktura projekta

Projekt je sestavljen iz več razredov, med katerimi so najpomembnejši:

- `MotornoVozilo`  
  Osnovni abstraktni razred za vsa vozila.

- `Avto`, `Tovornjak`, `Traktor`, `Kombi`, `Motor`  
  Podrazredi, ki predstavljajo posamezne tipe vozil.

- `Form1`  
  Glavno okno aplikacije za prikaz, dodajanje in nakup.

- `Form2`  
  Dodatno okno za prikaz podrobnosti izbranega vozila.

- `Denarnica`  
  Razred za upravljanje stanja uporabnikovih sredstev.

---

## Tehnične značilnosti

Pri projektu so uporabljeni naslednji koncepti:

- dedovanje,
- abstraktni razredi,
- polimorfizem,
- delegati,
- dogodki (`event`),
- delo z obrazci Windows Forms,
- prikaz podatkov v tabelah.

---

## Primer uporabe

Tipičen potek uporabe aplikacije:

1. Uporabnik zažene aplikacijo.
2. Izbere kategorijo vozila.
3. Pregleda obstoječe oglase.
4. Po želji doda nov oglas.
5. Izbere vozilo in pregleda njegove podrobnosti.
6. Vozilo kupi in preveri novo stanje denarnice.

---

## Avtor in namen

Projekt je bil izdelan kot učni oziroma študijski izdelek za prikaz razvoja namizne aplikacije v C# in uporabe osnovnih ter naprednejših konceptov objektno usmerjenega programiranja.

---
