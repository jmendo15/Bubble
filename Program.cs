using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;

        GameObject player = new GameObject { X = 10, Y = 10, Symbol = "P" };

        while (true)
        {
            // Update game logic

            // Render
            player.Draw();

            Thread.Sleep(16); // Simulate 60 FPS
        }
    }
}
