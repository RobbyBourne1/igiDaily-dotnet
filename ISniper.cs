namespace igiDaily_dotnet
{
    interface ISniper
    {
        int RoundsPerSecond { get; set; }
        bool Automatic { get; set; }
        double Accuracy { get; set; }

        void Shoot();
        void Reload(); 
    }
}