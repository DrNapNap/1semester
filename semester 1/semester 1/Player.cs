using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace semester_1
{
    internal  class Player : GameObject
    {

        private int healthPlayer;

        private KeyboardState keyboard;
    

        public Player()
        {

            this.healthPlayer = health;

        }

        public override void LoadContent(ContentManager content)
        {
            // Set a default timer value.
            timer = 0;
            // Set an initial threshold of 250ms, you can change this to alter the speed of the animation (lower number = faster animation).
            threshold = 150;


            sourceRectanglesMelee = new Rectangle[12];
            sourceRectanglesMelee[0] = new Rectangle(48, 0, 48, 128);
            sourceRectanglesMelee[1] = new Rectangle(48, 0, 48, 128);
            sourceRectanglesMelee[2] = new Rectangle(48, 0, 48, 128);
            sourceRectanglesMelee[3] = new Rectangle(48, 0, 48, 128);
            sourceRectanglesMelee[4] = new Rectangle(611, 0, 48, 128);
            sourceRectanglesMelee[5] = new Rectangle(611, 0, 48, 128);
            sourceRectanglesMelee[6] = new Rectangle(611, 0, 48, 128);
            sourceRectanglesMelee[7] = new Rectangle(611, 0, 48, 128);
            sourceRectanglesMelee[8] = new Rectangle(611, 0, 48, 128);
            sourceRectanglesMelee[9] = new Rectangle(611, 0, 48, 128);
            sourceRectanglesMelee[10] = new Rectangle(611, 0, 48, 128);
            sourceRectanglesMelee[11] = new Rectangle(611, 0, 48, 128);


            sourceRectangles = new Rectangle[12];
            sourceRectangles[0] = new Rectangle(48, 0, 48, 128);
            sourceRectangles[1] = new Rectangle(48, 0, 48, 128);
            sourceRectangles[2] = new Rectangle(48, 0, 48, 128);
            sourceRectangles[3] = new Rectangle(48, 0, 48, 128);
            sourceRectangles[4] = new Rectangle(203, 0, 48, 128);
            sourceRectangles[5] = new Rectangle(203, 0, 48, 128);
            sourceRectangles[6] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[7] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[8] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[9] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[10] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[11] = new Rectangle(332, 0, 48, 128);
            // This tells the animation to start on the left-side sprite.
            previousAnimationIndex = 2;
            currentAnimationIndex = 1;

            animationsIdle = content.Load<Texture2D>("spr_ArcherJumpAndFall_strip_NoBkg");
            animationsMelee = content.Load<Texture2D>("spr_ArcherMelee_strip_NoBkg");





            // health Player




        }


        private void Input(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();
  

            //Input
            if (keyboard.IsKeyDown(Keys.D))
            {
                tjek = true;


            }
            else if (keyboard.IsKeyDown(Keys.A))
            {
               
               
            }
            else if (keyboard.IsKeyDown(Keys.W))
            {
               
                
            }
            else if (keyboard.IsKeyDown(Keys.S))
            {
                
                
            }




        }



        public override void Update(GameTime gameTime)
        {
            
         Input(gameTime);   
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
