namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"The sum of  {a} + {b} is {a + b}");
            Console.WriteLine($"The difference of  {a} - {b} is {a - b}");
            Console.WriteLine($"The product of  {a} * {b} is {a * b}");

            if (a == 17 && b== 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }

            Console.WriteLine("----------------------------------------------------------------------------------");

            //Exercise 2
            double r;
            Console.Write("What is the radius of your circle? > ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of a circle with a radius of {r} is {AreaOfCircle(r)} ");
        }

        public static double AreaOfCircle(double radius)
        { 
            return radius * radius * Math.PI;

        }
    }
}
