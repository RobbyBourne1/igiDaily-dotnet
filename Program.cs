using System;

namespace igiDaily_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var Medic = new Medic("Mike", "Kings Guard", 1234);

            var Sailor =  new Sailor("Paul", "capt", 123455);
            var Infantry = new Infantry("Rodger", "General", 5678);
            
            Console.WriteLine(Medic);
            Console.WriteLine(Sailor);
            Console.WriteLine(Infantry);

        }
    }
}
