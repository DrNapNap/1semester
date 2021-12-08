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

        public Texture2D sprite;

        // A timer that stores milliseconds.
        public float timer;
        // An int that is the threshold for the timer.
        public int threshold;
        // A Rectangle array that stores sourceRectangles for animations.

        // These bytes tell the spriteBatch.Draw() what sourceRectangle to display.
        protected byte previousAnimationIndex;
        protected byte currentAnimationIndex;


        public  Texture2D reaperIdle;
        public  Texture2D HolsterWeaponReaper;


        public static Texture2D HostileAttackReaper;
        public Texture2D HostileIdleReaper;
        public Texture2D HostileRunningReaper;


        public HostileRunningReaper hostileRunning;
        public  HostileRunningReaper hostileRunningd;
    
        


        //Rendering
        public float layerDepth;
        protected SpriteEffects effect;
        public Rectangle rectangle;

        private int health;

        private int healthEnemy;

        private bool playerTurn;

        public bool playerTurnEnemy;
        public bool animation1;

        public GameObject()
        {
            
        }

        public bool PlayerTurnEnemy { get => playerTurnEnemy; set => playerTurnEnemy = value; }
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
