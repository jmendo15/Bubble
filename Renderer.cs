using System;

class Renderer
{
    public void ClearConsole()
    {
        Console.Clear();
    }

    public void DrawGameObject(GameObject gameObject)
    {
        Console.SetCursorPosition(gameObject.X, gameObject.Y);
        Console.Write(gameObject.Symbol);
    }
}
