using static ConsoleApp2.simpleCalculator;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

public interface Icalcii
{
    int Add(int x, int y);

    int Subtract(int x, int y);

    int Multiply(int x, int y);

    float Divide(int x, int y);
}

namespace ConsoleApp2
{
    public class simpleCalculator : Icalcii
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {

            return x - y;

        }
        public int Multiply(int x, int y)
        {

            return x * y;

        }
        public float Divide(int x, int y)

        {
            return x / y;
        }
    }
   
}
public class Program

{

    private static void Main(string[] args)
    {

        Icalcii calc = new simpleCalculator();

        Console.WriteLine(calc.Add(5, 6));

        Console.WriteLine(calc.Subtract(5, 6));

        Console.WriteLine(calc.Multiply(5, 6));

        Console.WriteLine(calc.Divide(5, 6));
    }
}
