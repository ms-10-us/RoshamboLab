using RoshamboLab;

Console.WriteLine("Welcome to the Roshambo Lab!");

Console.WriteLine();

HumanPlayer humanPlayerObject = new HumanPlayer();
Console.WriteLine("Please enter your name:");
humanPlayerObject.Name = Console.ReadLine();

RockPlayer rockPlayerObject = new RockPlayer();
RandomPlayer randomPlayerObject = new RandomPlayer();

Validator.UserAnswer = "y";
while (Validator.UserAnswer.Trim().ToLower() == "y")
{
    Console.WriteLine();

    Validator.SelectedPlayer = "";
    do
    {
        Console.WriteLine("Would you like to play against RockPlayer or RandomPlayer");
        Validator.SelectedPlayer = Console.ReadLine();
        if (!Validator.GetOtherPlayer())
        {
            Console.WriteLine("Please enter a valid selection");
        }

    } while (!Validator.GetOtherPlayer());

    Console.WriteLine("Rock, Paper, or Scissors? (1,2 or 3)");
    humanPlayerObject.selectedValue = Convert.ToInt32(Console.ReadLine());
    Validator.GetRoshambo(humanPlayerObject);

    humanPlayerObject.RoshamboValue = humanPlayerObject.GenerateRoshambo();
    Console.WriteLine($"{humanPlayerObject.Name}: {humanPlayerObject.RoshamboValue}");

    if (Validator.SelectedPlayer.Trim().ToLower() == "rockplayer")
    {


        Console.WriteLine($"RockPlayer: {rockPlayerObject.GenerateRoshambo()}");

        if (humanPlayerObject.RoshamboValue == Roshambo.Rock)
        {
            Console.WriteLine("Draw!");
        }
        else if (humanPlayerObject.RoshamboValue == Roshambo.Paper)
        {
            Console.WriteLine($"{humanPlayerObject.Name} won!");
            humanPlayerObject.Win++;
        }
        else if (humanPlayerObject.RoshamboValue == Roshambo.Scissors)
        {
            Console.WriteLine($"RockPlayer Won!");
            rockPlayerObject.Win++;
        }

    }
    else if (Validator.SelectedPlayer.Trim().ToLower() == "randomplayer")
    {

        randomPlayerObject.RoshamboValue = randomPlayerObject.GenerateRoshambo();
        Console.WriteLine($"RandomPLayer: {randomPlayerObject.RoshamboValue}");

        if (humanPlayerObject.RoshamboValue == Roshambo.Rock && randomPlayerObject.RoshamboValue == Roshambo.Paper)
        {
            Console.WriteLine("Random Player Won!");
            randomPlayerObject.Win++;
        }
        else if (humanPlayerObject.RoshamboValue == Roshambo.Rock && randomPlayerObject.RoshamboValue == Roshambo.Scissors)
        {
            Console.WriteLine($"{humanPlayerObject.Name} won!");
            humanPlayerObject.Win++;
        }
        else if (humanPlayerObject.RoshamboValue == Roshambo.Paper && randomPlayerObject.RoshamboValue == Roshambo.Rock)
        {
            Console.WriteLine($"{humanPlayerObject.Name} won!");
            humanPlayerObject.Win++;
        }
        else if (humanPlayerObject.RoshamboValue == Roshambo.Paper && randomPlayerObject.RoshamboValue == Roshambo.Scissors)
        {
            Console.WriteLine("Random Player Won!");
            randomPlayerObject.Win++;
        }
        else if (humanPlayerObject.RoshamboValue == Roshambo.Scissors && randomPlayerObject.RoshamboValue == Roshambo.Rock)
        {
            Console.WriteLine("Random Player Won!");
            randomPlayerObject.Win++;
        }
        else if (humanPlayerObject.RoshamboValue == Roshambo.Scissors && randomPlayerObject.RoshamboValue == Roshambo.Paper)
        {
            Console.WriteLine($"{humanPlayerObject.Name} won!");
            humanPlayerObject.Win++;
        }
        else if (humanPlayerObject.RoshamboValue == randomPlayerObject.RoshamboValue)
        {
            Console.WriteLine("Draw!");
        }
    }

    Console.WriteLine($"Score:{humanPlayerObject.Name} = {humanPlayerObject.Win}\tRockPlayer = {rockPlayerObject.Win}\trandomPlayer = {randomPlayerObject.Win}");

    Console.WriteLine();

    do
    {
        Console.WriteLine("Play Again?(Y/N)");
        Validator.UserAnswer = Console.ReadLine();
        if (!Validator.GetYN())
        {
            Console.WriteLine("Please enter a valid answer!");
        }
    } while (!Validator.GetYN());


}

if (Validator.UserAnswer.Trim().ToLower() == "n")
{
    Console.WriteLine("GoodBye!");
}







