using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace semester_1
{
    public class Enemy : GameObject
    {

       



        public override void Draw(SpriteBatch spriteBatch)
        {
            hostileRunning.Draw(spriteBatch, new Vector2(400, 380), SpriteEffects.None);

        }

        public override void LoadContent(ContentManager content)
        {





            timer = 0;
            threshold = 110;

            reaperIdle = content.Load<Texture2D>("PassiveIdleReaper-Sheet");


            HostileAttackReaper = content.Load<Texture2D>("HostileAttackReaper-Sheet_Flipped");
            HolsterWeaponReaper = content.Load<Texture2D>("HolsterWeaponReaper");
            HostileRunningReaper = content.Load<Texture2D>("PassiveRunningReaper-Sheet_Flipped");




            hostileRunningd = new HostileRunningReaper(reaperIdle, 1, 5);



            hostileRunning = hostileRunningd;

 

            // health Player

        }


        public Enemy()
        {

            animation1 = playerTurnEnemy;


        }


        public override void Update(GameTime gameTime)
        {
           if (animation1)
            {
                hostileRunningd = new HostileRunningReaper(HostileAttackReaper, 1, 10);
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
