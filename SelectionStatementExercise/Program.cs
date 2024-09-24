namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int favNumber = r.Next(1, 10);
            //int favNumber = 5;
            int userInput;
            var counter = 0;

            do
            {
                Console.WriteLine("Pick a number between 1 - 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low.");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high.");
                }
                else
                {
                    Console.WriteLine($"You got it, {userInput} is the number!");
                }

                counter++;
                Console.WriteLine($"You have guess {counter} times.");

            } while (userInput != favNumber);
        }
    }
}
