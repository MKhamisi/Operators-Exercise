namespace OperatorExercise
{
    public class Program

    {
        public static class AreaOfCircle

        {
            static void Main(string[] args)

            {

                //-----------Exercise 1-------------------
                int a = 17;
                int b = 4;
                var sum = a + b;
                var subtraction = a - b;
                var multiplication = a * b;
                int quotient = a / b;
                int remainder = a % b;


                Console.WriteLine($"Addition: {sum}");
                Console.WriteLine($"Subtraction: {subtraction}");
                Console.WriteLine($"Multiplication: {multiplication}");
                Console.WriteLine($"Division: {quotient}");
                Console.WriteLine($"Modulus: {remainder}");

                //-----------Exercise 2------------------

                Console.WriteLine("Exercise 2");
                Console.WriteLine("What is the radius of your circle?");

                var radius = double.Parse(Console.ReadLine());

            
                double area = Math.PI * radius * radius;


                Console.WriteLine($"Area of Circle is: {area}");


            }
        }
    }
}