using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MotaGame
{
    public class PlayerManager
    {
        public int yellowKeyNumber = 0;     // 黄色钥匙
        public int lifeValue = 100;         // 生命值
        public int attackValue = 100;       // 攻击值
        public int defenseValue = 50;       // 防御值
        public int goldValue = 0;           // 金币

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