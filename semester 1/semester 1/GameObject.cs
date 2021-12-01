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

        public Texture2D sprite;

        // A timer that stores milliseconds.
        public float timer;
        // An int that is the threshold for the timer.
        public int threshold;
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

        protected int health ;

        public bool tjekAnimationsMelee;




        
        protected Texture2D archerIdle;
        protected Texture2D archer;
        protected Texture2D archer2;


        public ArcherSprite archerSprite;




        protected GameObject()
        {
            health = 100;
        }


        public abstract void Update(GameTime gameTime);

        public abstract void LoadContent(ContentManager content);


        public void Draw(SpriteBatch spriteBatch)
        {

                archerSprite.Draw(spriteBatch, new Vector2(100, 300));

        }



    }
}
