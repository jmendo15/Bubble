using System;
using System.Windows.Forms;

namespace SimpleGameEngine
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            mainForm.KeyDown += MainForm_KeyDown;
            mainForm.KeyUp += MainForm_KeyUp;

            Application.Run(mainForm);
        }

        private static void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Keyboard.KeyDown(e.KeyCode);
        }

        private static void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            Keyboard.KeyUp(e.KeyCode);
        }
    }
}
