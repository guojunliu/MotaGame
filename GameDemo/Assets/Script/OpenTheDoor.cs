using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.O) && InTrigger)
        {
            // GameObject go = GameObject.Find("Player"); 
　　         PlayerMove playerScript = (PlayerMove) player.GetComponent(typeof(PlayerMove));
　　         int yellow_key_number = playerScript.yellowKeyNumber;
            if (yellow_key_number > 0) {
                Debug.Log("open yellow door");
                playerScript.yellowKeyNumber -= 1;
                gameObject.SetActive(false);
            }
            else {
                Debug.Log("Not enough yellow keys");
            }

            
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
            player = collision.gameObject;
        }
    }
}
