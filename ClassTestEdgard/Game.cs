
using ClassTestEdgard;

public class Game()
{
    private bool _isRunning = true;
    private InputSystem _inputSystem = new();
    private GameLogic _gameLogic = new();
    private View _view = new();
    
    public void Run()
    {
        while (_isRunning)
        {
            string input = _inputSystem.Input();
            if (input == "q")
            {
                _isRunning = false;
            }
            else
            {
                string output = _gameLogic.Processing(input);
                _view.Output(output);
            }
        }
        
    }
    
}

