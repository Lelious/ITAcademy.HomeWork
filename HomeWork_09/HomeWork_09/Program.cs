namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            SportBike sportBike = new SportBike();

            sportBike.MaxSpeedPublic = 100;
            sportBike.MaxSpeedInternal = 150;
            sportBike.MaxSpeedInternalProtected();
        }
    }
}