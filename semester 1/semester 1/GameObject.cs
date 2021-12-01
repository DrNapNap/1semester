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
        public Vector2 scale = Vector2.One;

        protected Vector2 Origin;

        public Texture2D sprite;

        // A timer that stores milliseconds.
        public float timer;
        // An int that is the threshold for the timer.
        public int threshold;
        // A Rectangle array that stores sourceRectangles for animations.

        // These bytes tell the spriteBatch.Draw() what sourceRectangle to display.
        protected byte previousAnimationIndex;
        protected byte currentAnimationIndex;

        protected Rectangle[] sourceRectangles;

        //Rendering
        public float layerDepth;
        protected SpriteEffects effect;
        public Rectangle rectangle;

        public Rectangle CollisionBox { get; internal set; }

        protected GameObject()
        {
  
        }


        public abstract void Update(GameTime gameTime);

        public abstract void LoadContent(ContentManager content);


        public void Draw(SpriteBatch spriteBatch )
        {
            spriteBatch.Draw(sprite, new Vector2(100, 100), sourceRectangles[currentAnimationIndex], Color.White);
        }

    }
}
