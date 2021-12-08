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


        private ArcherSprite archerSprite;

        protected Texture2D archerIdle;
        protected Texture2D archerd;
        protected Texture2D archer2;




        int counter = 1;
        int limit = 50;
        float countDuration = 0.016f; //every  2s.
        float currentTime = 0f;

        private int mana;

       


        public int Mana { get => mana; }

        public Player()
        {
            Health = 100;
            HealthEnemy = 100;
            mana = 50;
            


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



        //private static void animation1(Enemy dwadwa)
        //{
        //    dwadwa.hostileRunningadwwad = new HostileRunningReaper(HostileAttackReaper, 1, 10);
        //}


        private async void Input(GameTime gameTime)
        {


            keyboard = Keyboard.GetState();
            //Input

            var random = new Random();

            if (keyboard.IsKeyDown(Keys.Q))
            {
                if (canFire == true && mana >= 3)
                {
                    canFire = false;
                    if (PlayerTurn == false)
                    {
                        int ranHealth = random.Next(1, 19);

                        archerSprite = new ArcherSprite(archerd, 1, 14);
                        await DelayTask(1.5);

                        playerTurnEnemy = true;

                         mana -= 3;
                        HealthEnemy -= ranHealth;

                        PlayerTurn = true;

                    }
                    if (PlayerTurn == true)
                    {
                        currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                        if (currentTime >= countDuration)
                        {
                            currentTime -= countDuration;
                            await DelayTask(1.5);
                            int healthEnemay = random.Next(1, 20);
                            //henlth

                            Health -= healthEnemay;
                            archerSprite = new ArcherSprite(archerIdle, 1, 8);
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



        private async void ManaAsync()
        {

            await DelayTask(300);

            mana++;

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

            if (mana <= 0)
            {
                mana = 0;
            }
            if (mana > 51)
            {
                mana = 50;
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


            ManaAsync();

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            archerSprite.Draw(spriteBatch, new Vector2(100, 300), SpriteEffects.None);

        }
    }
}
