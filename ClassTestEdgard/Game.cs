
public class Game()
{
    private bool _isRunning;
    public void Run()
    {
        while (_isRunning)
        {
            string input = Input();
            if (input == "q")
            {
                _isRunning = false;
            }
            else
            {
                string output = Processing(input);
                Output(output);
            }
        }
        
    }
    public static int Sum(ref int a, int b)
    {
        return a + b;
    }

    private string Processing(string input)
    {
        switch (input)
        {
            case "0":
                return "You pressed: W";
                // Console.WriteLine("You pressed: W");
              
            case "1":
                // Console.WriteLine("You pressed: A");
                return "You pressed: A";
           
            default:
                return "??";
        }
    }

    private void Output(string output)
    {
        Console.WriteLine(output);
    }
    public string Input()
    {
        Console.WriteLine("Enter a binary number: ");
        string input = Console.ReadLine();
        return input;
    }

    
}