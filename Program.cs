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

            Santa Santa_Claus = new Santa("Mos Craciun", "verde", 99, 20);

            MechanicElf Melf = new MechanicElf("Dinu", "Alask", 29, 2, 123, 4);


            // o zi la Polul Nord

            Dimineata dim = new Dimineata();

            dim.Soare();

            // mosul are in vedere niste copii

            Children copil1 = new Children("Ada", "Onesti", "un unicorn", 7);
            Children copil2 = new Children("Horatiu", "Valenii de Munte", "pacea-n lume", 1);              

            string[] SantaGiftBag = new string[50]; // sacul in care vom salva jucariile copiilor
            int k;                     

            // mosul cere mai multe jucarii pe care le pune in sac si niste mancare

            Random rnd = new Random();
 
            // si pe langa niste jucarii pe care le duce pentru copii din afirca
            // *astia merita chit ca au fost buni sau rai*
            for (int i = 0; i < 5; i ++)
            {
                k = rnd.Next(0, 4);
                SantaGiftBag[i] = GMelf.GetGift(k);
            }

            // mosul vrea sa verifice si daca copii lui au fost cuminti sau nu
           
            if (copil1.DoesHeDeserveGifts() != 0)
            {
                SantaGiftBag[5] = copil1.Gift;
                Console.WriteLine("{0} isi primeste cadoul", copil1.Name);
            }
            else 
            {
                Console.WriteLine("{0} primeste carbuni!", copil1.Name);
            }

            if (copil2.DoesHeDeserveGifts() != 0)
            {
                SantaGiftBag[6] = copil2.Gift;
                Console.WriteLine("{0} isi primeste cadoul", copil2.Name);
            }
            else 
            {
                Console.WriteLine("{0} primeste carbuni!", copil2.Name);
            }

            // dupa atata munca e timpul si pentru niste mancare

            k = rnd.Next(0, 3);
            Console.WriteLine("La masa avem {0}", Celf.GetFood(k));

            // dupa ce atat sacul cat si burta mosului sunt pline
            // mosul decide sa cheme renii de craciun
            // pentru ca ei s-au antrenat din greu el are nevoie doar de doi

            TryHardReindeer Ren1 = new TryHardReindeer("Sven", 10, 2, 8);
            TryHardReindeer Ren2 = new TryHardReindeer("Mithy", 12, 4, 6);

            Console.WriteLine("O, dar vai, cine a venit! Sunt chiar {0} si {1} renii de nadejde ai mosului!", Ren1.Name, Ren2.Name);

            // elful mecanic verifica daca sania este incarcata

            Melf.ItsEquipped();

            // mosul verifica daca sania porneste

            Santa_Claus.LetsRide();

            // si pleaca sa livreze cadourile
        }
    }
}
