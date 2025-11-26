//General Studies for the Free Foundational C# with Microsoft Certification
Console.WriteLine("Let's play a game? (y/n)");

char key = Console.ReadKey(true).KeyChar;

if (char.ToLower(key) == 'y')
{
    Console.WriteLine("Let's start!");
}
else
{
    Console.WriteLine("Maybe next time!");
    Environment.Exit(0);
}
Console.Clear();


Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples!  +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}
