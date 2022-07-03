string answer = " ";
string output;

do
{
    Console.Write("How many people are we making PB&J sandwiches for? ");
    double input = int.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    Console.WriteLine("You need:\n");

    Console.WriteLine("   " + input * 2 + " slices of bread");
    Console.WriteLine("   " + input * 2 + " tablespoons of peanut butter");
    Console.WriteLine("   " + input * 4 + " teaspoons of jelly\n");

    Console.WriteLine("   " + "Which is...\n");

    double loaves = Math.Ceiling(input * 2 / 28);
    double peanutButter = Math.Ceiling(input * 2 / 32);
    double jelly = Math.Ceiling(input * 4 / 48);

    Console.WriteLine("   " + loaves + " loaves of bread");
    Console.WriteLine("   " + peanutButter + " jars of peanut butter");
    Console.WriteLine("   " + jelly + " jars of jelly\n");

    Console.WriteLine("Would you like to restart? Enter \"Yes\" or \"y\" or enter any "
        + "key to exit.");

    answer = Console.ReadLine();
    output = answer.ToLower();

} while (output == "y" || output == "yes");

if (answer != "y" || answer != "yes")
{
    Console.WriteLine("Goodbye!");
}

Console.ReadKey();