internal class Program
{
    private static void Main(string[] args)
    {
        ParkingSystem obj = new ParkingSystem(1,1,0);
        Console.WriteLine(obj.AddCar(1)); //big
        Console.WriteLine(obj.AddCar(2)); //medium
        Console.WriteLine(obj.AddCar(3)); //small
        Console.WriteLine(obj.AddCar(4)); //big

        MinStack minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        Console.WriteLine(minStack.GetMin()); // return -3
        minStack.Pop();
        Console.WriteLine(minStack.Top());    // return 0
        Console.WriteLine(minStack.GetMin()); // return -2
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
        //method for the alocation of parking space
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

    public class MinStack
    {

        Stack<int> mainStack;
        Stack<int> minStack;

        public MinStack()
        {
            mainStack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int val)
        {
            mainStack.Push(val);
            if (minStack.Count == 0 || val <= minStack.Peek())
            {
                minStack.Push(val);
            }
        }

        public void Pop()
        {
            mainStack.Pop();
        }

        public int Top()
        {
            int peek = mainStack.Peek();
            return peek;
        }

        public int GetMin()
        {
            int minValue = minStack.Pop();
            return minValue;
        }
    }

    /**
     * Your ParkingSystem object will be instantiated and called as such:
     * ParkingSystem obj = new ParkingSystem(big, medium, small);
     * bool param_1 = obj.AddCar(carType);
     */
}