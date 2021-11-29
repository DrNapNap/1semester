using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace semester_1
{
    class Player : GameObject
    {
        private Texture2D charaset;
        // A timer that stores milliseconds.
        float timer;
        // An int that is the threshold for the timer.
        int threshold;
        // A Rectangle array that stores sourceRectangles for animations.
        Rectangle[] sourceRectangles;
        // These bytes tell the spriteBatch.Draw() what sourceRectangle to display.
        byte previousAnimationIndex;
        byte currentAnimationIndex;

        public override void Draw(SpriteBatch spriteBatch)
        {
            // Draw the entire sprite.
            spriteBatch.Draw(charaset, new Vector2(100, 100), Color.White);
            // Create a sourceRectangle.
            Rectangle sourceRectangle = new Rectangle(0, 0, 48, 64);
            // Only draw the area contained within the sourceRectangle.
            spriteBatch.Draw(charaset, new Vector2(300, 100), sourceRectangle, Color.White);
        }

        public override void LoadContent(ContentManager content)
        {
            // Set a default timer value.
            timer = 0;
            // Set an initial threshold of 250ms, you can change this to alter the speed of the animation (lower number = faster animation).
            threshold = 250;
            // Three sourceRectangles contain the coordinates of Alex's three down-facing sprites on the charaset.
            sourceRectangles = new Rectangle[3];
            sourceRectangles[0] = new Rectangle(0, 128, 48, 64);
            sourceRectangles[1] = new Rectangle(48, 128, 48, 64);
            sourceRectangles[2] = new Rectangle(96, 128, 48, 64);
            // This tells the animation to start on the left-side sprite.
            previousAnimationIndex = 2;
            currentAnimationIndex = 1;

            charaset = content.Load<Texture2D>("");
            // Set the draw position.
            position = new Vector2(100, 100);

        }

        public override void Update(GameTime gameTime)
        {
            // Check if the timer has exceeded the threshold.
            if (timer > threshold)
            {
                // If Alex is in the middle sprite of the animation.
                if (currentAnimationIndex == 1)
                {
                    // If the previous animation was the left-side sprite, then the next animation should be the right-side sprite.
                    if (previousAnimationIndex == 0)
                    {
                        currentAnimationIndex = 2;
                    }
                    else
                    // If not, then the next animation should be the left-side sprite.
                    {
                        currentAnimationIndex = 0;
                    }
                    // Track the animation.
                    previousAnimationIndex = currentAnimationIndex;
                }
                // If Alex was not in the middle sprite of the animation, he should return to the middle sprite.
                else
                {
                    currentAnimationIndex = 1;
                }
                // Reset the timer.
                timer = 0;
            }
            // If the timer has not reached the threshold, then add the milliseconds that have past since the last Update() to the timer.
            else
            {
                timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }
        }
    }
}
