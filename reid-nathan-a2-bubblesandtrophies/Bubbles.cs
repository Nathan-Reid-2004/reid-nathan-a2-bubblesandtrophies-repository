// Include the namespaces (code libraries) you need below.
using System;
using System.Data;
using System.Numerics;
using System.Reflection.Metadata;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:



        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Bubbles");
            Window.SetSize(400, 400);
            Window.TargetFPS = 1;

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            //clear screen every frame
            Window.ClearBackground(Color.Gray);

            //making the pointer click colour
            Color pointerOrange = new Color("#FFAD00");

            //making the bubble colour
            Color bubbleBlue = new Color(203, 239, 255);

            //tracking seconds since the game started
            float secondsElapsed = Time.SecondsElapsed;

            //drawing various functions
            drawBomb();
            drawWall(Input.GetMouseX(), Input.GetMouseY());

            // wall/pointer (lines will be drawn at x, y positions and expand from there to create a shape (ie. x +150 pixels))
            void drawWall(float x, float y)
            {

                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Draw.LineColor = pointerOrange;
                    Window.TargetFPS++;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Right))
                {
                    Draw.LineColor = Color.Yellow;
                    Window.TargetFPS--;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Middle))
                {
                    Draw.LineColor = Color.Green;
                }
                else
                {
                    Draw.LineColor = Color.Blue;
                }
                Draw.LineSize = 3;
                Draw.Line(x - 150, y, x + 150, y);


                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Draw.LineColor = pointerOrange;
                    Window.TargetFPS++;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Right))
                {
                    Draw.LineColor = Color.Yellow;
                    Window.TargetFPS--;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Middle))
                {
                    Draw.LineColor = Color.Green;
                }
                else
                {
                    Draw.LineColor = Color.Blue;
                }
                Draw.LineSize = 3;
                Draw.Line(x - 150, y - 300, x - 150, y);


                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Draw.LineColor = pointerOrange;
                    Window.TargetFPS++;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Right))
                {
                    Draw.LineColor = Color.Yellow;
                    Window.TargetFPS--;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Middle))
                {
                    Draw.LineColor = Color.Green;
                }
                else
                {
                    Draw.LineColor = Color.Blue;
                }
                Draw.LineSize = 3;
                Draw.Line(x - 150, y - 300, x + 150, y - 300);


                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Draw.LineColor = pointerOrange;
                    Window.TargetFPS++;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Right))
                {
                    Draw.LineColor = Color.Yellow;
                    Window.TargetFPS--;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Middle))
                {
                    Draw.LineColor = Color.Green;
                }
                else
                {
                    Draw.LineColor = Color.Blue;
                }
                Draw.LineSize = 3;
                Draw.Line(x + 150, y - 300, x + 150, y);


                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Draw.FillColor = pointerOrange;
                    Window.TargetFPS++;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Right))
                {
                    Draw.FillColor = Color.Yellow;
                    Window.TargetFPS--;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Middle))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Blue;
                }
                Draw.LineSize = 3;
                Draw.LineColor = Color.Black;
                Draw.Circle(x, y - 150, 20);


                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Draw.FillColor = pointerOrange;
                    Window.TargetFPS++;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Right))
                {
                    Draw.FillColor = Color.Yellow;
                    Window.TargetFPS--;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Middle))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Blue;
                }
                Draw.LineSize = 3;
                Draw.LineColor = Color.Black;
                Draw.Circle(x -150, y - 150, 10);


                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Draw.FillColor = pointerOrange;
                    Window.TargetFPS++;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Right))
                {
                    Draw.FillColor = Color.Yellow;
                    Window.TargetFPS--;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Middle))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Blue;
                }
                Draw.LineSize = 3;
                Draw.LineColor = Color.Black;
                Draw.Circle(x + 150, y - 150, 10);


                if (Input.IsMouseButtonDown(MouseInput.Left))
                {
                    Draw.FillColor = pointerOrange;
                    Window.TargetFPS++;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Right))
                {
                    Draw.FillColor = Color.Yellow;
                    Window.TargetFPS--;
                }
                else if (Input.IsMouseButtonDown(MouseInput.Middle))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Blue;
                }
                Draw.LineSize = 3;
                Draw.LineColor = Color.Black;
                Draw.Circle(x, y - 300, 10);
            }
            ;


            //bomb main rectangle & small decor rectanges within the bomb
            void drawBomb()
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(new Vector2(160, 160), new Vector2(80, 80));

                if (Input.IsKeyboardKeyDown(KeyboardInput.B))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Black;
                }
                Draw.Rectangle(new Vector2(160, 220), new Vector2(20, 20));


                if (Input.IsKeyboardKeyDown(KeyboardInput.H))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Black;
                }
                Draw.Rectangle(new Vector2(180, 200), new Vector2(20, 20));


                if (Input.IsKeyboardKeyDown(KeyboardInput.U))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Black;
                }
                Draw.Rectangle(new Vector2(200, 180), new Vector2(20, 20));


                if (Input.IsKeyboardKeyDown(KeyboardInput.Eight))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Black;
                }
                Draw.Rectangle(new Vector2(220, 160), new Vector2(20, 20));


                if (Input.IsKeyboardKeyDown(KeyboardInput.M))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Black;
                }
                Draw.Rectangle(new Vector2(220, 220), new Vector2(20, 20));


                if (Input.IsKeyboardKeyDown(KeyboardInput.T))
                {
                    Draw.FillColor = Color.Green;
                }
                else
                {
                    Draw.FillColor = Color.Black;
                }
                Draw.Rectangle(new Vector2(160, 160), new Vector2(20, 20));
            }


            //win condition booleans (determines if the player has met any of the 3 conditions to win the game)
            bool finWinCondition1 = false;
            bool finWinCondition2 = false;
            bool finWinCondition3 = false;

            //defining number of bubbles on screen & random bubble radius
            Vector2[] numberOfBubbles = { new Vector2(25) };

            float bubblesRadius = Random.Float(25);

            Vector2 winCondition2 = new Vector2(200, 200);

            for (int i = 0; i < 25; i++)
            {
                //random bubble positions- generates random Vector2 coordinates for each bubble that spawns
                Vector2 bubblePositions = Random.Vector2(380, 380);

                //drawing bubbles & making win conditions
                Draw.FillColor = bubbleBlue;
                if (Input.IsMouseButtonDown(MouseInput.Middle) && Window.CurrentFPS >= 30 && Window.CurrentFPS <= 40)
                {
                    Draw.FillColor = Color.Clear;
                    finWinCondition1 = true;
                }
                else if (Input.GetMousePosition() == winCondition2)
                {
                    Draw.FillColor = Color.Clear;
                    finWinCondition2 = true;
                }
                else if (Input.IsKeyboardKeyDown(KeyboardInput.B) && Input.IsKeyboardKeyDown(KeyboardInput.H) && Input.IsKeyboardKeyDown(KeyboardInput.U) && Input.IsKeyboardKeyDown(KeyboardInput.T) && Input.IsKeyboardKeyDown(KeyboardInput.M))
                {
                    Draw.FillColor = Color.Clear;
                    finWinCondition3 = true;
                }

                Draw.LineSize = 1;
                Draw.LineColor = Color.White;
                Draw.Circle(bubblePositions, bubblesRadius);


                //win conditions display the "you win" screen, and also make it so that the timer will not reach 30 seconds,
                //causing a game over screen after the player already won the game. 
                if (finWinCondition3 == true)
                {
                    Time.SecondsElapsed = -1000;
                    
                    Draw.FillColor = Color.OffWhite;
                    Draw.LineColor = Color.Black;
                    Draw.LineSize = 2;
                    Draw.Rectangle(new Vector2(100, 100), new Vector2(200, 200));
                    Text.Size = 30;
                    Text.Draw("YOU WIN!", new Vector2(135, 175));
                }
                else if (finWinCondition2 == true)
                {
                    Time.SecondsElapsed = -1000;

                    Draw.FillColor = Color.OffWhite;
                    Draw.LineColor = Color.Black;
                    Draw.LineSize = 2;
                    Draw.Rectangle(new Vector2(100, 100), new Vector2(200, 200));
                    Text.Size = 30;
                    Text.Draw("YOU WIN!", new Vector2(135, 175));
                }
                else if (finWinCondition1 == true)
                {
                    Time.SecondsElapsed = -1000;

                    Draw.FillColor = Color.OffWhite;
                    Draw.LineColor = Color.Black;
                    Draw.LineSize = 2;
                    Draw.Rectangle(new Vector2(100, 100), new Vector2(200, 200));
                    Text.Size = 30;
                    Text.Draw("YOU WIN!", new Vector2(135, 175));
                }
            }

            //timer & game over conditions- if timer reaches 30 seconds, game over screen will display
            Text.Draw($"{secondsElapsed}", new Vector2(0, 0));
            Text.Size = 20;
            if (Time.SecondsElapsed >= 30)
            {

                Draw.FillColor = Color.Red;
                Draw.Rectangle(new Vector2(0, 0), new Vector2(400, 400));
                Text.Size = 50;
                Text.Draw("GAME OVER!", new Vector2(65, 200));


            }
        }

    }
}
