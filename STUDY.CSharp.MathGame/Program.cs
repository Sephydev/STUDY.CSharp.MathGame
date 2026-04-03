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
        mainMenuChoice = readInput.ToLower().Trim();
    }
    else
    {
        Console.WriteLine("Please enter a valid option. (Press Enter to return to the Main Menu.)");
        Console.ReadLine();
        continue;
    }

    switch (mainMenuChoice)
    {
        case "new game":
            Console.WriteLine("'New Game' under construnction. (Press Enter to return to the Main Menu.)");
            Console.ReadLine();
            break;
        case "game history":
            Console.WriteLine("'Game History' under construction. (Press Enter to return to the Main Menu.)");
            Console.ReadLine();
            break;
        case "exit":
            Console.WriteLine("See you next time! (Press Enter to exit.)");
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Please enter a valid option. (Press Enter to return to the Main Menu.)");
            Console.ReadLine();
            break;
    }
}