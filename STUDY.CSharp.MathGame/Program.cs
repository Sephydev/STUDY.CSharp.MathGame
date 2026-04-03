game();

void game()
{
    string[] mainMenuChoices = { "New Game", "Game History", "Exit" };
    string mainMenuChoice = "";
    bool running = true;

    while (running)
    {
        menuDisplay(mainMenuChoices);
        mainMenuChoice = userInputReading();

        switch (mainMenuChoice)
        {
            case "new game":
                newGame();
                break;
            case "game history":
                gameHistory();
                break;
            case "exit":
                running = false;
                Console.WriteLine("See you next time! (Press Enter to exit.)");
                Console.ReadLine();
                break;
            default:
                invalidOption();
                break;
        }
    }
}

void menuDisplay(string[] menuChoices)
{
    Console.Clear();

    Console.WriteLine("Please enter one of the following choices:");
    foreach(string choice in menuChoices)
    {
        Console.WriteLine($"  - {choice}");
    }
}

string userInputReading()
{
    string? readInput;
    string verifiedInput = "";

    readInput = Console.ReadLine();
    if (readInput != null)
    {
        verifiedInput = readInput.ToLower().Trim();
        return verifiedInput;
    }

    return "";
}

void newGame()
{
    string[] newGameChoices = { "Addition", "Subtraction", "Multiplication", "Division", "Main Menu" };
    bool running = true;

    while (running)
    {
        menuDisplay(newGameChoices);
        string newGameChoice = userInputReading();

        switch (newGameChoice)
        {
            case "addition":
                mathOperation('+');
                break;
            case "subtraction":
                mathOperation('-');
                break;
            case "multiplication":
                mathOperation('*');
                break;
            case "division":
                mathOperation('/');
                break;
            case "main menu":
                running = false;
                break;
            default:
                invalidOption();
                break;
        }
    }
}

void gameHistory()
{
    Console.WriteLine("'Game History' under construction. (Press Enter to return to the Main Menu.)");
    Console.ReadLine();
}

void mathOperation (char mathOperator)
{
    Console.WriteLine($"Math Operation is under construction. (Press Enter to return to the New Game Menu.)");
    Console.ReadLine();
}

void invalidOption ()
{
    Console.WriteLine("Please enter a valid option. (Press Enter to return to the previous Menu.)");
    Console.ReadLine();
}