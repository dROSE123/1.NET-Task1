using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            GiftMakerElf GMelf = new GiftMakerElf("Gigel", "Mirel", 12, 1, "ciocanul");

            // lista de cadouri pe care stie sa le faca
            GMelf.GiftList("robot", "masina", "pusca", "papusa");


            CookElf Celf = new CookElf("Viorel", "Rebelu", 13, 1, "lingura");

            // lsita de preparate pe care stie sa le faca
            Celf.FoodtList("tort de branza", "ceai de musetel", "piftie");


            AdminElf Aelf = new AdminElf("Bostan", "Marcel", 20, 2, "C", "sudo rm -rf");

            InfrastructureElf Ielf = new InfrastructureElf("Tibi", "Useriu", 14, 1, "Pascal", "Imi place sa dau cu capul de pereti");

            Santa Santa_Claus = new Santa("Mos Craciun", "verde", 99, 70);

            MechanicElf Melf = new MechanicElf("Dinu", "Alask", 29, 2);


            // o zi la Polul Nord

            // mosul are in vedere niste copii

            Children copil1 = new Children("Ada", "Onesti", "un unicorn", 7);
            Children copil2 = new Children("Horatiu", "Valenii de Munte", "pacea-n lume", 1);              

            string[] SantaGiftBag = new string[50]; // sacul in care vom salva jucariile copiilor
            int k;
            int nr_gifts = 5;              

            // mosul cere mai multe jucarii pe care le pune in sac si niste mancare

            Random rnd = new Random();
 
            // si pe langa niste jucarii pe care le duce pentru copii din afirca
            // *astia merita chit ca au fost buni sau rai*
            for (int i = 0; i < nr_gifts; i ++)
            {
                k = rnd.Next(0, nr_gifts - 1);
                SantaGiftBag[i] = GMelf.GetGift(k);
            }

            // mosul vrea sa verifice si daca copii lui au fost cuminti sau nu
           
            if (copil1.DoesHeDeserveGifts() != 0)
            {
                SantaGiftBag[5] = copil1.Gift;
                Console.WriteLine("{0} isi primeste cadoul", copil1.Name);
                nr_gifts ++;
            }
            else 
            {
                Console.WriteLine("{0} primeste carbuni!", copil1.Name);
            }

            if (copil2.DoesHeDeserveGifts() != 0)
            {
                SantaGiftBag[6] = copil2.Gift;
                Console.WriteLine("{0} isi primeste cadoul", copil2.Name);
                nr_gifts++;
            }
            else 
            {
                Console.WriteLine("{0} primeste carbuni!", copil2.Name);
            }

            // dupa atata munca e timpul si pentru niste mancare
            // si de aceea el are nevoie de un elf bucatar sa ii gateasca

            k = rnd.Next(0, 3);
            Console.WriteLine("La masa avem {0}", Celf.GetFood(k));

            // dupa ce atat sacul cat si burta mosului sunt pline
            // mosul decide sa-si cheme cei 2 renii de craciun
            // e criza si la polul nord

            TryHardReindeer Ren1 = new TryHardReindeer("Sven", 10, 2, 8);
            TryHardReindeer Ren2 = new TryHardReindeer("Mithy", 12, 4, 6);

            Console.WriteLine("O, dar vai, cine a venit! Sunt chiar {0} si {1} renii de nadejde ai mosului!", Ren1.Name, Ren2.Name);

            // elful mecanic verifica daca sania este incarcata
            // el trebuie sa stie numarul de cadouri din sanie
            // si pe baza unor formule din antichitate acesta va calcula daca sania este pregatita sau nu

            Melf.ItsEquipped(nr_gifts);

            // mosul verifica daca sania porneste
            // pentru asta el are nevoie sa isi cunoasca greutatea, nr de reni
            // si forta de tractiune a renilor

            Santa_Claus.LetsRide(2, Ren1.ReindeerPower());

            // din pacate Sven nu este indeajuns de puternic
            // cred ca mosul are nevoie de ambi reni

            Santa_Claus.LetsRide(2, Ren1.ReindeerPower() + Ren2.ReindeerPower());

            // se pare ca de aceasta data sania a pornit iar mosul a plecat sa livreze cadourile
            // si pleaca sa livreze cadourile

            Console.WriteLine("Hohoh! Sesiune usoara!");

        }
    }
}
