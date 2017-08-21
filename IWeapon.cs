using System;

namespace igiDaily_dotnet
{
    public interface IWeapon
    {
        string Shoot();
        string Action(); 
    }
        public class MachineGun : IWeapon
        {        
            int RoundsPerSecond { get; set; }
            bool Automatic { get; set; }
            string Type { get; set; }

            public string Shoot()
            {
                Console.WriteLine("Firing Machinegun");
                return Shoot();
            }
            public string Action()
            {
                Console.WriteLine("Reloading Machinegun");
                return Action();
            }
        }
        public class Sniper : IWeapon
        {
            int RoundsPerSecond { get; set; }
            bool Automatic { get; set; }
            string Type { get; set; }

            public string Shoot()
            {
                Console.WriteLine("Firing Sniper");
                return Shoot();
            }
            public string Action()
            {
                Console.WriteLine("Aiming Sniper");
                return Action();
            }
        }

        public class Pistol : IWeapon
        {
            int RoundsPerSecond { get; set; }
            bool Automatic { get; set; }
            string Type { get; set; }

            public string Shoot()
            {
                Console.WriteLine("Healing Soldier");
                return Shoot();
            }
            public string Action()
            {
                Console.WriteLine("Taking Cover");
                return Action();
            }
        }

}