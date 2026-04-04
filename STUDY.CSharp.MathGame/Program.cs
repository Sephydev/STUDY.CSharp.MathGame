Random rand = new Random();

game();

void game()
{
    string[] mainMenuChoices = { "New Game", "Game History", "Exit" };
    string mainMenuChoice = "";
    bool running = true;
    List<string> previousGames = new List<string>();

    while (running)
    {
        menuDisplay(mainMenuChoices);
        mainMenuChoice = userInputReading();

        switch (mainMenuChoice)
        {
            case "new game":
                newGame(previousGames);
                break;
            case "game history":
                gameHistory(previousGames);
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

void newGame(List<string> previousGames)
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
                previousGames.Add("Addition | ");
                mathOperation('+', previousGames);
                break;
            case "subtraction":
                previousGames.Add("Subtraction | ");
                mathOperation('-', previousGames);
                break;
            case "multiplication":
                previousGames.Add("Multiplication | ");
                mathOperation('*', previousGames);
                break;
            case "division":
                previousGames.Add("Division | ");
                mathOperation('/', previousGames);
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

void gameHistory(List<string> previousGames)
{
    Console.Clear();
    foreach (string previousGame in previousGames)
    {
        Console.WriteLine(previousGame);
    }
    Console.WriteLine("\n(Press Enter to return to the Main Menu)");
    Console.ReadLine();
}

void mathOperation (char mathOperator, List<string> previousGames)
{
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int[] numbers = numbersGenerator(mathOperator);
        int result = resultCalculation(numbers, mathOperator);
        int userInput;

        Console.Clear();
        Console.WriteLine($"Score: {score}\n");
        Console.WriteLine($"{numbers[0]} {mathOperator} {numbers[1]} = ?");

        if (int.TryParse(userInputReading(), out userInput))
        {
            if (userInput == result)
            {
                score++;
                Console.WriteLine("Correct ! (Press Enter to continue)");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wrong... (Press Enter to continue)");
                Console.ReadLine();
            }
        }
    }

    previousGames[previousGames.Count - 1] += $"Score: {score}";
}

int[] numbersGenerator(char mathOperator)
{
    int[] numbers = {0, 0};
    bool resultIsInt = false;

    do
    {
        if (mathOperator == '/')
            numbers[0] = rand.Next(0, 100);
        else
            numbers[0] = rand.Next(0, 10);

        do
        {
            numbers[1] = rand.Next(0, 10);
        } while (mathOperator == '/' && numbers[1] == 0);

        if (mathOperator == '/')
            resultIsInt = numbers[0] % numbers[1] == 0;

    } while (!resultIsInt && mathOperator == '/');

    return numbers;
}

int resultCalculation(int[]numbers, char mathOperator)
{
    int result = 0;
    switch (mathOperator)
    {
        case '+':
            result = numbers[0] + numbers[1];
            break;
        case '-':
            result = numbers[0] - numbers[1];
            break;
        case '*':
            result = numbers[0] * numbers[1];
            break;
        case '/':
            result = numbers[0] / numbers[1];
            break;
    }

    return result;
}

void invalidOption ()
{
    Console.WriteLine("Please enter a valid option. (Press Enter to return to the previous Menu.)");
    Console.ReadLine();
}