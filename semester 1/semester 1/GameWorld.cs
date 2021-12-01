﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace semester_1
{
    public class GameWorld : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        List<GameObject> gameObjects = new List<GameObject>();


        private Texture2D collisionTexture;

        //Level
        private LevelManager levels = new LevelManager();

        //Gameobjcts
        private GameObjectManager objectManeger = GameObjectManager.Instance;


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



            gameObjects.Add(new Player());


            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);


            foreach (var item in gameObjects)
            {
                item.LoadContent(this.Content);

            }


            collisionTexture = Content.Load<Texture2D>("CollisionTexture");
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
            foreach (var item in gameObjects)
            {
                item.Draw(spriteBatch);
            }
            spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}