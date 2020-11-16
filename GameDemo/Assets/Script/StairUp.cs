using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StairUp : MonoBehaviour
{
    public bool canTrigger = true;     // 是否可以触发
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
    	if(collision.gameObject.CompareTag("Player") && canTrigger)
    	{
            player = collision.gameObject;

            //DontDestroyOnLoad(player);
            //Application.LoadLevelAdditive ("SecondFloor");
            canTrigger = false;
            //SceneManager.LoadScene("SecondFloor", LoadSceneMode.Additive);

            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene("floor_" + (PlayerMove.instance.currentFloor + 1));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            canTrigger = true;
            player = collision.gameObject;
        }
    }
}
