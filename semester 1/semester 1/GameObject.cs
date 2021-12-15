using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace semester_1
{
    public abstract class GameObject
    {
        //Transform
        public Vector2 position;
        public float rotaton;


        protected Vector2 Origen;

        // These bytes tell the spriteBatch.Draw() what sourceRectangle to display.
        protected byte previousAnimationIndex;
        protected byte currentAnimationIndex;


        public  Texture2D reaperIdle;
        public  Texture2D HolsterWeaponReaper;


        public static Texture2D HostileAttackReaper;
        public Texture2D HostileIdleReaper;
        public Texture2D HostileRunningReaper;


        public HostileRunningReaper hostileRunning;
        
    
        


        //Rendering
        public float layerDepth;
        public SpriteEffects effect;
        public Rectangle rectangle;

        private int health;

        private int healthEnemy;

        private bool playerTurn;

        private bool playerTurnEnemy;
        public bool animation1;

        public GameObject()
        {
            Health = 100;
            HealthEnemy = 100;
        }

        public bool PlayerTurnEnemy { get => playerTurnEnemy; set => playerTurnEnemy = value; }
        //public bool PlayerTurn { get => playerTurn; set => playerTurn = value; }
        public bool PlayerTurn { get => playerTurn; set => playerTurn = value; }
        public int HealthEnemy { get => healthEnemy; set => healthEnemy = value; }
        public int Health { get => health; set => health = value; }


        public abstract void Update(GameTime gameTime);

        public abstract void LoadContent(ContentManager content);


        public abstract void Draw(SpriteBatch spriteBatch);




        public async System.Threading.Tasks.Task DelayTask(double Time)
        {
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(Time));
        }








    }
}
