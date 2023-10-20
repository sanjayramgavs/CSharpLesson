using System;

namespace CarNamespace
{
    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid
    }

    public class Car
    {
        private readonly Wheel wheels;

        private readonly Engine engine;
        public readonly int RegistrationNo;
        public string Model { get; set; }
        public FuelType FuelType { get; set; }
        public Wheel[] Wheels { get; } = new Wheel[4];
        public Engine CarEngine { get; } = new Engine();

        

        public Car(int x){
            RegistrationNo = x;

        }
        public Car(){
            wheels = new Wheel(this);
            engine = new Engine(this);


        }

        public class Wheel
        {
            public int Diameter { get; set; }
            public string Material { get; set; }

            private readonly Car c1;

            internal Wheel(){

            }

            internal Wheel( Car outclass){
                if(outclass == null){
                    throw new NullReferenceException("Outer class is not Instanized");                
                }
                c1 =outclass;

            }
        }

        public class Engine
        {
            public string Type { get; set; }
            public int Horsepower { get; set; }
            private readonly Car c1;

            internal Engine(){

            }
            internal Engine( Car outclass){
                if(outclass == null){
                    throw new NullReferenceException("Outer class is not Instanized");                
                }
                c1 =outclass;

            }
        }
        public override string ToString()
        {
            string carDetails = $"Car Details:\n" +
                $"Registration No: {RegistrationNo}\n" +
                $"Model: {Model}\n" +
                $"Fuel Type: {FuelType}\n\n";

            string wheelDetails = "Wheels:\n";
            foreach (var wheel in Wheels)
            {
                wheelDetails += $"Diameter: {wheel.Diameter}, Material: {wheel.Material}\n";
            }

            string engineDetails = $"\nEngine:\n" +
                $"Type: {CarEngine.Type}, Horsepower: {CarEngine.Horsepower}";

            return carDetails + wheelDetails + engineDetails;

        }
    }

    class CarClass
    {
        public static void TestOne()
        {
            try{
            Car myCar = new Car(001);
            myCar.Model = "Sedan";
            myCar.FuelType = FuelType.Gasoline;
            
            

            for (int i = 0; i < 4; i++)
            {
                myCar.Wheels[i] = new Car.Wheel
                {
                    Diameter = 18,
                    Material = "Alloy"
                };
            }
            myCar.CarEngine.Type = "V6";
            myCar.CarEngine.Horsepower = 300;

            Console.WriteLine($"Car Details:");
            Console.WriteLine($"Registration No: {myCar.RegistrationNo}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Fuel Type: {myCar.FuelType}");

            Console.WriteLine("\nWheels:");
            foreach (var wheel in myCar.Wheels)
            {
                Console.WriteLine($"Diameter: {wheel.Diameter}, Material: {wheel.Material}");
            }

            Console.WriteLine("\nEngine:");
            Console.WriteLine($"Type: {myCar.CarEngine.Type}, Horsepower: {myCar.CarEngine.Horsepower}");

            myCar.ToString();
            }
            catch(NullReferenceException ex){
                System.Console.WriteLine(ex.Message);
                
            }
            
        }
    }
}
