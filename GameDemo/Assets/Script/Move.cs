using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float speed = 0.9f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onUpClick()
    {
        Debug.Log("up click");
        if (PlayerMove.instance != null)
        {
            Vector3 dy = new Vector3(0.0f, 1, 0.0f);
            PlayerMove.instance.transform.position += dy * speed;
        }
    }

    public void onDownClick()
    {
        Debug.Log("up click");
        if (PlayerMove.instance != null)
        {
            Vector3 dy = new Vector3(0.0f, -1, 0.0f);
            PlayerMove.instance.transform.position += dy * speed;
        }
    }

    public void onLeftClick()
    {
        Debug.Log("up click");
        if (PlayerMove.instance != null)
        {
            Vector3 dx = new Vector3(-1, 0.0f, 0.0f);
            PlayerMove.instance.transform.position += dx * speed;
        }
    }

    public void onRightClick()
    {
        Debug.Log("up click");
        if (PlayerMove.instance != null)
        {
            Vector3 dx = new Vector3(1, 0.0f, 0.0f);
            PlayerMove.instance.transform.position += dx * speed;
        }
    }
}
