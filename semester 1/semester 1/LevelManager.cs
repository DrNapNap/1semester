using System;
using System.Collections.Generic;
using System.Text;

namespace semester_1
{
    class LevelManager
    {
        GameObjectManager objectManeger = GameObjectManager.Instance;

        public List<int[,]> levelHolder = new List<int[,]>();


        public LevelManager()
        {
            levelHolder.Add(LevelData.level_0);
            levelHolder.Add(LevelData.level_1);
            levelHolder.Add(LevelData.level_2);
            levelHolder.Add(LevelData.level_3);
            levelHolder.Add(LevelData.level_4);
        }

        private GameObject Object(int whatObjects, float xPos, float yPos)
        {
            switch (whatObjects)
            {
                case 4:
                    return new Player(xPos, yPos);
            }

            return null;
        }

        public void LoadLevel(int targetLevel)
        {
            int[,] spawnLevel = new int[0, 0];

            try
            {
                spawnLevel = levelHolder[targetLevel];

                //Remove old level
                if (objectManeger.GameObjects.Count > 0)
                {
                    foreach (var item in objectManeger.GameObjects)
                    {
                        objectManeger.Destory(item);
                    }
                }

                //Insert level
                for (int y = 0; y < spawnLevel.GetLength(1); y++)
                {
                    for (int x = 0; x < spawnLevel.GetLength(0); x++)
                    {
                        //Add floor if needed
                        if (spawnLevel[x, y] > 1)
                            objectManeger.Instantiate(Object(0, x, y));

                        //Spawn object
                        objectManeger.Instantiate(Object(spawnLevel[x, y], x, y));
                    }
                }

                objectManeger.UpdateLoop();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"No level of {targetLevel} number found. There are {levelHolder.Count} levels");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("heJ" + e.Message);
            }
        }
    }
}
