using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MotaGame;

public class Monster : MonoBehaviour
{
    private bool InTrigger = false;
    private GameObject player;
    
    public int mLifeValue;        // 怪物生命值
    public int mAttackValue;     // 怪物攻击值
    public int mDefenseValue;     // 怪物防御值
    public int mBounty;           // 击杀怪物赏金

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && InTrigger)
        {
            this.Attact();
        }
    }

    public void Attact()
    {
        PlayerManager manager = PlayerManager.GetInstance();
        int playerLife = manager.lifeValue;
        int playerAttackValue = manager.attackValue;
        int playerDefenseValue = manager.defenseValue;

        while (true)
        {
            Debug.Log("玩家生命  : " + playerLife);
            Debug.Log("玩家攻击力  : " + playerAttackValue);
            Debug.Log("玩家防御力  : " + playerDefenseValue);
            Debug.Log("怪物生命  : " + mLifeValue);
            Debug.Log("玩家攻击力  : " + mAttackValue);
            Debug.Log("玩家防御力  : " + mDefenseValue);

            // 玩家先发起攻击
            mLifeValue -= ((playerAttackValue - mDefenseValue) > 0 ? (playerAttackValue - mDefenseValue) : 0);
            if (mLifeValue <= 0)
            {
                Debug.Log("玩家先发起攻击 playerLife : " + playerLife);
                Debug.Log("玩家先发起攻击 mLifeValue : " + mLifeValue);
                PlayerVictory(playerLife,mBounty);
                return;
            }

            // 怪物发起攻击
            playerLife -= ((mAttackValue - playerDefenseValue) > 0 ? (mAttackValue - playerDefenseValue) : 0);
            if (playerLife <= 0)
            {
                Debug.Log("玩家先发起攻击 playerLife : " + playerLife);
                Debug.Log("玩家先发起攻击 mLifeValue : " + mLifeValue);
                PlayerDefeat();
                return;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.CompareTag("Player"))
    	{
    		InTrigger = true;
            player = collision.gameObject;
            PlayerMove.instance.monster = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            InTrigger = false;
            player = collision.gameObject;
            PlayerMove.instance.monster = null;
        }
    }

    private void PlayerVictory (int life, int gold) 
    {
        Debug.Log("playerVictory");
        PlayerManager manager = PlayerManager.GetInstance();
        manager.UpdateLifeValue(life);
        int gg = manager.goldValue + gold;
        manager.UpdateGoldValue(gg);

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
