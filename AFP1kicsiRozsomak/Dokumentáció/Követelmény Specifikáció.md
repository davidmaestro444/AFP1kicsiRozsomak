# Követelmény specifikáció

## 1. Áttekintés

A szoftver célja egy memória tesztelő játék elkészítése. Az interneten vannak már ilyen játékok, de azok reklámokkal teli játék oldalakon vannak vagy a már nem is működnek. Ez azokhoz képest egy letölthető és internet elérés nélkül is játszható játék lesz amit akármikor használhat a megrendelő.

## 2. A jelenlegi helyzet leírása

Jelenleg nincs elég olyan letölthető könnyen elérhető kártya fordítós memóriajáték amit internet elérés nélkül lehet használni és egyszerűen lehet kezelni ahol a játékos tudja tesztelni a memóriáját és reakció idejét.

## 3. Vágyálomrendszer

A cél egy olyan kártyafordítós memóriajáték elkészítése ami egyszerű és átlátható. Ha a felhasználó elkezdi a játékot és rákattint egy kártyára akkor az átfordul és ha rákattint egy másik kártyára és nem pár akkor egy bizonyos idő után mindkettő visszafordul, de ha pár akkor felfordítva marad és ha az összes párt felfordította a megadott esélyek alatt akkor kiírja, hogy nyert a felhasználó és hogy hány lépésből sikerült megtalálnia az összes párt. A játék C# Form-ban lessz leprogramozva.

## 4. Jelenlegi üzleti folyamatok modellje

Jelenleg, ha a felhasználó játszani akar egy memória tesztelő játékkal akkor az interneten kell rákeresnie és reklámokkal teli játékoldalakon kell játszania ahol kötelező az internetelérés. Azoknak a játékoknak a minősége is változó és sokáig is eltarthat, ha az ember egy minőségi játékot akar találni. Ezek nagyrészét nem lehet letölteni és azonnal használni akármikor a felhasználó akarja.

## 5. Igényelt üzleti folyamatok modellje

A felhasználó, ha letöltötte a játékot akkor akármikor meg tudja nyitni a és addig játszik vele zavaratlanul ameddig akar és ha végzett a játékkal akkor szimplán bezárja a játékot.

## 6. Követelménylista

| Id | Modul | Név | Leírás |
| :---: | --- | --- | --- |
| K1 | Játék | Kártyák megjelenítése | A játékos lát egy lefelé fordított kártyarácsot a képernyőn. |
| K2 | Játék | Kártyák felfordítása | A játékos két kártyát fordíthat fel egyszerre, ha rákattint a kártyákra. |
| K3 | Játék | Pár megtalálása | Ha a két felfordított kártya azonos, azok felfordulva maradnak. |
| K4 | Játék | Kártyák visszafordítása | Ha a két kártya nem egyezik, egy idő után visszafordulnak. |

## 7. Fogalomtár

| Fogalom | Leírás |
| :---: | --- |
| C# | programozási nyelv, az játék ebben lesz megírva |
| szoftver | számítógépre írt program |