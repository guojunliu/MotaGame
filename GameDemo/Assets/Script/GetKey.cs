using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // Debug.Log("Update");
        if (Input.GetKeyDown(KeyCode.G) && InTrigger)
        {
            Debug.Log("get key");
            // GameObject.Destroy();
            gameObject.SetActive(false);
            PlayerMove script = (PlayerMove) player.GetComponent(typeof(PlayerMove));
            script.yellowKeyNumber += 1;
            Debug.Log("yellow keys :" + script.yellowKeyNumber);
        }
        // if (Input.GetKeyDown(KeyCode.E) && InDoor)
        // {
        //     Debug.Log("open eeee");
        // }
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
            player = null;
        }
    }
}
