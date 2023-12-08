using System.Windows.Forms;

namespace SimpleGameEngine
{
    public static class Keyboard
    {
        private static bool[] keys = new bool[256];

        public static bool IsKeyDown(Keys key)
        {
            return keys[(int)key];
        }

        public static void KeyDown(Keys key)
        {
            keys[(int)key] = true;
        }

        public static void KeyUp(Keys key)
        {
            keys[(int)key] = false;
        }
    }
}
