public class Program
{
public static void Main(string[] args) {

// Generate our random number
Random grand = new Random();

int lowRange;
int max;

// Ask for user input

Console.Write("Enter smallest number: ");
lowRange = Int32.Parse(Console.ReadLine());

Console.Write("Enter largest value: ");
max = Int32.Parse(Console.ReadLine());

int goal = grand.Next(lowRange, max + 1);

int guess;
int attempts = 0;

 Console.WriteLine($"I've picked a number between {lowRange} and {max}. Try to guess it!");

        // Start the guessing loop
        do
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < goal)
            {
                Console.WriteLine("Cold");
            }
            else if (guess > goal)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine($"You're on fire! You got {goal} in {attempts} attempts.");
            }
        } while (guess != goal);
    }
}

