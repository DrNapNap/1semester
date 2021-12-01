using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace semester_1
{
    class GameObjectManager
    {
        //Singelton
        private static GameObjectManager instance = null;
        private ContentManager content;

        private GameObjectManager()
        {
        }

        public static GameObjectManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new GameObjectManager();

                return instance;
            }
        }

        //Game object adding & removeing
        List<GameObject> addedGameObjects = new List<GameObject>(); //For gameobjectets der skal komme i gameObjevt listen
        List<GameObject> gameObjects = new List<GameObject>(); //For main loop
        List<GameObject> removingGameObjects = new List<GameObject>(); //For ting der skal fjernes
 
        #region Properties
        //GameObject
        public List<GameObject> GameObjects { get => gameObjects; set => gameObjects = value; }
        //Colision
        //public List<GameObjectWithCollider> CollisionList { get => collisionList; set => collisionList = value; }
        #endregion

        public void SetContentManeger(ContentManager content)
        {
            this.content = content;
        }


        public void UpdateLoop()
        {
            //Add if new gameobjects is added
            AddGameObjectToWorld();

            //Remove gameobjebts from the list
            RemoveGameObjectFromWorld();
        }

        public void Instantiate(GameObject target)
        {
            addedGameObjects.Add(target);
        }

        public void Destory(GameObject target)
        {
            removingGameObjects.Add(target);
        }

        public void ClearSceen()
        {
            foreach (var item in gameObjects)
            {
                Destory(item);
            }
        }

        private void AddGameObjectToWorld()
        {
            if (addedGameObjects.Count > 0)
            {
                for (int i = 0; i < addedGameObjects.Count; i++)
                {
                    addedGameObjects[i].LoadContent(content);
                    gameObjects.Add(addedGameObjects[i]);


                }
                addedGameObjects.Clear();
            }
        }

        private void RemoveGameObjectFromWorld()
        {
            if (removingGameObjects.Count > 0)
            {
                for (int i = 0; i < removingGameObjects.Count; i++)
                {
                    gameObjects.Remove(removingGameObjects[i]);


                }
                removingGameObjects.Clear();
            }
        }


    }
}
