using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MotaGame
{
    public class PlayerManager
    {
        public int yellowKeyNumber = 0;     // 黄色钥匙
        public int lifeValue = 300;         // 生命值
        public int attackValue = 50;       // 攻击值
        public int defenseValue = 20;       // 防御值
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

        public void UpdateLifeValue (int value)
        {
            lifeValue = value;
            LifeValue.instance.UpdateLiftValue(value);
        }

        public void UpdateAttackValue(int value)
        {
            attackValue = value;
            AttackValue.instance.UpdateValue(value);
        }

        public void UpdateDefenseValue(int value)
        {
            defenseValue = value;
            DefenseValue.instance.UpdateValue(value);
        }

        public void UpdateGoldValue(int value)
        {
            goldValue = value;
            GoldValue.instance.UpdateValue(value);
        }
    }
}