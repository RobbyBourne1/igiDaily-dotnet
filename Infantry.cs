using System;

namespace igiDaily_dotnet
{
    public class Infantry : Soldier, IWeapon
    {
        public Infantry(string name, string rank, int serialNumber) : base(name, rank, serialNumber, new MachineGun())
        {
        }
        public Infantry(string name, string rank, int serialNumber, IWeapon weapon) : base(name, rank, serialNumber, weapon)
        {
        }

        override public string ToString()
        {
            return $"My name is {Name} and I am a {Rank}. My Weapon of choice is the {Weapon}.";
        }

        public override void Speak()
        {
            Console.WriteLine("Marching In");
        }
        string IWeapon.Shoot()
        {
            throw new System.NotImplementedException();
        }

        string IWeapon.Action()
        {
            throw new System.NotImplementedException();
        }
    }
}