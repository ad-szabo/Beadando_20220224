using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_20220224
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (menu())
            {
                case "1":
                    feladat1();
                    break;
                case "2":
                    feladat2();
                    break;
                case "3":
                    feladat3();
                    break;
                case "4":
                    feladat4();
                    break;
                case "5":
                    feladat5();
                    break;
                case "6":
                    feladat6();
                    break;
                case "7":
                    feladat7();
                    break;
                case "8":
                    feladat8();
                    break;
                case "9":
                    feladat9();
                    break;
                case "10":
                    feladat10();
                    break;
                case "11":
                    feladat11();
                    break;
                case "12":
                    feladat12();
                    break;
                case "13":
                    feladat13();
                    break;
                case "14":
                    feladat14();
                    break;
                case "15":
                    feladat15();
                    break;
                case "16":
                    feladat16();
                    break;
                case "17":
                    feladat17();
                    break;
                case "18":
                    feladat18();
                    break;
                case "19":
                    feladat19();
                    break;
                case "E":
                case "e":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Nem létezik ilyen menüpont!");
                    break;
            }
            Console.WriteLine("\nkilépés: E, minden más esetben visszatérés a főmenübe!");
           ConsoleKeyInfo k =  Console.ReadKey();
            if(k.KeyChar=='e' || k.KeyChar == 'E')
            {
                Environment.Exit(0);
            } else
            {
                Console.Clear();
                Program.Main(args);
            }
        }
        static string menu()
        {
            var str = new StringBuilder();
            str
                .AppendLine("1: Alapvető műveletek – szint: 1")
                .AppendLine("2: Kimenet formázása – szint: 1")
                .AppendLine("3: Read vagy ReadLine – szint: 1")
                .AppendLine("4: Konzol képernyő használata – szint: 1")
                .AppendLine("5: Szállásszervezés – szint: 1")
                .AppendLine("6: Kocka – szint: 2")
                .AppendLine("7: Melyik szám a nagyobb – szint: 1")
                .AppendLine("8: Osztályzatok – szint: 1")
                .AppendLine("9: Számok sorrendje – szint: 1")
                .AppendLine("10: Szerkeszthető háromszögek – szint: 1")
                .AppendLine("11: Háromszög típusa – szint: 1")
                .AppendLine("12: Háromszög kerülete – szint: 1")
                .AppendLine("13: Háromszög területe - Héron képlet – szint: 2")
                .AppendLine("14: Majdnem Lottó – szint: 1")
                .AppendLine("15: Szóközök – szint: 1")
                .AppendLine("16: Sorozatok – szint: 2")
                .AppendLine("17: Command Line Interface – szint: 1")
                .AppendLine("18: A hét napjai – szint: 1")
                .AppendLine("19: Életkorok – szint: 1")
                .AppendLine("E: Kilépés");
            Console.WriteLine(str.ToString());
            var rtn = Console.ReadLine();
            Console.Clear();
            return rtn;
        }
        static void feladat1()
        {
            /*
                3.1. feladat (Alapvető műveletek – szint: 1). Készítsünk programot, 
                mely bekér két számot, majd kiírja az összegüket, a különbségüket, a szorzatukat és a hányadosukat. 
                Az adatokat a billentyűzetről olvassuk be. A beolvasást mindaddig végezzük, míg helyes adatokat nem kapunk.
                Magyarázat: Az eredményeket nem kell tárolni, mivel a kiszámításukhoz szükséges kifejezést elhelyezhetjük a kiíró utasításban is. 
                A C# nyelvben a Write és a WriteLine képes elvégezni a kifejezésben leírtakat, és az eredményüket megjeleníteni a képernyőn. 
                Ezzel a megoldással tárterületet takaríthatunk meg. 
            */
            
            float a, b=0;
            Console.Write("Add meg az első számot: ");
            while (!float.TryParse(Console.ReadLine(), out a)){
                Console.WriteLine("Hibás szám, adj meg egy másikat: ");
            };
            Console.Write("Add meg a második számot: ");
            while (!float.TryParse(Console.ReadLine(), out b)) {
                Console.WriteLine("Hibás szám, adj meg egy másikat: ");
            };
            Console.WriteLine($"Összeg: {(a + b)}");
            Console.WriteLine($"Különbség: {(a - b)}");
            Console.WriteLine($"Szorzat: {(a*b)}");
            Console.WriteLine($"Hányados: {(a/b)}");
        }
        static void feladat2()
        {
            /*
                3.2. feladat (Kimenet formázása – szint: 1). Olvassunk be a billentyűzetről egy számot, majd írjuk ki a szám kétszeresét a képernyőre.
                A beolvasott számot és az eredményt nem kell mindenképpen tárolni.
                Magyarázat: A beolvasott szám kétszeresének kiszámítását a kiírásban is elvégezhetjük.
                Ehhez használjuk a Condole.WriteLine metódust. A kiírás során a kimenetet formázhatjuk is az alábbi formulával:
                Console.WriteLine("{0} kétszerese = {1}", ...) 
                A formázott kiírásban a {0} azt jelenti, hogy a paraméter listában elhelyezett első elemet kell kiírni elsőként.
                A {1} jelentése hasonló, csak itt a második elemre hivatkozunk.
                Figyelem! A beolvasásnál a ReadLine használata mellett szöveges formában kapjuk meg a számot, ezért azt konvertálnunk kell számmá.
             */
            Console.WriteLine("Adj meg egy számot: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("A {0} kétszerese: {1}",a,a*2);
        }
        static void feladat3()
        {
            /*
                3.3. feladat (Read vagy ReadLine – szint: 1). Egy egyszerű program segítségével vizsgáljuk meg, 
                hogy mi a különbség a Console.Read és a Console.ReadLine működése között.2
                Magyarázat:  A Read és a ReadLine alapvetően a beolvasott adat típusában különböznek egymástól. 
                Míg az első szöveges adatot olvas be, a második a megadott karakter kódjával tér vissza, vagyis egy számmal. 
                Ezért, ha számokat olvasunk be, akkor a ReadLine-t, amennyiben csak egy karaktert, a Read-et kell használnunk.
             */
            Console.WriteLine("Adj meg egy szöveget(ReadLine): ");
            var b = Console.ReadLine();
            Console.WriteLine("Adj meg egy karaktert(Read): ");
            var a = Console.Read();
            Console.WriteLine("Console.ReadLine() által beolvasott adat típusa: {0}, és értéke: {1}", b.GetType(), b);
            Console.WriteLine("Console.Read() által beolvasott adat típusa: {0}, és értéke: {1}", a.GetType(), a); 
        }
        static void feladat4()
        {
            /*
                3.4. feladat (Konzol képernyő használata – szint: 1).
                Írassuk ki a képernyőre az alábbi számsorozatokat:
                   4 3 2 1
                   4 3 2
                   4 3
                   4 
                Próbáljuk meg úgy elkészíteni a programot, hogy a Console.WritemelletLine() csak egyszer szerepeljen a programban.
                Magyarázat: A kiíró utasításban a formázáshoz elhelyezhetünk a kiírandó szövegben \n jeleket, melyek törik a sort.
                Ezzel megoldható a lehető legkevesebb kiírás használata mellett a kívánt kimenet előállítása.
             */
            Console.Write("4 3 2 1\n4 3 2\n4 3\n4");
        }
        static void feladat5()
        {
            /*
                3.5. feladat (Szállásszervezés – szint: 1).  Készítsünk programot, mely osztálykirándulás szervezésében segíti a használóját, 
                melyhez a lehető legkedvezőbb szállásárat kellene elérni. A kiválasztott hotelben többféle kedvezményt adnak a diákoknak, 
                egyszerre közülük csak az egyik vehető igénybe:
                Csoportos kedvezmény: 
                    - 10 fő alatt 0 %;
                    - 10-19 fő esetén 5 %;
                    - 20-29 fő esetén 8 %;
                    - 30-40 fő esetén 12 %; 
                    - 40 fő felett 14 % a kedvezmény mértéke.
                Intézményi kedvezmény: 
                    - 5 fő alatt nincs; 
                    - 5-11 fő esetén 1 fő ingyen szálláshoz jut; 
                    - 12-19 fő esetén 2 fő ingyenes; 
                    - 20-28 fő esetén 3 fő ingyenes;
                    - 29-40 fő esetén 4 fő, 
                    - míg 40 fő felett 5 fő kap ingyenes szállást.
                Diákkedvezmény: egyénileg is jár, mértéke 10
                Készítsen programot, amely beolvassa a kiránduláson résztvevők számát majd megadja, 
                hogy a háromféle kedvezményből melyiket kell igénybe venni, hogy a lehető legkevesebbe kerüljön a szállás!
             */
            Console.Write("Add meg a résztvevők számát: ");
            int resztvevok = Int32.Parse(Console.ReadLine());
            Szallas szallas = new Szallas(resztvevok);
            Console.WriteLine($"A jegyek ára kedvezményesen: {szallas.ajalnat()} Ft {resztvevok} főre.");
        }
        static void feladat6()
        {
            /*
                    3.6. feladat (Kocka – szint: 2). Egy n cm (n>1 egész szám) oldalhosszúságú fakockát piros festékbe mártunk, 
                majd 1 cm élű kiskockákra felfűrészeljük. Hány kis kocka lesz, amelynek 
                    pontosan egy oldallapja pirosra festett?
                    pontosan két oldallapja piros?
                    pontosan 3 lapja piros?
                    egyik lapja sem piros?
                Készítsünk C# programot, amely a felvázolt problémát implementálja!
             */
            Console.Write("Add meg a kocka oldalhosszát: ");
            int oldalhossz = 0;
            while (!Int32.TryParse(Console.ReadLine(),out oldalhossz) || oldalhossz<2)
            {
                Console.Write("Csak egynél nagyobb egész szám adható meg! Próbáld újra: ");
            }
            int egyiksempiros = oldalhossz > 2 ? (oldalhossz) - (2 * oldalhossz) - 2 * (oldalhossz - 2) : 0;
            int egypiros = oldalhossz>2?(oldalhossz-2)*(oldalhossz-2)*6:0;
            int kettopiros = oldalhossz>2?8*(oldalhossz-2):0;
            int harompiros = oldalhossz > 1 ? 8: 0;
            Console.WriteLine($"A(z) {oldalhossz} oldal hosszú kockából kivágott kockák közül:");
            Console.WriteLine($"\t- {egypiros} kockának egy oldallapja piros");
            Console.WriteLine($"\t- {kettopiros} kockának kettő oldallapja piros");
            Console.WriteLine($"\t- {harompiros} kockának három oldallapja piros");
            Console.WriteLine($"\t- {egyiksempiros} kockának egyetlen oldallapja sem piros");
        }
        static void feladat7()
        {
            /*
                3.7. feladat (Melyik szám a nagyobb – szint: 1). Készítsünk konzolos alkalmazást, amely bekér két egész számot,
                majd eldönti, hogy melyik a nagyobb. A két számot int típusú változókban tároljuk el.
                Amennyiben a két megadott szám azonos értékű, a bekérést ismételjük meg.
                Magyarázat: A megoldáshoz használjunk feltételes elágazást. Rossz adatok megadásakor az ismétlést folytassuk mindaddig,
                amíg helyes adatokat nem kapunk.
                A 3.5 forrásszövegben találjuk meg a feladat megoldását.
             */
            int a = 0, b = 0;
            while (a == b)
            {
                Console.WriteLine("Kérem az első számot: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Kérem a második számot: ");
                b = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A megadott {a} és {b} közül {(a > b ? a : b)} a nagyobb!");


        }
        static void feladat8()
        {
            /*
                3.8. feladat (Osztályzatok – szint: 1). Írjon programot, amely bekér egy informatika osztályzatot, 
                majd kiírja a szülők véleményét az eredményről. A program a „nemlétező” osztályzatokra is reagáljon.
                A 3.7 forrásszövegben találjuk a megoldást.
             */
            Console.Write("Kérem az informatika jegyet véleményezésre: ");
            var oszt = Console.ReadLine();
            switch (oszt)
            {
                case "5":
                    Console.WriteLine("Nagyon ügyes!");
                    break;
                case "4":
                    Console.WriteLine("Elmegy");
                    break;
                case "3":
                    Console.WriteLine("Ez mi?!");
                    break;
                case "2":
                    Console.WriteLine("2 hét szobafogság");
                    break;
                case "1":
                    Console.WriteLine("Szobafogság egész nyáron!");
                    break;
                default:
                    Console.WriteLine("Nem létezik ilyen jegy!");
                    break;
            }
        }
        static void feladat9()
        {
            /*
                 3.9. feladat (Számok sorrendje – szint: 1). Kérjünk be a billentyűzetről három egész számot, majd döntsük el,
                hogy melyik a legnagyobb, és a legkisebb érték.
                Magyarázat: Ez a feladat hasonlít az ismert rendező algoritmusokra annyiban, hogy a kapott értékeket sorrendbe rakja,
                de a megoldás nem rugalmas, mivel a rendezendő elemek száma erősen korlátozott…
                A 3.6 forrásszövegben találjuk a megoldást, a program kimenetét pedig a 3.5 ábrán láthatjuk.
             */
            List<int> szamok = new List<int>()
            {
                int.Parse(adatbekeres("Kérem az első számot: ")),
                int.Parse(adatbekeres("Kérem a második számot: ")),
                int.Parse(adatbekeres("Kérem a harmadik számot: "))
            };
            Console.WriteLine("A megadott számok közül a legnagyobb: {0}",szamok.Max());
            Console.WriteLine("A megadott számok közül a legkisebb: {0}", szamok.Min());
        }
        static void feladat10()
        {
            /*
                3.10. feladat (Szerkeszthető háromszögek – szint: 1). Készítsünk konzol programot, amely bekér három egész számot a billentyűzetről. 
                A bekért számokra úgy tekintünk, mint egy háromszög oldalaira. Döntsük el, hogy a háromszög szerkeszthető-e.
                Magyarázat: A háromszög abban az esetben szerkeszthető, ha bármely két oldal hosszának az összege nagyobb a harmadik oldal hosszánál.
                A 3.8 forrásszövegben találjuk a megoldást, a program kimenetét pedig a 3.6 ábrán láthatjuk.
             */
            int a = int.Parse(adatbekeres("Kérem az A oldalt: "));
            int b = int.Parse(adatbekeres("Kérem a B oldalt: "));
            int c = int.Parse(adatbekeres("Kérem a C oldalt: "));
            if (a + b > c && a + c > b && c + b > a)
            {
                Console.WriteLine("A háromszög szerkeszthető");
            } else
            {
                Console.WriteLine("A háromszög nem szerkeszthető");
            }
        }
        static void feladat11()
        {
            /*
                 3.11. feladat (Háromszög típusa – szint: 1). Készítsünk konzol programot, amely bekér három egész számot a billentyűzetről.
                A bekért számokra úgy tekintünk, mint egy háromszög oldalaira. Döntsük el, hogy a háromszög egyenlő oldalú, illetve egyenlő szárú háromszög-e.
                A 3.9 forrásszövegben találjuk a megoldást, a program kimenetét pedig a 3.7 ábrán láthatjuk.
             */
            int a = int.Parse(adatbekeres("Kérem az A oldalt: "));
            int b = int.Parse(adatbekeres("Kérem a B oldalt: "));
            int c = int.Parse(adatbekeres("Kérem a C oldalt: "));
            if (a == c && a == b)
            {
                Console.WriteLine("A háromszög egyenlő oldalú");
                return;
            }
            if (a == b || a == c || b == c)
            {
                Console.WriteLine("A háromszög egyenlő oldalú");
                return;
            }
            Console.WriteLine("Sima mezei háromszög");
        }
        static void feladat12()
        {
            /*          
                3.12. feladat (Háromszög kerülete – szint: 1). Készítsünk konzol programot, amely bekér három egész számot a billentyűzetről.
                A bekért számokra úgy tekintünk, mint egy háromszög oldalaira. Számítsuk ki a háromszög kerületét és területét.
                Magyarázat: A kerület kiszámítása nem okoz különösebb problémát, mivel egyenlő az oldalak hosszának az összegével. 
                Amennyiben helyes programot szeretnénk készíteni figyeljünk arra is, hogy a háromszög szerkeszthető-e.
                A 3.10 forrásszövegben találjuk a megoldást, a program kimenetét pedig a 3.8 ábrán láthatjuk.
             */
            int a = int.Parse(adatbekeres("Kérem az A oldalt: "));
            int b = int.Parse(adatbekeres("Kérem a B oldalt: "));
            int c = int.Parse(adatbekeres("Kérem a C oldalt: "));
            if (a + b > c && a + c > b && c + b > a)
            {
                int k = a + b + c;
                double s = k / 2;
                double t = Math.Pow(s * (s - a) * (s - b) * (s - c),2);
                Console.WriteLine("A háromszög kerülete: {0}", k);
                Console.WriteLine("A háromszög területe: {0}", t);
            } else
            {
                Console.WriteLine("Nem létezik ilyen háromszög");
            }
                

        }
        static void feladat13()
        {
            /*
                3.13. feladat (Háromszög területe - Héron képlet – szint: 2). Készítsünk konzol programot, amely bekér három egész számot a billentyűzetről.
                A bekért számokra úgy tekintünk, mint egy háromszög oldalaira. Számítsuk ki a háromszög területét. A terület kiszámításához használhatjuk a Hérón képletet.
                Magyarázat: A Hérón képlet segítségével a háromszög területét az oldalak hosszából is ki tudjuk számolni 
                Az a, b és c a háromszög oldalai a  képlettel számolhatók ki, ahol S a háromszög kerületének a fele
                A 3.11 forrásszövegben találjuk a megoldást, a program kimenetét pedig a 3.13 ábrán láthatjuk.
                3.9. ábra. A háromszög területe
             */
            feladat12();
        }
        static void feladat14()
        {
            /*
                3.14. feladat (Majdnem Lottó – szint: 1). Generáljunk tíz darab 1-6 közé eső véletlen számot. 
                A program ezután mondja meg hányszor volt hatos a generált érték!
                Magyarázat: A véletlen számok generálásához használjuk a Random osztály szolgáltatásait.
                      Random R = new Random();
                    int adat = R.Next(); 
                A generált számokat nem kell tárolnunk, mivel minden értékről azonnal eldönthető, hogy az 6-os, vagy sem.
             */
            Random rnd = new Random(1);
            List<int> szamok = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                szamok.Add(rnd.Next(1, 7));
                Console.Write("{0} ",szamok.Last());
            }
            
            Console.WriteLine("\n{0}-szor volt hatos.",szamok.Where(szam=>szam==6).Count());
        }
        static void feladat15()
        {
            /*
                3.15. feladat (Szóközök – szint: 1). Kérjünk be egy mondatot, majd írjuk ki szóközök nélkül. A 3.13 forrásszövegben találjuk a megoldást.
             */
            Console.WriteLine("Kérek egy mondatot: ");
            string mondat = Console.ReadLine();
            Console.WriteLine(mondat.Replace(" ", ""));
        }
        static void feladat16()
        {
            /*
                3.16. feladat (Sorozatok – szint: 2). Készítsünk olyan konzolos alkalmazást, amely beolvassa egy számtani sorozat első elemét, 
                valamint a differenciáját, és egy tetszőleges N értéket, majd kiírja a sorozat  elemét, és az első N tagja összegét.
             */
            Console.Write("Add meg a sorozat első elemét: ");
            decimal elso = decimal.Parse(Console.ReadLine());
            Console.Write("Add meg a sorozat differenciáját: ");
            decimal diff = decimal.Parse(Console.ReadLine());
            Console.Write("Kiírandó elemszám: ");
            int elemszam = int.Parse(Console.ReadLine());
            decimal osszeg = 0;
            for (int i = 0; i < elemszam; i++)
            {
                osszeg += elso;
                Console.Write($"{elso} ");
                elso += diff;
                
            }
            Console.WriteLine("Összege: {0}",osszeg);
        }
        static void feladat17()
        {
            /*
                3.17. feladat (Command Line Interface – szint: 1). Készítsünk egy egyszerű parancssori programot, amely néhány menüponttal rendelkezik. 
                A menüpontok kiírására használjuk a Console osztály kiíró utasításait.
                A menü a következőképp nézzen ki:
                    1 Első menüpont
                    2 második menüpont
                    3 Harmadik menüpont
                    4 Negyedik menüpont
                    5 Kilépés 
                A program közvetlenül az elindítása után írja ki a menüket a képernyőre, majd olvasson be egy karaktert.
                Amennyiben a beolvasott adat az 1-5 intervallumba eső szám, úgy a képernyőre íródjon ki, hogy melyik menüpont került kiválasztásra, ellenkező esetben jelenjen meg a Rossz választás felirat.
                Magyarázat: A program elkészítése során alkalmazhatjuk a switch vezérlő szerkezetet annak az eldöntésére,
                hogy a beolvasott szám beleesik-e a menüpontoknál definiált intervallumba. Hiba esetén a switch default ága írja ki a hibaüzenetet a képernyőre.
             */
            Console.WriteLine("1 Első menüpont");
            Console.WriteLine("2 második menüpont");
            Console.WriteLine("3 Harmadik menüpont");
            Console.WriteLine("4 Negyedik menüpont");
            Console.WriteLine("5 Kilépés");
            char m = (char)Console.Read();
            switch (m)
            {
                case '1':
                    Console.WriteLine("Első menüpont");
                    break;
                case '2':
                    Console.WriteLine("Második menüpont");
                    break;
                case '3':
                    Console.WriteLine("Harmadik menüpont");
                    break;
                case '4':
                    Console.WriteLine("Negyedik menüpont");
                    break;
                case '5':
                    Console.WriteLine("Kilépés menüpont");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen menüpont!");
                    break;
            }
        }
        static void feladat18()
        {
            /*
                3.18. feladat (A hét napjai – szint: 1). Készítsünk konzolos alkalmazást, amely paraméterként kap egy egész számot (int),
                majd kiírja a hét azonos sorszámú napját a képernyőre.
                Az 1-es érték jelenti a hétfőt, a 2-es a keddet, a 7-es a vasárnapot. Amennyiben a megadott szám nem esik az 1-7 intervallumba,
                a program írjon hibaüzenetet a képernyőre.
             */
            int nap = 0;
            Console.Write("Kérek egy számot 1-7ig: ");
            while(!Int32.TryParse(Console.ReadLine(),out nap) || nap<1 || nap > 7)
            {
                Console.WriteLine("Hiba: 1-7 eső szám elfogadott!");
            }
            Console.WriteLine((DayOfWeek)nap);
        }
        static void feladat19()
        {
            /*
                3.19. feladat (Életkorok – szint: 1). Készítsünk alkalmazást, amely beolvassa egy személy életkorát (),
                majd a kapott adat fényében kiírja a képernyőre azt a korosztályt, amibe az életkor „tulajdonosa” tartozik.
                    Gyermek (0-6),
                    Iskolás (7-22),
                    Felnőtt (22-64),
                    65 töl nyugdíjas!
             */
            Console.Write("Add meg az életkort: ");
            int kor = Int32.Parse(Console.ReadLine());
            if (kor<7)
            {
                Console.WriteLine("Gyerek");
            }
            if (kor>=7 && kor<23)
            {
                Console.WriteLine("Gyerek");
            }
            if (kor>=23 && kor<65)
            {
                Console.WriteLine("Felnőtt");
            }
            if (kor>=65)
            {
                Console.WriteLine("Nyugdíjas");
            }
        }
        static string adatbekeres(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
    class Szallas
    {
        public int alapar = 1000;
        public int resztvevok = 0;
        public string kedvezmeny_tipus = "Nincs kedvezmény";
        public Szallas(int resztvevok)
        {
            this.resztvevok = resztvevok;
        }
        public double csoportos()
        {
            if (this.resztvevok >= 10 && this.resztvevok <= 19) return this.resztvevok * this.alapar * 0.95;
            if (this.resztvevok >= 20 && this.resztvevok <= 29) return this.resztvevok * this.alapar * 0.92;
            if (this.resztvevok >= 30 && this.resztvevok <= 41) return this.resztvevok * this.alapar * 0.88;
            if (this.resztvevok > 40) return this.resztvevok * alapar * 0.86;
            return resztvevok * alapar;
        }
        public double intezmenyi()
        {
            if (this.resztvevok >= 5 && this.resztvevok <= 11) return (this.resztvevok - 1) * this.alapar;
            if (this.resztvevok >= 12 && this.resztvevok <= 19) return (this.resztvevok - 2) * this.alapar;
            if (this.resztvevok >= 20 && this.resztvevok <= 28) return (this.resztvevok - 3) * this.alapar;
            if (this.resztvevok >= 29 && this.resztvevok <= 40) return (this.resztvevok - 4) * this.alapar;
            if (this.resztvevok > 40) return (this.resztvevok - 5) * this.alapar;
            return this.resztvevok * this.alapar;
        }
        public double diak()
        {
            return this.resztvevok * this.alapar * 0.90;
        }
        public double ajalnat()
        {
            double[] x = { this.alapar*this.resztvevok, this.csoportos(), this.intezmenyi(), this.diak() };
            return x.Min();
        }
    }
}
