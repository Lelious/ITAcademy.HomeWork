namespace HomeWork_12
{
    interface IMotorcycle
    {
        void GetMotorcycles();
        void GetMotorcycleById(int id);
        void CreateMotorcycle(Motorcycle moto);
        void UpdateMotorcycle(int id, string name, string model, int year, int odometer);
        void DeleteMotorcycle(int id);
    }
}
