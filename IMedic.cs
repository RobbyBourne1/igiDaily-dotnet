namespace igiDaily_dotnet
{
    interface IMedic
    {
        int MedicalPacks { get; set; }
        bool Automatic { get; set; }
        string LivesSaved { get; set; }

        void Heal();
        void TakeCover(); 
    }
}