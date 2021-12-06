using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace semester_1
{
    internal class Player : GameObject
    {



        private KeyboardState keyboard;
        private bool canFire = true;


        public ArcherSprite archerSprite;

        protected Texture2D archerIdle;
        protected Texture2D archerd;
        protected Texture2D archer2;
        protected HostileRunningReaper hostileRunning;


        int counter = 1;
        int limit = 50;
        float countDuration = 0.016f; //every  2s.
        float currentTime = 0f;



        public Player()
        {
            Health = 100;
            HealthEnemy = 100;
            
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

        public async System.Threading.Tasks.Task DelayTask(double Time)
        {
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(Time));
        }


        private async void Input(GameTime gameTime)
        {


            keyboard = Keyboard.GetState();
            //Input



            if (keyboard.IsKeyDown(Keys.Q))
            {
                if (canFire == true)
                {
                    canFire = false;
                    if (PlayerTurn == false)
                    {


                        archerSprite = new ArcherSprite(archerd, 1, 14);


                        HealthEnemy -= 10;

                        PlayerTurn = true;

                        PlayerTurnEnemy = true;



                    }
                    if (PlayerTurn == true)
                    {

                        currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                        if (currentTime >= countDuration)
                        {

                            archerSprite = new ArcherSprite(archerIdle, 1, 8);
                            hostileRunning = new HostileRunningReaper(reaperIdle, 1, 5);
                            currentTime -= countDuration;
                            await DelayTask(1.5);

                            Health -= 10;

                            PlayerTurn = false;


                        }
                    }
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



        }



        public override void Update(GameTime gameTime)
        {
            if (Health <= 0)
            {
                Health = 0;
            }
            if (HealthEnemy <= 0)
            {
                HealthEnemy = 0;
            }


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
            archerSprite.Draw(spriteBatch, new Vector2(100, 300), SpriteEffects.None);

        }
    }
}
