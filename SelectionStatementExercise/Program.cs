namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {var r = new Random();
            //var favNumber = r.Next(1, 9);
            var favNumber = 6;

            Console.WriteLine("Try to guess my favorite number");
                var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");

            }
            else if (userInput > favNumber) 
            { 
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }
    }
}
