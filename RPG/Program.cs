using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> atributy = new Dictionary<string, int>();
            atributy.Add("STR", 10);
            atributy.Add("DEX", 10);
            atributy.Add("INT", 10);
            atributy.Add("STA", 10);

            Dictionary<string, int> shop = new Dictionary<string, int>();
            shop.Add("STR", 1);
            shop.Add("STA", 1);
            shop.Add("INT", 1);
            shop.Add("DEX", 1);

            int zkušenosti = 0;
            int penize = 0;
            int xp = 0;
            int levelup = 10;
            int level = 1;
            int unava = 0;
            int unava2 = 0;
            int perk = 0;
            int zdravi = atributy["STA"] * 10;

            int sila1 = 0;
            int obratnost1 = 0;
            int inteligence1 = 0;
            int vydrz1 = 0;
            int sila2 = 0;
            int obratnost2 = 0;
            int inteligence2 = 0;
            int vydrz2 = 0;
            int sila3 = 0;
            int obratnost3 = 0;
            int inteligence3 = 0;
            int vydrz3 = 0;
            int zivotyarena = 0;

            int sila = 0;
            int obratnost = 0;
            int inteligence = 0;
            int vydrz = 0;

            int poškození = 0;
            int krytikal = 0;
            int uhyb = 0;
            int poškození1 = 0;
            int krytikal1 = 0;
            int uhyb1 = 0;

            string perkroz = "";
            string koupě = "";

            bool zivot = true;
            bool obchod = true;
            bool zivotarena = true;

            int money = 0;

            Random run = new Random();

            Console.WriteLine("Zadej jméno:");
            string jmeno = Console.ReadLine();

            string[] schopnosti = { "STR", "DEX", "INT", "STA" };
            schopnosti[0] = ("Vzal jsi brigádu u dřevorbců a rubal stromy jako o závod");
            schopnosti[1] = ("Rozhodl jsi se roznášet poštu a při tom jsi se snažil pokořit rekord");
            schopnosti[2] = ("Pomohl jsi se k učenému čaroději při experimentu a zároveň sledoval a učil se");
            schopnosti[3] = ("Vydal jsi se do hlubokých dolů, kde ti ztvrdne kůže na kámen");

            while (zivot == true)
            {
                Console.WriteLine($"jmenuješ se {jmeno}");
                Console.WriteLine($"síla = {atributy["STR"]}");
                Console.WriteLine($"obratnost = {atributy["DEX"]}");
                Console.WriteLine($"inteligence = {atributy["INT"]}");
                Console.WriteLine($"výdrž = {atributy["STA"]}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"zdraví = {zdravi}");
                Console.ForegroundColor = ConsoleColor.White;
                if (unava2 > 100)
                {
                    Console.WriteLine("Pracoval jsi tak tvrdě že jsi navěky usnul");
                    zivot = false;
                    Thread.Sleep(2500);
                    break;
                }//I hope there is no bug
                int xpif = xp + zkušenosti;
                if (levelup <= xpif)
                {
                    Console.WriteLine("Zvýšila se ti úroveň");
                    xp -= levelup;
                    levelup += 10;
                    level++;
                    perk++;
                }//I hope there is no bug

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"xp = {xp += zkušenosti}/{levelup}");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"level = {level}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"body dovedností = {perk}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"zlaťáky = {money}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"unava = {unava2}%");
                Console.ForegroundColor = ConsoleColor.White;

                zkušenosti = 0;
                Console.WriteLine("Jsi na náměstí. Kam se chceš vydat.");
                string rozhodnutí = Console.ReadLine();
                if (rozhodnutí == "obchod")
                {
                    Console.WriteLine("jdeš do obchodu");
                    Thread.Sleep(1500);
                    while (obchod == true)
                    {
                        Console.Clear();
                        Console.WriteLine("jaký lektvar si koupíš?");
                        Console.Write("síly - ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("25");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("výdrže - ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("25");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("obratnosti - ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("25");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("inteligence - ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("25");
                        Console.ForegroundColor = ConsoleColor.White;
                        koupě = Console.ReadLine();
                        if (koupě == "síly" && money >= 25)
                        {
                            Console.WriteLine("koupil jsi lekvar síly");
                            money -= 25;
                            atributy["STR"] += shop["STR"];
                        }
                        if (koupě == "výdrže" && money >= 25)
                        {
                            Console.WriteLine("koupil jsi ");
                            money -= 25;
                            atributy["STA"] += shop["STA"];
                        }
                        if (koupě == "obratnosti" && money >= 25)
                        {
                            Console.WriteLine("koupil jsi lektvar obratnosti");
                            money -= 25;
                            atributy["DEX"] += shop["DEX"];
                        }
                        if (koupě == "inteligence" && money >= 25)
                        { 
                            Console.WriteLine("koupil jsi lektvar inteligence");
                            money -= 25;
                            atributy["INT"] += shop["INT"];
                        }
                        Console.WriteLine("Chceš zůstat v obchodě");
                        koupě = Console.ReadLine();
                        if (koupě == "ano")
                        {
                            obchod = true;
                            Console.WriteLine("zůstal jsi v obchodě");
                        }
                        if (koupě == "ne")
                        {
                            obchod = false;
                            Console.WriteLine("Jdeš na náměstí");
                            Thread.Sleep(2500);
                        }
                    }
                    obchod = true;
                }//maybe done
                if (rozhodnutí == "aréna")
                {
                    Console.Clear();
                    Console.WriteLine("jdeš do arény");
                    Thread.Sleep(1500);
                    Console.WriteLine("zde jsou tví protivníci");
                    Console.WriteLine("protivník číslo 1");
                    Console.WriteLine($"- síla = {sila1 =level * run.Next(1, 11)}");
                    Console.WriteLine($"- obratnost = {obratnost1 = level * run.Next(1, 11)}");
                    Console.WriteLine($"- inteligence = {inteligence1 = level * run.Next(1, 11)}");
                    Console.WriteLine($"- výdrž = {vydrz1 = level * run.Next(1, 11)}");
                    Console.WriteLine("protivník číslo 2");
                    Console.WriteLine($"- síla = {sila2 = level * run.Next(1, 11)}");
                    Console.WriteLine($"- obratnost = {obratnost2 = level * run.Next(1, 11)}");
                    Console.WriteLine($"- inteligence = {inteligence2 = level * run.Next(1, 11)}");
                    Console.WriteLine($"- výdrž = {vydrz2 = level * run.Next(1, 11)}");
                    Console.WriteLine("protivník číslo 3");
                    Console.WriteLine($"- síla = {sila3 = level * run.Next(1, 11)}");
                    Console.WriteLine($"- obratnost = {obratnost3 = level * run.Next(1, 11)}");
                    Console.WriteLine($"- inteligence = {inteligence3 = level * run.Next(1, 11)}");
                    Console.WriteLine($"- výdrž = {vydrz3= level * run.Next(1, 11)}");
                    Console.WriteLine("vyber si číslo");
                    string arena = Console.ReadLine();
                    Console.Clear();
                    if (arena == "1")
                    {
                        sila = sila1;
                        obratnost = obratnost1;
                        inteligence = inteligence1;
                        vydrz = vydrz1;
                    }
                    if (arena == "2")
                    {
                        sila = sila2;
                        obratnost = obratnost2;
                        inteligence = inteligence2;
                        vydrz = vydrz2;
                    }
                    if (arena == "3")
                    {
                        sila = sila3;
                        obratnost = obratnost3;
                        inteligence = inteligence3;
                        vydrz = vydrz3;
                    }
                    if (arena == "1" || arena == "2" || arena == "3")
                    {
                        int prvniutok = run.Next(1, 3);
                        zivotyarena = vydrz * 10;
                        while (zivot == true && zivotarena == true)
                        {
                            if (prvniutok == 1 && zivotarena == true)
                            {
                                poškození = atributy["STR"];
                                krytikal = run.Next(0, 101);
                                uhyb1 = run.Next(0, 101);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Zaútočil jsi");
                                Thread.Sleep(500);
                                if (atributy["INT"] >= krytikal)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Způsobil jsi dvojnásobné poškození");
                                    Thread.Sleep(500);
                                    poškození = 2 * poškození;
                                }
                                if (obratnost >= uhyb1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("protivník se vyhnul");
                                    Thread.Sleep(500);
                                    poškození = 0;
                                }
                                zivotyarena -= poškození;
                                prvniutok++;
                            }
                            if (zivotyarena <= 0 && zivotarena == true)
                            {
                                Console.WriteLine("tvůj protivník zemřel");
                                Thread.Sleep(1500);
                                zivotarena = false;
                                Console.ForegroundColor= ConsoleColor.Magenta;
                                Console.WriteLine($"unavil jsi se na {unava2 += 25}%");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                int moneyarena = 100;
                                int xparena = 15;
                                Console.WriteLine($"vyhrál jsi {100} zlatáků");
                                money += moneyarena;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Z boje jsi si odnesl {15} zkušeností");
                                xp += xparena;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (zdravi <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Zemřel jsi");
                                zivot = false;
                                Thread.Sleep(2500);
                                break;
                            }
                            if (prvniutok == 2 && zivotarena == true)
                            {
                                poškození1 = sila;
                                krytikal1 = run.Next(0, 101);
                                uhyb = run.Next(0, 101);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Protivník útočí");
                                Thread.Sleep(500);
                                if (inteligence >= krytikal1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Protivník způsobuje dvojnásobné poškození");
                                    Thread.Sleep(500);
                                    poškození1 = 2 * poškození1;
                                }
                                if (obratnost >= uhyb)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("vyhnul jsi se");
                                    Thread.Sleep(500);
                                    poškození1 = 0;
                                }
                                zdravi -= poškození1;
                                prvniutok--;
                            }
                            if (zivotyarena <= 0 && zivotarena == true)
                            {
                                Console.WriteLine("tvůj protivník zemřel");
                                Thread.Sleep(1500);
                                zivotarena = false;
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine($"unavil jsi se na {unava2 += 25}%");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"vyhrál jsi {money += 100} zlatáků");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"Z boje jsi si odnesl {xp += 15} zkušeností");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (zdravi <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Zemřel jsi");
                                zivot = false;
                                Thread.Sleep(5000);
                                break;
                            }
                        }
                        Thread.Sleep(3000);
                        zivotarena = true;
                        Console.ForegroundColor= ConsoleColor.White;
                        Console.Clear();
                    }

                }//done
                if (rozhodnutí == "práce")
                {
                    Console.Clear();
                    int cisloukolu = run.Next(0, 4);
                    Console.WriteLine(schopnosti[cisloukolu]);
                    Thread.Sleep(level * 2500);
                    if (cisloukolu == 0)
                    {
                        atributy["STR"] += 1;
                        Console.WriteLine("síla se zvyšuje o 1");
                    }
                    if (cisloukolu == 1)
                    {
                        atributy["DEX"] += 1;
                        Console.WriteLine("obratnost se zvyšuje o 1");
                    }
                    if (cisloukolu == 2)
                    {
                        atributy["INT"] += 1;
                        Console.WriteLine("inteligence se zvyšuje o 1");
                    }
                    if (cisloukolu == 3)
                    {
                        atributy["STA"] += 1;
                        Console.WriteLine("výdrž se zvyšuje o 1");
                    }
                    unava = run.Next(5, 11);
                    zkušenosti = run.Next(1, 6);
                    penize = run.Next(1, 26);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Získal jsi {zkušenosti} zkušeností. Myslíš se že si se toho tolik naučil.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Získal jsi {penize} zláťáků. No nediv se dostal jsi tolik kolik sis zasloužil.");
                    Console.ForegroundColor= ConsoleColor.Magenta;
                    Console.WriteLine($"Unavil jsi se na {unava}%. Ale máš pocit že jsi hory přenášel.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"vracíš se zpět do města");
                    money += penize;
                    unava2 += unava;
                    Thread.Sleep(2500);
                    Console.Clear();
                }//done
                if (rozhodnutí == "domů")
                {
                    Console.WriteLine("vydal jsi se domů");
                    Thread.Sleep(1500);
                    Console.WriteLine("Chceš se jít vyspat nebo meditovat?");
                    string spanekmed = Console.ReadLine();
                    if (spanekmed == "meditovat")
                    {
                        Console.WriteLine("Jakou dovednost si chceš zlepšit");
                        perkroz = Console.ReadLine();
                        if (perkroz == "síla" && perk >= 1)
                        {
                            Console.WriteLine("cítíš že jsi se stal silnějším");
                            atributy["STR"] += atributy["STR"] + perk;
                            perk -= 1;
                        }
                        if (perkroz == "obratnost" && perk >= 1)
                        {
                            Console.WriteLine("Obratně jsi se dostal k závěru že jsi obratnější");
                            atributy["DEX"] += atributy["DEX"] + perk;
                            perk -= 1;
                        }
                        if (perkroz == "inteligence" && perk >= 1)
                        {
                            Console.WriteLine("Chápeš že se ti inteligence zvýšila");
                            atributy["INT"] += atributy["INT"] + perk;
                            perk -= 1;
                        }
                        if (perkroz == "výdrž" && perk >= 1)
                        {
                            Console.WriteLine("všímáš si že ti kůže ztvrdla");
                            atributy["STA"] += atributy["STA"] + perk;
                            perk -= 1;
                        }
                    }
                    if (spanekmed == "spát")
                    {
                        Console.WriteLine("Šel jsi spát");
                        Thread.Sleep(unava2 * 125);
                        unava2 = 0;
                        Console.WriteLine("už nejsi unavený");
                    }
                    Console.WriteLine("Vracíš se na náměstí");
                    Thread.Sleep(1500);
                    Console.Clear();
                }//done
                if (rozhodnutí == "chrám")
                {
                    Console.WriteLine("jdeš do chrámu");
                    Thread.Sleep(1500);
                    Console.WriteLine("chceš se nechat vyléčit");
                    string chram = Console.ReadLine();
                    if (chram == "ano")
                    {
                        int zdravichram = atributy["STA"] * 10;
                        zdravichram -= zdravi;
                        money -= zdravichram;
                        zdravi = atributy["STA"] * 10;
                        Console.WriteLine("Jsi zase plný života, ale s prázdnou peněženkou");
                    }
                    if (chram == "ano" || chram != "ano")
                    {
                        Console.WriteLine("vracíš se na náměstí");
                        Thread.Sleep(1500);
                    }
                    Console.Clear();
                }//done
            }//probably done //I hope there are no bugs
        }
    }
}
//pracovali : Šindler, Nezastrčil, Flusmann, DR. Mráček
//skupina : T5