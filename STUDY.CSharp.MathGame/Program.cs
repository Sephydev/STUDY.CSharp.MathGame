string? readInput;
string mainMenuChoice = "";

while (!mainMenuChoice.Equals("exit"))
{
    Console.Clear();

    Console.WriteLine("Please enter one of the following choices:");
    Console.WriteLine("  - New Game");
    Console.WriteLine("  - Game History");
    Console.WriteLine("  - Exit");

    readInput = Console.ReadLine();
    if (readInput != "" && readInput != null)
    {
        mainMenuChoice = readInput.ToLower();
        Console.WriteLine($"You've entered '{mainMenuChoice}'. Press Enter to return to the Main Menu.");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Please enter a valid option. Press Enter to return to the Main Menu.");
        Console.ReadLine();
        continue;
    }

}