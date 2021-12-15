using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace semester_1
{
    public class GameWorld : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private SpriteFont text;
        List<GameObject> gameObjects = new List<GameObject>();

        private Player newObjectsPlayer;
        private Rectangle? srcRect;
        private Vector2 position1;
        private Texture2D tex;
  

        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            gameObjects = new List<GameObject>();

            newObjectsPlayer = new Player();

            gameObjects.Add(new Enemy());

            gameObjects.Add(newObjectsPlayer);


            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            text = Content.Load<SpriteFont>("File");

            tex = Content.Load<Texture2D>("unknown");



            foreach (var item in gameObjects)
            {
                item.LoadContent(this.Content);

            }


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();




            foreach (var item in gameObjects)
            {
                item.Update(gameTime);

            }





            // TODO: Add your update logic here

            base.Update(gameTime);
        }



        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(tex, position1, srcRect, Color.White, 0f, Vector2.Zero, 0.8f, SpriteEffects.None, 0f);




            foreach (var item in gameObjects)
            {
                item.Draw(spriteBatch);

            }

            spriteBatch.DrawString(text, "Heatlh: " + newObjectsPlayer.Health.ToString(), new Vector2(20, 20), Color.Green, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 1f);
            spriteBatch.DrawString(text, "Mana: " + newObjectsPlayer.Mana.ToString(), new Vector2(20, 50), Color.Blue, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 1f);

            spriteBatch.DrawString(text, "Heatlh: " + newObjectsPlayer.HealthEnemy.ToString(), new Vector2(600, 20), Color.Green, 0f, Vector2.Zero, 1.5f, SpriteEffects.None, 1f);


            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}