
Random rnd  = new Random();
int cpuRandom;

bool loopActive = true; //bool -

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. Enter number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you Won!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Oops. Try again.");
    }
}