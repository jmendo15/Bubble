using System;

class UI
{
    public void DisplayScore(int score)
    {
        Console.ForegroundColor = ConsoleColor.White; // Set text color
        Console.SetCursorPosition(5, 5);
        Console.Write($"Score: {score}");
    }

    public void DisplayHealth(int health)
    {
        Console.ForegroundColor = ConsoleColor.White; // Set text color
        Console.SetCursorPosition(7, 7);
        Console.Write($"Health: {health}");
    }

    public void DisplayGameOver()
    {
        Console.ForegroundColor = ConsoleColor.Red; // Set text color for game over message
        Console.Clear();
        Console.WriteLine("Game Over!");
    }

    public void DisplayRestartPrompt()
    {
        Console.ForegroundColor = ConsoleColor.White; // Set text color for restart prompt
        Console.WriteLine("Press R to restart.");
    }
}
