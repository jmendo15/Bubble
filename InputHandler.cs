using System;

class InputHandler
{
    public ConsoleKeyInfo GetKey()
    {
        if (Console.KeyAvailable)
        {
            return Console.ReadKey(true);
        }

        return default(ConsoleKeyInfo);
    }
}
