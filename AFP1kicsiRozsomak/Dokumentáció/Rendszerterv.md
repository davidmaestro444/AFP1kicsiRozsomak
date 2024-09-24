# Rendszerterv
## 1. A rendszer célja

A rendszer célja egy egyszerű memóriatesztelő játék, aminek egyszerű a használata és bárki (felhasználó) könnyen elsajátíthatja.

## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
   * Scrum masters: Sinka Barnabás
   * Product owner: Tajti Tibor
   * Üzleti szereplő: Penyaskó Dávid
     
### 2.2 Projektmunkások és felelőségek:
   * Frontend:   Bobák Martin Ferenc, Bogáthy Péter, Deme Bence, Góga Dávid, Kovács Olivér 
   * Backend:    Bobák Martin Ferenc, Bogáthy Péter, Deme Bence, Góga Dávid, Kovács Olivér 
   * Tesztelés:  Bobák Martin Ferenc, Bogáthy Péter, Deme Bence, Góga Dávid, Kovács Olivér 
     
### 2.3 Ütemterv:

|Funkció                  | Feladat                                | Prioritás | Becslés (nap) | Aktuális becslés (nap) | Eltelt idő (nap) | Becsült idő (nap) |
|-------------------------|----------------------------------------|-----------|---------------|------------------------|------------------|---------------------|
|Követelmény specifikáció |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |             
|Funkcionális specifikáció|Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Rendszerterv             |Megírás                                 |         1 |             1 |                      1 |                1 |                   1 |
|Program                  |Képernyőtervek elkészítése              |         2 |             1 |                      1 |                1 |                   1 |
|Program                  |Prototípus elkészítése                  |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Alapfunkciók elkészítése                |         3 |             8 |                      8 |                8 |                   8 |
|Program                  |Tesztelés                               |         4 |             2 |                      2 |                2 |                   2 |

### 2.4 Mérföldkövek:
   * Prototípus átadása

## 3. Üzleti folyamatok modellje

### 3.1 Üzleti szereplők

### 3.2 Üzleti folyamatok

## 4. Követelmények

### Funkcionális követelmények

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K1 | ... | ... |

### Nemfunkcionális követelmények

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K4 | ... | ... |

### Támogatott eszközök

Egy asztali alkalmazást tervezünk amit a legtöbb PC-n futtatni lehet majd. Internetkapcsolat nem kell a használatához.

## 5. Funkcionális terv

### 5.1 Rendszerszereplők

-Játékos

### 5.2 Menühierarchiák

## 6. Fizikai környezet

### Vásárolt softwarekomponensek és külső rendszerek

### Hardver topológia

### Fizikai alrendszerek

### Fejlesztő eszközök


## 8. Architekturális terv

A játékot C# nyelven írtuk és a Windows Forms Appot használjuk.

### A program elérése, kezelése
A program használatához a Visual Studio előzetes telepítése, majd későbbi megnyitása szükséges. Windows Forms-on keresztül elérjük a játék felületét, amihez már csak egyet kell kattintani a konzolon lévő 'Start'-ra. 

## 9. Adatbázis terv

## 10. Implementációs terv

## 11. Tesztterv

A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata,
ellenőrzése a rendszer által megvalósított üzleti szolgáltatások verifikálása.
A teszteléseket a fejlesztői csapat minden tagja elvégzi.
Egy teszt eredményeit a tagok dokumentálják külön fájlokba.

### Tesztesetek

 | Teszteset | Elvárt eredmény | 
 |-----------|-----------------| 
 | ... | ... |

### A tesztelési jegyzőkönyv kitöltésére egy sablon:

**Tesztelő:** Vezetéknév Keresztnév

**Tesztelés dátuma:** Év.Hónap.Nap

Tesztszám | Rövid leírás | Várt eredmény | Eredmény | Megjegyzés
----------|--------------|---------------|----------|-----------
például. Teszt #01 | Regisztráció | A felhasználó az adatok megadásával sikeresen regisztrálni tud  | A felhasználó sikeresen regisztrált | Nem találtam problémát.
... | ... | ... | ... | ...

## 12. Telepítési terv

Nem szükséges telepíteni a szoftvert a felhasználó. Elég hogyha a gépen jelen van a .NET keretrendszer amivel akármikor futtatni tudja a felhasználó.

## 13. Karbantartási terv

Fontos ellenőrizni:
...

Figyelembe kell venni a felhasználó által jött visszajelzést is a programmal kapcsolatban.
Ha hibát talált, mielőbb orvosolni kell, lehet az:
*	Működéssel kapcsolatos
*	Kinézet, dizájnnal kapcsolatos
