using System.Diagnostics;

public class GameObject
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Symbol { get; set; }

    public void Draw()
    {
        Debug.WriteLine($"Drawing {Symbol} at ({X}, {Y})");
    }
}
