namespace igiDaily_dotnet
{
    interface ISniper
    {
        int RoundsPerSecond { get; set; }
        bool Automatic { get; set; }
        double Type { get; set; }

        void Shoot();
        void Reload(); 
    }
}