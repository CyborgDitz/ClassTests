namespace ClassTestEdgard;
public class InputSystem
{
    public string Input()
    {
        Console.WriteLine("Press a key to move: ");
        string input = Console.ReadLine();
        return input;
    }
}