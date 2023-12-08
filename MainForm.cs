using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleGameEngine
{
    public partial class MainForm : Form
    {
        private const int PlayerSpeed = 5;
        private Rectangle playerRect = new Rectangle(50, 50, 30, 30);

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Set up the form
            this.Text = "Simple Game Engine";
            this.ClientSize = new Size(800, 600);
            this.DoubleBuffered = true;

            // Set up game loop
            Timer gameLoop = new Timer();
            gameLoop.Interval = 16; // 60 FPS
            gameLoop.Tick += GameLoop_Tick;
            gameLoop.Start();
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            // Game logic
            UpdateGame();

            // Rendering
            this.Invalidate();
        }

        private void UpdateGame()
        {
            // Move the player based on input
            if (Keyboard.IsKeyDown(Keys.Left)) playerRect.X -= PlayerSpeed;
            if (Keyboard.IsKeyDown(Keys.Right)) playerRect.X += PlayerSpeed;
            if (Keyboard.IsKeyDown(Keys.Up)) playerRect.Y -= PlayerSpeed;
            if (Keyboard.IsKeyDown(Keys.Down)) playerRect.Y += PlayerSpeed;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Drawing
            Graphics g = e.Graphics;
            g.Clear(Color.Black);

            // Draw the player
            g.FillRectangle(Brushes.Red, playerRect);
        }
    }
}
