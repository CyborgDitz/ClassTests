namespace ClassTestEdgard;

public class GameLogic
{
    public string Processing(string input)
    {
        if (input == "w")
        {
            return "Moving up";
        }
        else if (input == "s")
        {
            return "Moving down";
        }

        if (input == "a")
        {
            return "Moving left";
        }
        else if (input == "d")
        {
            return "Moving right";
        }
        else return "Invalid input";
    }
}