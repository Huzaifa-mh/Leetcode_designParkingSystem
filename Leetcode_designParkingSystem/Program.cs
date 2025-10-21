internal class Program
{
    private static void Main(string[] args)
    {
        ParkingSystem obj = new ParkingSystem(1,1,0);
        Console.WriteLine(obj.AddCar(1)); //big
        Console.WriteLine(obj.AddCar(2)); //medium
        Console.WriteLine(obj.AddCar(3)); //small
        Console.WriteLine(obj.AddCar(4)); //big
    }
    public class ParkingSystem
    {

        int bigCar, mediumCar, smallCar;
        public ParkingSystem(int big, int medium, int small)
        {
            bigCar = big;
            mediumCar = medium;
            smallCar = small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1 && bigCar > 0)
            {
                bigCar--;
                return true;
            }
            else if (carType == 2 && mediumCar > 0)
            {
                mediumCar--;
                return true;
            }
            else if (carType == 3 && smallCar > 0)
            {
                smallCar--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    /**
     * Your ParkingSystem object will be instantiated and called as such:
     * ParkingSystem obj = new ParkingSystem(big, medium, small);
     * bool param_1 = obj.AddCar(carType);
     */
}