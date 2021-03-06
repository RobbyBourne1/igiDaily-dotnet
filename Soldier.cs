using System;

namespace igiDaily_dotnet
{
    public abstract class Soldier
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int SerialNumber { get; set; }

        public IWeapon Weapon {get;set;}

        public Soldier(string name, string rank, int serialNumber, IWeapon weapon)
        {
            Name = name;
            Rank = rank;
            SerialNumber = serialNumber;
            Weapon = weapon;
        }

        public abstract void Speak();

        public void Sleep()
        {
            Console.WriteLine("Snore.....ZZzzzzz");
        }

        public void Eat()
        {
            Console.WriteLine("Yummmmm");
        }

        public void March()
        {
            Console.WriteLine("Left...Left..Left, Right, Left");
        }

    }
}