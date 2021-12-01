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
        private Texture2D[] animations;
        private KeyboardState keyboard;
        private Vector2 playerInput;

        public Player()
        {

            this.healthPlayer = health;

        }

        public override void LoadContent(ContentManager content)
        {
            // Set a default timer value.
            timer = 0;
            // Set an initial threshold of 250ms, you can change this to alter the speed of the animation (lower number = faster animation).
            threshold = 250;

            animation = new Texture2D[4];

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

            animations[0] = content.Load<Texture2D>("spr_ArcherIdle_strip_NoBkg");
            // Set the draw position.
            position = new Vector2(100, 100);


            sprite = animations[0];

            // health Player




        }


        private void Input(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();
            playerInput = Vector2.Zero;

            //Input
            if (keyboard.IsKeyDown(Keys.D))
            {
                playerInput = new Vector2(1, 0);
                animations = animationsRight;
            }
            else if (keyboard.IsKeyDown(Keys.A))
            {
                playerInput = new Vector2(-1, 0);
                animations = animationsLeft;
            }
            else if (keyboard.IsKeyDown(Keys.W))
            {
                playerInput = new Vector2(0, -1);
                animations = animationsUp;
            }
            else if (keyboard.IsKeyDown(Keys.S))
            {
                playerInput = new Vector2(0, 1);
                animations = animationsDown;
            }




        }



        public override void Update(GameTime gameTime)
        {

            Ami(gameTime);


        }
    }
}
