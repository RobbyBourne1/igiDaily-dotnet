using System;

namespace igiDaily_dotnet
{
    public interface IWeapon
    {
        void Shoot();
        void Reload(); 
    }
        public class MachineGun : IWeapon
        {        
            int RoundsPerSecond { get; set; }
            bool Automatic { get; set; }
            string Type { get; set; }

            public void Shoot()
            {
                Console.WriteLine("Firing Machinegun");
            }
            public void Reload()
            {
                Console.WriteLine("Reloading Machinegun");
            }
        }
        public class Sniper : IWeapon
        {
            int RoundsPerSecond { get; set; }
            bool Automatic { get; set; }
            string Type { get; set; }

            public void Shoot()
            {
                Console.WriteLine("Firing Sniper");
            }
            public void Reload()
            {
                Console.WriteLine("Reloading Sniper");
            }
        }

        public class Pistol : IWeapon
        {
            int RoundsPerSecond { get; set; }
            bool Automatic { get; set; }
            string Type { get; set; }

            public void Shoot()
            {
                Console.WriteLine("Healing Soldier");
            }
            public void Reload()
            {
                Console.WriteLine("Taking Cover");
            }
        }

}