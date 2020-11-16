using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MotaGame
{
    public class PlayerManager
    {
        public int yellowKeyNumber = 0;
        public int lifeValue = 100;
        public int defenseValue = 100;
        public int goldValue = 0;

        private static PlayerManager instance;
        private static object _lock=new object();

        private PlayerManager()
        {

        }

        public static PlayerManager GetInstance()
        {
            if(instance==null)
            {
                lock(_lock)
                    {
                        if(instance==null)
                        {
                            instance=new PlayerManager();
                        }
                    }
                }
            return instance;
        }
    }
}