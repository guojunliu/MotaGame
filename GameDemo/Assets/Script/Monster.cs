using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MotaGame;

public class Monster : MonoBehaviour
{
    private bool InTrigger = false;
    private GameObject player;
    
    public int mLifeValue = 20;        // 怪物生命值
    public int mAttackValue = 20;     // 怪物攻击值
    public int mDefenseValue = 20;     // 怪物防御值
    public int mBounty = 10;           // 击杀怪物赏金

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && InTrigger)
        {
            PlayerManager manager = PlayerManager.GetInstance();
            int playerLife = manager.lifeValue;
            int playerAttackValue = manager.attackValue;
            int playerDefenseValue = manager.defenseValue;

            while(true)
            {
                // 玩家先发起攻击
                mLifeValue -= (playerAttackValue - mDefenseValue)>0?(playerAttackValue - mDefenseValue):0;
                if (mLifeValue <= 0) 
                {
                    PlayerVictory();
                    manager.lifeValue = playerLife;
                    return;
                }

                // 怪物发起攻击
                playerLife -= (mAttackValue - playerDefenseValue)>0?(mAttackValue - playerDefenseValue):0;
                if (playerLife <= 0) 
                {
                    PlayerDefeat();
                    return;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.CompareTag("Player"))
    	{
    		InTrigger = true;
            player = collision.gameObject;
    	}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            InTrigger = false;
            player = collision.gameObject;
        }
    }

    private void PlayerVictory () 
    {
        Debug.Log("playerVictory");
        PlayerManager manager = PlayerManager.GetInstance();
        manager.goldValue += mBounty;

        gameObject.SetActive(false);
    }

    private void PlayerDefeat () 
    {
        Debug.Log("PlayerDefeat");
        // PlayerManager manager = PlayerManager.GetInstance();
        // manager.goldValue += mBounty;

        // gameObject.SetActive(false);
    }
}
