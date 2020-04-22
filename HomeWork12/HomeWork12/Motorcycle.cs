namespace HomeWork_12
{
    public class Motorcycle
    {
        private static int _idIterator;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Odometer { get; set; }       
        public Motorcycle()
        {

        }
        public Motorcycle(string name, string model, int year, int odometer)
        {
            _idIterator += 1;
            Id = _idIterator;
            Name = name;
            Model = model;
            Year = year;
            Odometer = odometer;
        }
    }
}
