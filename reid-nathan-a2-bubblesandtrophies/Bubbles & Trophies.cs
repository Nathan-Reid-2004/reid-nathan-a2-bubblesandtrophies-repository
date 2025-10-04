// Include the namespaces (code libraries) you need below.
using System;
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
            Window.SetTitle ("Bubbles & Trophies");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;

            //bubbles radius and position picker
            int maxBubbles = 25;
            Vector2[] randomBubbles = new Vector2[maxBubbles];

            for (int i = 0; i < maxBubbles; i++)
            {
                randomBubbles[i] = Random.Vector2(380, 380);
                float bubblesRadius = Random.Float(25);


                //Draw.FillColor = bubbleBlue;
                //Draw.LineSize = 1;
                //Draw.LineColor = Color.White;
                //Draw.Circle(randomBubbles[i], bubblesRadius);

            }
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

            //drawing various functions (functions listed below)
            drawWall();
            drawBomb();


            //bomb main rectangle & small decor rectanges within the bomb
            void drawBomb()
            {
                Draw.FillColor = Color.Red;
                Draw.Rectangle(new Vector2(160, 160), new Vector2(80, 80));

                Draw.FillColor = Color.Black;
                Draw.Rectangle(new Vector2(160, 220), new Vector2(20, 20));

                Draw.FillColor = Color.Black;
                Draw.Rectangle(new Vector2(180, 200), new Vector2(20, 20));

                Draw.FillColor = Color.Black;
                Draw.Rectangle(new Vector2(200, 180), new Vector2(20, 20));

                Draw.FillColor = Color.Black;
                Draw.Rectangle(new Vector2(220, 160), new Vector2(20, 20));

                Draw.FillColor = Color.Black;
                Draw.Rectangle(new Vector2(160, 160), new Vector2(20, 20));

                Draw.FillColor = Color.Black;
                Draw.Rectangle(new Vector2(220, 220), new Vector2(20, 20));
            }

            // player pointer
            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                Draw.FillColor = pointerOrange;
            }
            else
            {
                Draw.FillColor = Color.Blue;
            }
            Draw.LineColor = Color.Black;
            Draw.LineSize = 3;
            Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 10);



            // wall border lines
            void drawWall()
            {
                Draw.LineSize = 3;
                Draw.LineColor = Color.Red;
                Draw.Line(new Vector2(20, 20), new Vector2(380, 20));

                Draw.LineSize = 3;
                Draw.LineColor = Color.Red;
                Draw.Line(new Vector2(20, 20), new Vector2(20, 380));

                Draw.LineSize = 3;
                Draw.LineColor = Color.Red;
                Draw.Line(new Vector2(20, 380), new Vector2(380, 380));

                Draw.LineSize = 3;
                Draw.LineColor = Color.Red;
                Draw.Line(new Vector2(380, 380), new Vector2(380, 20));
            }

            


        }
    }

}
