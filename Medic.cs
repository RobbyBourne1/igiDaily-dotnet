namespace igiDaily_dotnet
{
    public class Medic : Soldier, IWeapon
    {
        public Medic(string name, string rank, int serialNumber) : base(name, rank, serialNumber)
        {
        }

        public void Reload()
        {
            throw new System.NotImplementedException();
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }

        public override void Speak()
        {
            throw new System.NotImplementedException("Medic is Here");
        }
    }
}