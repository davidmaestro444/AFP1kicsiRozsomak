# Rendszerterv
## 1. A rendszer célja

A rendszer célja egy egyszerűen használható memóriatesztelő/memóriafejlesztő játék létrehozása, amit bármilyen felhasználó könnyen elsajátíthat.
Fontos, hogy a felhasználó gyorsan el tudjon igazodni a felületen, ezért minimalista felhasználói felületet kap a program.

 A felhasználó pontszámokat kap
arról, hogyan sikerült megoldania a feladatokat.  A tanár szerepkörrel rendelkező felhasználók
feltölthetnek feladatsorokat az adatbázisba. A rendszer használható
Androidos eszközökön, alkalmazás formájában, valamint webes felületen is
elérhető. A rendszer az adatokat egy Web Service segítségével kapja az
adatbázisból. Mivel az alkalmazást csak webes felületen, és Android
alkalmazásban szeretnénk elérhetővé tenni, nem célunk hogy más, például
IOS operációs rendszerrel rendelkező eszközön fusson. A felhasználó a
feladatsorok megoldása után pontszámokat kap. Teljesítményét a toplistán is
megtekintheti.

## 2. Projektterv

### 2.1 Projektszerepkörök, felelőségek:
   * Scrum masters: Sinka Barnabás
   * Product owner: Tajti Tibor
   * Üzleti szereplő: Penyaskó Dávid
     
### 2.2 Projektmunkások és felelőségek:
   * Frontend:   Bobák Martin Ferenc, Bogáthy Péter, Góga Dávid 
   * Backend:    Bobák Martin Ferenc, Bogáthy Péter, Góga Dávid 
   * Tesztelés:  Bobák Martin Ferenc, Bogáthy Péter, Góga Dávid 
     
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

## 4. Követelmények

### Funkcionális követelmények

| ID | Modul | Név | Leírás |
| K1 | Játék | Kártyák megjelenítése | A játékos lát egy lefelé fordított kártyarácsot a képernyőn. |
| K2 | Játék | Kártyák felfordítása | A játékos két kártyát fordíthat fel egyszerre, ha rákattint a kártyákra. |
| K3 | Játék | Pár megtalálása | Ha a két felfordított kártya azonos, azok felfordulva maradnak. |
| K4 | Játék | Kártyák visszafordítása | Ha a két kártya nem egyezik, egy idő után visszafordulnak. |

### Nemfunkcionális követelmények

A felhasználók nem juthatnak hozzá más felhasználók személyes adataihoz a
nevükön és azonosítóikon kívül.

| ID | Megnevezés | Leírás |
| --- | --- | --- |
| K4 | ... | ... |

### Támogatott eszközök

Egy asztali alkalmazást tervezünk, amit a legtöbb PC-n futtatni lehet. Használatához internetkapcsolatra nincs szükség.

## 5. Funkcionális terv

### 5.1 Rendszerszereplők

Ebben a projektben csak a játékos szerepel.

### 5.2 Menühierarchiák

Bejelentkezésre nincs szükség, hiszen fiókot sem kell létrehozni a játék futtatásához (a projekthez).

Main Menu (Főmenü):
- "Új játék" gomb -> a játékos új játékot kezdhet, ha rákattint az alábbi gombra
- "Kilépés" -> a játékost kilépteti a játékból, a program futása befejeződik
Leírás: Játékos találkozik a főmenüvel, ahol az Új játék / Kilépés gombra kattinthat. Más választási lehetősége nincs.

## 6. Fizikai környezet

### 6.1 Fejlesztő eszközök
- Notepad++ -> terv elkészítéséhez és ötletek felírásához 
- Visual Studio -> C# nyelven kódoláshoz
- Windows Forms -> a játék platformja, amivel a játékos találkozik 

## 8. Architekturális terv

A játékot C# nyelven írjuk és a Windows Forms Appot használjuk.

### A program elérése, kezelése
A program használatához a Visual Studio előzetes telepítése, majd későbbi megnyitása szükséges. Windows Forms-on keresztül elérjük a játék felületét, amihez már csak egyet kell kattintani a konzolon lévő 'Start'-ra. 

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


## 12. Telepítési terv

Nem szükséges telepíteni a szoftvert a felhasználó. Elég hogyha a gépen jelen van a .NET keretrendszer amivel akármikor futtatni tudja a felhasználó.

## 13. Karbantartási terv

Fontos ellenőrizni:
...

Figyelembe kell venni a felhasználó által jött visszajelzést is a programmal kapcsolatban.
Ha hibát talált, mielőbb orvosolni kell, lehet az:
*	Működéssel kapcsolatos
*	Kinézet, design-nal kapcsolatos
