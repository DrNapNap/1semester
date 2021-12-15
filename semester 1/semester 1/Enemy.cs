using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace semester_1
{
    public class Enemy : GameObject
    {

        private float timerEnemy;
        private int thresholdEnemy;

        private HostileRunningReaper hostileRunningd;

        private HostileRunningReaper hostileRunningT;


        public override void Draw(SpriteBatch spriteBatch)
        {
            hostileRunning.Draw(spriteBatch, new Vector2(400, 380), SpriteEffects.None);

        }

        public override void LoadContent(ContentManager content)
        {
            timerEnemy = 0;
            thresholdEnemy = 110;

            reaperIdle = content.Load<Texture2D>("PassiveIdleReaper-Sheet");


            HostileAttackReaper = content.Load<Texture2D>("HostileAttackReaper-Sheet_Flipped");
            HolsterWeaponReaper = content.Load<Texture2D>("HolsterWeaponReaper");
            HostileRunningReaper = content.Load<Texture2D>("PassiveRunningReaper-Sheet_Flipped");

            hostileRunningd = new HostileRunningReaper(reaperIdle, 1, 5);

            

            hostileRunning = hostileRunningd;
        }


        public Enemy()
        {

            animation1 = PlayerTurnEnemy;


        }


        public override void Update(GameTime gameTime)
        {
           if (animation1 == true)
            {
                hostileRunningT = new HostileRunningReaper(HostileAttackReaper, 1, 10);
                hostileRunning = hostileRunningT;
            }

            if (timerEnemy > thresholdEnemy)
            {
                hostileRunning.Update();
                timerEnemy = 0;
            }
            else
            {
                timerEnemy += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            }


        }
    }
}
