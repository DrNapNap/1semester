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



            timer = 0;
            threshold = 100;

            archerIdle = content.Load<Texture2D>("spr_ArcherIdle_strip_NoBkg");
            archer = content.Load<Texture2D>("spr_ArcherAttack_strip_NoBkg");
            archer2 = content.Load<Texture2D>("spr_ArcherMelee_strip_NoBkg");

            archerSprite = new ArcherSprite(archerIdle, 1, 8);

            // health Player




        }


        private void Input(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();
  

            //Input
            if (keyboard.IsKeyDown(Keys.Q))
            {
                
                archerSprite = new ArcherSprite(archer, 1, 14);

            }
            else if (keyboard.IsKeyDown(Keys.W))
            {
                archerSprite = new ArcherSprite(archer2, 1, 28);

            }
            else if (keyboard.IsKeyDown(Keys.E))
            {
                archerSprite = new ArcherSprite(archer, 1, 14);

            }
            else if (keyboard.IsKeyDown(Keys.R))
            {
                archerSprite = new ArcherSprite(archer2, 1, 28);

            }




        }



        public override void Update(GameTime gameTime)
        {
            
         Input(gameTime);

            if (timer > threshold)
            {
                archerSprite.Update();
                timer = 0;
            }
            else
            {
                timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }

        }
    }
}
