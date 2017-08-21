using System;
using System.Collections.Generic;

namespace igiDaily_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var Medic = new Medic("Mike", "Kings Guard", 1234, new Sniper());

            var Sailor =  new Sailor("Paul", "capt", 123455, new Pistol());
            var Infantry = new Infantry("Rodger", "General", 5678);
            
            Console.WriteLine(Medic);
            Console.WriteLine(Sailor);
            Console.WriteLine(Infantry);

            var Army = new List<Soldier>();
            Army.Add(Medic);
            Army.Add(Sailor);
            Army.Add(Infantry);

            Army.ForEach(fighter => fighter.Speak());
            Army.ForEach(fighter => fighter.Weapon.Action());
            Army.ForEach(fighter => fighter.Weapon.Shoot());

        }
    }
}
