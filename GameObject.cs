class GameObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Symbol { get; set; }

    public void Draw()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write(Symbol);
    }
}
