using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedSnake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public partial class Game : Form
    {
        /// <summary>
        /// Private fields
        /// </summary>
        private List<Node> snake = new List<Node>();
        private List<string> HighScores = new List<string>();
        private Node food = new Node();
        private bool gameOver = false;
        private Direction snakeDirection = Direction.Right;
        private int score = 0;

        public Game()
        {
            InitializeComponent();

            //Set game speed and start timer
            gameTimer.Interval = 1000 / 16;
            gameTimer.Tick += UpdateScreen;

            StartGame();
        }

        /// <summary>
        /// Sets up the game
        /// </summary>
        public void StartGame()
        {
            lblGameMessage.Visible = false;
            gameOver = false;

            //Create new snake object
            snake.Clear();
            Node head = new Node { X = 10, Y = 5 };
            snake.Add(head);
            tsiScore.Text = "Score: " + 0;
            gameTimer.Start();
            GenerateFood();
        }

        /// <summary>
        /// Places food on screen randomely
        /// maxX and maxY limit the location to inside the canvas
        /// </summary>
        public void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / 16;
            int maxYPos = pbCanvas.Size.Height / 16;

            Random rd = new Random();
            food = new Node { X = rd.Next(0, maxXPos), Y = rd.Next(0, maxYPos) };
        }

        /// <summary>
        /// Updates the screen and checks game settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (gameOver)
            {
                if(Input.KeyPressed(Keys.Enter))
                StartGame();
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && snakeDirection != Direction.Left)
                    snakeDirection = Direction.Right;
                if (Input.KeyPressed(Keys.Left) && snakeDirection != Direction.Right)
                    snakeDirection = Direction.Left;
                if (Input.KeyPressed(Keys.Up) && snakeDirection != Direction.Down)
                    snakeDirection = Direction.Up;
                if (Input.KeyPressed(Keys.Down) && snakeDirection != Direction.Up)
                    snakeDirection = Direction.Down;

                MovePlayer();
            }
            pbCanvas.Invalidate();
        }

        /// <summary>
        /// Paints the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void pbCanvas_Paint(object sender, PaintEventArgs e)
        {

            Graphics canvas = e.Graphics;

            if (!gameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        snakeColour = Brushes.Green;    //Rest of body

                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(snake[i].X * 16,
                                      snake[i].Y * 16,
                                      16, 16));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * 16,
                             food.Y * 16, 16, 16));
                }
            }
            else
            {
                lblGameMessage.Text = "Game over \nYour final score is: " + score;
                lblGameMessage.Visible = true;
            }
        }

        /// <summary>
        /// Moves the player
        /// </summary>
        public void MovePlayer()
        {

            for (int i = snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (snakeDirection)
                    {
                        case Direction.Right:
                            snake[i].X++;
                            break;
                        case Direction.Left:
                            snake[i].X--;
                            break;
                        case Direction.Up:
                            snake[i].Y--;
                            break;
                        case Direction.Down:
                            snake[i].Y++;
                            break;
                    }


                    //Get maximum X and Y Pos
                    int maxXPos = pbCanvas.Size.Width / 16;
                    int maxYPos = pbCanvas.Size.Height / 16;

                   
                        if (snake[i].X < 0 || snake[i].Y < 0
                        || snake[i].X >= maxXPos || snake[i].Y >= maxYPos)
                        {
                            Die();
                        }

                    //Detect collission with body
                    for (int j = 1; j < snake.Count; j++)
                    {
                        if (snake[i].X == snake[j].X &&
                           snake[i].Y == snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (snake[0].X == food.X && snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                else
                {
                    //Move body
                    snake[i].X = snake[i - 1].X;
                    snake[i].Y = snake[i - 1].Y;
                }

            }
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        /// <summary>
        /// What happends when the snake eats a food
        /// </summary>
        public void Eat()
        {
            //Add circle to body
            Node circle = new Node
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            };
            snake.Add(circle);

            //Update Score
            score += 10;
            tsiScore.Text = "Score: " + score;

            GenerateFood();
        }

        /// <summary>
        /// What happens when the snake dies
        /// </summary>
        public void Die()
        {
            gameOver = true;
        }

        private void tsiMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
