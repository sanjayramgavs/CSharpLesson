/**Create a class called Car.
The Car has a RegistrationNo, Model, FuelType, Wheels[4], 
and 1 Engine.

The FuelType must be an Enum
Wheel, and Engine must be INNER Class.**/
public enum FuelType
{
    Petrol,Deisel,CNG
}

class Car
{
    public String model = String.Empty;
    public  readonly int registrationNo;
    public FuelType fuelType;
    //public int engine;
    public readonly int[] wheel;

    public class Engine
    {
        public void Start()
        {

        }
        public void Stop()
        {

        }
    }
    public class Wheel
    {
        int[] wheels = new int[4];

    }

}