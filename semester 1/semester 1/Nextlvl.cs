using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace semester_1
{
    class Nextlvl : Enemy
    {
        //Singelton for instancing in other scripts
        private static Nextlvl instance = null;

        public static Nextlvl Instance
        {
            get
            {
                if (instance == null)
                    instance = new Nextlvl();

                return instance;
            }
        }


        private const float Delay = 5; //seconds
        private float RemainingDelay = Delay;
        private SpriteFont font;
        private bool winResult = false;
        private LevelManager LvlManager = new LevelManager();

        private int level = 0;

        private SpriteEffects Effect;

        //Sets condition for level completion
        public void WinCondition()
        {
            bool result = true;

       
                if (healthEnemy == 0)
                {
                    result = false;
                 
                }
            

            winResult = result;
        }

        //loads the font
        public void LoadContent(ContentManager Content)
        {
            font = Content.Load<SpriteFont>("Level");
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            if (winResult)
            {
                //Displays message for level completion
                spriteBatch.DrawString(font, "Level Complete", new Vector2(340, 50), Color.White, 0, Vector2.One, 1, Effect, 0.3f);

                //Delays next level for enough time to display the level completeion message
                var timer = (float)gameTime.ElapsedGameTime.TotalSeconds;
                RemainingDelay -= timer;
                if (RemainingDelay <= 0)
                {
                    //resets to lvl 2 (index 1) if it exceeds level count
                    level++;
                    if (level > LvlManager.levelHolder.Count)
                        level = 0;

                    //Proceeds to next level/scene
                    if (level != 0)
                    {
                        LvlManager.LoadLevel(level);
                        RemainingDelay = Delay;
                        winResult = false;
                    }
                }


            }



        }

    }
}
