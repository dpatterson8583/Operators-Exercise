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
            if (a == 17 && b== 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }

            double r;
            Console.WriteLine("What is the radius of your circle? > ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"The area of a circle with a radius of {r} is {AreaOfCircle(r)} ");
        }

        public static double AreaOfCircle(double radius)
        { 
            return radius * radius * Math.PI;

        }
    }
}
