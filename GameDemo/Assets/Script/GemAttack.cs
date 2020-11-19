using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MotaGame;

public class GemAttack : MonoBehaviour
{
    private bool InTrigger = false;
    private GameObject player;

    private int attackValue = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && InTrigger)
        {
            this.PikcUp();
        }
    }

    public void PikcUp ()
    {
        Debug.Log("get healing");
        gameObject.SetActive(false);
        PlayerMove.instance.gemAttack = null;

        PlayerManager manager = PlayerManager.GetInstance();
        int attack = manager.attackValue + attackValue;
        manager.UpdateAttackValue(attack);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.CompareTag("Player"))
    	{
    		InTrigger = true;
            player = collision.gameObject;
            PlayerMove.instance.gemAttack = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            InTrigger = false;
            player = null;
            PlayerMove.instance.gemAttack = null;
        }
    }
}
