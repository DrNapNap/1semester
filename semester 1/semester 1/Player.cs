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


        float countDuration = 0.016f; //every  2s.
        float currentTime = 0f;

        private int mana;

        private bool manaTrue;



        private float timer;
        private int threshold;

        public int Mana { get => mana; }

        public Player()
        {

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
                //if (mana < 3)
                //{
                //    canFire = false;
                //}

                if (canFire == true)
                {
                    canFire = false;
                    if (PlayerTurn == false)
                    {
                        int ranHealth = random.Next(1, 10);

                        archerSprite = new ArcherSprite(archerd, 1, 14);


                        PlayerTurnEnemy = true;

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
                            await DelayTask(2.0);
                            int healthEnemay = random.Next(1, 3);
                            //henlth

                            Health -= healthEnemay;
                            healthEnemay = 0;
                            archerSprite = new ArcherSprite(archerIdle, 1, 8);
                            PlayerTurn = false;
                        }
                    }




                }


            }
            else if (keyboard.IsKeyDown(Keys.W))
            {
                if (mana < 5)
                {
                    canFire = false;
                }

                if (canFire == true)
                {
                    canFire = false;
                    if (PlayerTurn == false)
                    {
                        int ranHealth = random.Next(1, 19);

                        archerSprite = new ArcherSprite(archer2, 1, 28);


                        PlayerTurnEnemy = true;

                        mana -= 5;
                        HealthEnemy -= ranHealth;

                        PlayerTurn = true;
                        await DelayTask(0.5);
                    }
                    if (PlayerTurn == true)
                    {
                        currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                        if (currentTime >= countDuration)
                        {
                            currentTime -= countDuration;
                            //delay
                            await DelayTask(2.0);
                            int healthEnemay = random.Next(1, 3);
                            //henlth

                            Health -= healthEnemay;
                            healthEnemay = 0;
                            archerSprite = new ArcherSprite(archerIdle, 1, 8);
                            PlayerTurn = false;
                        }
                    }


                }
                else if (keyboard.IsKeyDown(Keys.E))
                {


                    if (mana < 11)
                    {
                        canFire = false;
                    }

                    if (canFire == true)
                    {
                        canFire = false;
                        if (PlayerTurn == false)
                        {
                            int ranHealth = random.Next(1, 19);

                            archerSprite = new ArcherSprite(archerd, 1, 14);


                            PlayerTurnEnemy = true;

                            mana -= 11;
                            HealthEnemy -= ranHealth;

                            PlayerTurn = true;
                            await DelayTask(0.5);
                        }
                        if (PlayerTurn == true)
                        {
                            currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                            if (currentTime >= countDuration)
                            {
                                currentTime -= countDuration;
                                //delay
                                await DelayTask(2.0);
                                int healthEnemay = random.Next(1, 3);
                                //henlth

                                Health -= healthEnemay;
                                healthEnemay = 0;
                                archerSprite = new ArcherSprite(archerIdle, 1, 8);
                                PlayerTurn = false;
                            }
                        }


                    }
                }

                else if (keyboard.IsKeyDown(Keys.R))
                {

                    if (mana < 13)
                    {
                        canFire = false;
                    }

                    if (canFire == true)
                    {
                        canFire = false;
                        if (PlayerTurn == false)
                        {
                            int ranHealth = random.Next(1, 19);

                            archerSprite = new ArcherSprite(archer2, 1, 28);


                            PlayerTurnEnemy = true;

                            mana -= 13;
                            HealthEnemy -= ranHealth;

                            PlayerTurn = true;
                            await DelayTask(0.5);
                        }
                        if (PlayerTurn == true)
                        {
                            currentTime += (float)gameTime.ElapsedGameTime.TotalSeconds;
                            if (currentTime >= countDuration)
                            {
                                currentTime -= countDuration;
                                //delay
                                await DelayTask(2.0);
                                int healthEnemay = random.Next(1, 3);
                                //henlth

                                Health -= healthEnemay;
                                healthEnemay = 0;
                                archerSprite = new ArcherSprite(archerIdle, 1, 8);
                                PlayerTurn = false;
                            }
                        }


                    }

                }




            }
            CanFire();
        }


        private void CanFire()
        {
            if (keyboard.IsKeyUp(Keys.Q))
            {
                canFire = true;

            }
            else if (keyboard.IsKeyUp(Keys.W))
            {
                canFire = true;
            }
            else if (keyboard.IsKeyUp(Keys.E))
            {
                canFire = true;
            }
            else if (keyboard.IsKeyUp(Keys.R))
            {
                canFire = true;
            }

        }






        private async void ManaAsync()
        {


            if (manaTrue == true)
            {



                if (mana == 50)
                {
                    mana += 1;

                }
                else if (mana > 50)
                {
manaTrue = false;
                }

                
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

            if (mana <= 0)
            {
                mana = 0;

            }
            else if (mana <= 3)
            {
                manaTrue = true;
                ManaAsync();
            }
            if (mana > 50)
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




        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            archerSprite.Draw(spriteBatch, new Vector2(100, 300), SpriteEffects.None);

        }
    }
}
