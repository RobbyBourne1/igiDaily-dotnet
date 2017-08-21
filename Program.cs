using System;

namespace igiDaily_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var Medic = new Medic("Mike", "Kings Guard", 1234);

            var other =  new Medic("Paul", "capt", 123455, new MachineGun());
            Console.WriteLine(Medic);
        }
    }
}
