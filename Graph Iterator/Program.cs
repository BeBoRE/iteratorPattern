using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Iterator
{
    class Program
    {
        static void Main()
        {
            Persoon p1 = new Persoon("Bart");

            Persoon p2 = new Persoon("Lucas");
            p1.addFriend(p2);

            Persoon p3 = new Persoon("Ayrton");
            p1.addFriend(p3);

            Persoon p4 = new Persoon("Marco");
            p1.addFriend(p4);

            p4.addFriend(p3);

            Persoon p5 = new Persoon("Koningin Beatrix");
            p2.addFriend(p5);

            Persoon p6 = new Persoon("Elon");
            p6.addFriend(p5);
            p6.addFriend(p3);

            Persoon p7 = new Persoon("Youri");
            p7.addFriend(p6);
            p7.addFriend(p4);

            Persoon p8 = new Persoon("Rick Sanchez");
            p8.addFriend(p6);
            p8.addFriend(p7);

            Persoon p9 = new Persoon("X Æ A-12");
            p9.addFriend(p6);

            Persoon p10 = new Persoon("Morty");
            p10.addFriend(p8);

            Persoon p11 = new Persoon("Mr. PBH");
            p11.addFriend(p8);

            Bevolking bevolking = new Bevolking(p1);

            foreach (Persoon p in bevolking) Console.WriteLine(p.naam);
        }
    }
}
