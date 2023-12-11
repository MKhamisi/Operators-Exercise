namespace OperatorExercise
{
    public class Program
        
    {
        static void Main(string[] args)
        {

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


        }
    }
}
