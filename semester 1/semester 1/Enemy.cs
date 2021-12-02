using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace semester_1
{
    public class Enemy : GameObject
    {
        public int healthEnemy;


        public HostileRunningReaper hostileRunning;
        protected Texture2D reaperIdle;

        private int attack;


        public Enemy()
        {
            healthEnemy = 100;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            hostileRunning.Draw(spriteBatch, new Vector2(300, 300));
        }

        public override void LoadContent(ContentManager content)
        {



            timer = 0;
            threshold = 50;

            reaperIdle = content.Load<Texture2D>("HolsterWeaponReaper");


            hostileRunning = new HostileRunningReaper(reaperIdle, 1, 10);

            // health Player

        }




        public override void Update(GameTime gameTime)
        {
            if (playerTurn == false)
            {

                health -= 10;


            }



            if (timer > threshold)
            {
                hostileRunning.Update();
                timer = 0;
            }
            else
            {
                timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }

        }
    }
}
