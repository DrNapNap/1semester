using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace semester_1
{
    internal class Player : GameObject
    {

        private int healthPlayer;

        private KeyboardState keyboard;
        private bool canFire = true;


        public ArcherSprite archerSprite;
        protected Texture2D archerIdle;
        protected Texture2D archerd;
        protected Texture2D archer2;


        public Player()
        {

            this.healthPlayer = health;

        }

        public override void LoadContent(ContentManager content)
        {



            timer = 510;
            threshold = 50;

            archerIdle = content.Load<Texture2D>("spr_ArcherIdle_strip_NoBkg");
            archerd = content.Load<Texture2D>("spr_ArcherAttack_strip_NoBkg");
            archer2 = content.Load<Texture2D>("spr_ArcherMelee_strip_NoBkg");

            archerSprite = new ArcherSprite(archerIdle, 1, 8);

            // health Player




        }


        private void Input(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();


            //Input

            if (playerTurn == true)
            {


                if (keyboard.IsKeyDown(Keys.Q))
                {
                    if (canFire == true)
                    {
                        canFire = false;
                        archerSprite = new ArcherSprite(archerd, 1, 14);
                      
                    }

                }
                else if (keyboard.IsKeyDown(Keys.W))
                {
                    if (canFire == true)
                    {

                        archerSprite = new ArcherSprite(archer2, 1, 28);
                        canFire = false;
                    }
                }
                else if (keyboard.IsKeyDown(Keys.E))
                {
                    if (canFire == true)
                    {

                        archerSprite = new ArcherSprite(archerd, 1, 14);
                        canFire = false;
                    }
                }
                else if (keyboard.IsKeyDown(Keys.R))
                {
                    if (canFire == true)
                    {
                        canFire = false;
                        archerSprite = new ArcherSprite(archer2, 1, 28);


                    }
                }

                if (keyboard.IsKeyUp(Keys.Q))
                {
                    canFire = true;
                }
                if (keyboard.IsKeyUp(Keys.W))
                {
                    canFire = true;
                }
                if (keyboard.IsKeyUp(Keys.E))
                {
                    canFire = true;
                }
                if (keyboard.IsKeyUp(Keys.R))
                {
                    canFire = true;

                }
 playerTurn = false;

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

        public override void Draw(SpriteBatch spriteBatch)
        {
            archerSprite.Draw(spriteBatch, new Vector2(100, 300));

        }
    }
}
