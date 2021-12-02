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

        protected int health;

        public int Health
        {
            get { return health = 100; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    health = value;
                }
            }
        }

        public bool playerTurn;







        protected GameObject()
        {
            health = 100;
        }


        public abstract void Update(GameTime gameTime);

        public abstract void LoadContent(ContentManager content);


        public abstract void Draw(SpriteBatch spriteBatch);
     


          

        



    }
}
