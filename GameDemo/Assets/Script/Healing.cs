using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MotaGame;

public class Healing : MonoBehaviour
{
    private bool InTrigger = false;
    private GameObject player;

    private int HealingLifeValue = 500;

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
        PlayerMove.instance.healing = null;

        PlayerManager manager = PlayerManager.GetInstance();
        int life = manager.lifeValue + HealingLifeValue;
        manager.UpdateLifeValue(life);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.CompareTag("Player"))
    	{
    		InTrigger = true;
            player = collision.gameObject;
            PlayerMove.instance.healing = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            InTrigger = false;
            player = null;
            PlayerMove.instance.healing = null;
        }
    }
}
