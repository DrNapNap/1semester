using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Threading.Tasks;

namespace semester_1
{
    public class Enemy : GameObject
    {





        public override void Draw(SpriteBatch spriteBatch)
        {
            hostileRunning.Draw(spriteBatch, new Vector2(300, 300), SpriteEffects.None);

        }

        public override void LoadContent(ContentManager content)
        {

            
      


            timer = 0;
            threshold = 110;

            reaperIdle = content.Load<Texture2D>("PassiveIdleReaper-Sheet");


            HostileAttackReaper = content.Load<Texture2D>("HostileAttackReaper-Sheet");
            HolsterWeaponReaper = content.Load<Texture2D>("HolsterWeaponReaper");
            HostileRunningReaper = content.Load<Texture2D>("PassiveRunningReaper-Sheet");

       
            

            hostileRunning = new HostileRunningReaper(reaperIdle, 1, 5);

            // health Player

        }






        public override void Update(GameTime gameTime)
        {





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
