using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace semester_1
{
    public class Enemy : GameObject
    {
        protected int healthEnemy;

       public Enemy()
        {
            healthEnemy = 100;
        }


        public override void LoadContent(ContentManager content)
        {
            
        }

        public override void Update(GameTime gameTime)
        {
            Ami(gameTime);
        }
    }
}
