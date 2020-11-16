using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MotaGame;

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
// 　　         PlayerMove playerScript = (PlayerMove) player.GetComponent(typeof(PlayerMove));
            PlayerManager manager = PlayerManager.GetInstance();
　　         int yellow_key_number = manager.yellowKeyNumber;
            if (yellow_key_number > 0) {
                Debug.Log("open yellow door");
                manager.yellowKeyNumber -= 1;
                gameObject.SetActive(false);
            }
            else {
                Debug.Log("Not enough yellow keys");
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
}
