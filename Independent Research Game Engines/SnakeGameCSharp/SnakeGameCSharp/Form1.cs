using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SnakeGameCSharp
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        
        public Form1()
        {
            InitializeComponent();
            // Set Settings to default 
            new Settings();

            //Set Game speed and start your timer
            
            gameTimer.Interval = 1000/Settings.Speed;
            
            gameTimer.Tick += new EventHandler(UpdateScreen);
            gameTimer.Start();
            

            StartGame();
        }
        private void StartGame()
        {
            lblGameOver.Visible = false;
            Settings.GameOver = false;
            new Settings();
            //Create new player object

            Snake.Clear();
            Circle head = new Circle();
            head.x = 10;
            head.y = 5;
            Snake.Add(head);

            lblScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for game over
            if (Settings.GameOver == true)
            {
                //Check if enter was ressed 
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if(i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].x++;
                            break;
                        case Direction.Left:
                            Snake[i].x--;
                            break;
                        case Direction.Up:
                            Snake[i].y++;
                            break;
                        case Direction.Down:
                            Snake[i].y--;
                            break;

                    }
                }
                else
                {
                    //move body
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
        }

       

        private void GenerateFood()
        {
            //place random food object somewhere in game screen
            int maxXPosition = pbCanvas.Size.Width / Settings.Width;
            int maxYPosition = pbCanvas.Size.Height / Settings.Height;

            Random rdm = new Random();
            food = new Circle();
            food.x = rdm.Next(0, maxXPosition);
            food.y = rdm.Next(0, maxYPosition);

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //set color of snake
                Brush snakeColour;

                //Draw Snake 
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                        snakeColour = Brushes.Black;
                    else
                        snakeColour = Brushes.Green;

                    //Draw Snake
                    canvas.FillEllipse(snakeColour, 
                        new Rectangle(Snake[i].x = Settings.Width,
                            Snake[i].y = Settings.Height, 
                            Settings.Width, Settings.Height));

                    //Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.x = Settings.Width + 100, food.y = Settings.Height + 100,
                            Settings.Width, Settings.Height));

                }
            }
            else
            {
                string gameOver = "Game over\nYour Final Score is: " + Settings.Score + "\nPress Enter to Try Again.";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                Snake[i].y++;
            }
        }

    }
}
