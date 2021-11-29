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
      

        //Rendering
        public float layerDepth;
        protected SpriteEffects effect;
        public Rectangle rectangle;



        protected GameObject()
        {
  
        }


        public abstract void Update(GameTime gameTime);

        public abstract void LoadContent(ContentManager content);

        public abstract void Draw(SpriteBatch spriteBatch);

    }
}
