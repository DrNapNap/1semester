using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace semester_1
{
    public abstract class GameObject
    {
        //Transform
        public Vector2 position;
        public float rotaton;


        protected Vector2 Origen;

        protected Texture2D sprite;

        // A timer that stores milliseconds.
        protected float timer;
        // An int that is the threshold for the timer.
        protected int threshold;
        // A Rectangle array that stores sourceRectangles for animations.

        // These bytes tell the spriteBatch.Draw() what sourceRectangle to display.
        protected byte previousAnimationIndex;
        protected byte currentAnimationIndex;

        public Texture2D animationsIdle;
        public Texture2D animationsMelee;

        public Rectangle[] sourceRectangles;
        public Rectangle[] sourceRectanglesMelee;

        //Rendering
        public float layerDepth;
        protected SpriteEffects effect;
        public Rectangle rectangle;

        protected int health;

        public bool tjek;

        private float scale = 2.101f;


        public SpriteFont text;
       

        protected GameObject()
        {
            health = 100;
        }




        

        public abstract void Update(GameTime gameTime);

        public abstract void LoadContent(ContentManager content);


        public void Draw(SpriteBatch spriteBatch)
        {


            if (tjek == true)
            {

                spriteBatch.Draw(animationsMelee, new Vector2(100, 100), sourceRectanglesMelee[currentAnimationIndex], Color.White, 0, Origen, scale, effect, 0);

            }
            else
            {
                spriteBatch.Draw(animationsIdle, new Vector2(100, 100), sourceRectangles[currentAnimationIndex], Color.White, 0, Origen, scale, effect, 0);

                spriteBatch.GraphicsDevice.Clear(Color.Black);

                spriteBatch.DrawString(text, "Heatlh: " + health.ToString(), new Vector2(20, 20), Color.Red, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 1f);
            }

           


        }



    }
}
