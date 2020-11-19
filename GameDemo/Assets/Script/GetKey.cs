using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MotaGame;

public class GetKey : MonoBehaviour
{
    private bool InTrigger = false;
    private GameObject player;
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
        Debug.Log("get key");
        gameObject.SetActive(false);

        PlayerManager manager = PlayerManager.GetInstance();
        manager.yellowKeyNumber += 1;

        KeyYellowValue.instance.UpdateValue(manager.yellowKeyNumber);

        Debug.Log("yellow keys :" + manager.yellowKeyNumber);
        PlayerMove.instance.key = null;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.CompareTag("Player"))
    	{
    		InTrigger = true;
            player = collision.gameObject;
            PlayerMove.instance.key = this;
    	}
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            InTrigger = false;
            player = null;
            PlayerMove.instance.key = null;
        }
    }
}
