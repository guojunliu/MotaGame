using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MotaGame;

public class GemDefense : MonoBehaviour
{
    private bool InTrigger = false;
    private GameObject player;

    private int defenseValue = 10;

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
        PlayerMove.instance.gemDefense = null;

        PlayerManager manager = PlayerManager.GetInstance();
        int defense = manager.defenseValue + defenseValue;
        manager.UpdateDefenseValue(defense);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.CompareTag("Player"))
    	{
    		InTrigger = true;
            player = collision.gameObject;
            PlayerMove.instance.gemDefense = this;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            InTrigger = false;
            player = null;
            PlayerMove.instance.gemDefense = null;
        }
    }
}
