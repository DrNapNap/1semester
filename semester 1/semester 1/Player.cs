using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace semester_1
{
    internal  class Player : GameObject
    {

        private int healthPlayer;

        public Player()
        {

            this.healthPlayer = health;

        }

        public override void LoadContent(ContentManager content)
        {
            // Set a default timer value.
            timer = 0;
            // Set an initial threshold of 250ms, you can change this to alter the speed of the animation (lower number = faster animation).
            threshold = 250;
          
            sourceRectangles = new Rectangle[12];
            sourceRectangles[0] = new Rectangle(48, 0, 48, 128);
            sourceRectangles[1] = new Rectangle(48, 0, 48, 128);
            sourceRectangles[2] = new Rectangle(48, 0, 48, 128);
            sourceRectangles[3] = new Rectangle(48, 0, 48, 128);
            sourceRectangles[4] = new Rectangle(203, 0, 48, 128);
            sourceRectangles[5] = new Rectangle(203, 0, 48, 128);
            sourceRectangles[6] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[7] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[8] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[9] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[10] = new Rectangle(332, 0, 48, 128);
            sourceRectangles[11] = new Rectangle(332, 0, 48, 128);
            // This tells the animation to start on the left-side sprite.
            previousAnimationIndex = 2;
            currentAnimationIndex = 1;

            sprite = content.Load<Texture2D>("spr_ArcherIdle_strip_NoBkg");
            // Set the draw position.
            position = new Vector2(100, 100);


            // health Player




        }





        public override void Update(GameTime gameTime)
        {

            Ami(gameTime);


        }
    }
}
