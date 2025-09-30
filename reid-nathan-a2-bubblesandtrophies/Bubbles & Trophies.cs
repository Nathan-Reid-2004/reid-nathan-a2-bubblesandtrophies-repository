// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

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
            Window.TargetFPS = 1;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Gray);


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
            Draw.LineSize = 3;
            Draw.LineColor = Color.Red;
        }
    }

}
