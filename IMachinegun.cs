namespace igiDaily_dotnet
{
    interface IMachinegun
    {
        int RoundsPerSecond { get; set; }
        bool Automatic { get; set; }
        string Type { get; set; }

        void Shoot();
        void Reload(); 
    }
}