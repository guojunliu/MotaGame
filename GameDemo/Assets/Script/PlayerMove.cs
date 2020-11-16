using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	float speed = 8.0f;

    public int yellowKeyNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        Vector3 dx = new Vector3(inputX, 0.0f, 0.0f);
        // Debug.Log("dx: " + dx);
        transform.position += dx *speed *Time.deltaTime;

        float inputY = Input.GetAxisRaw("Vertical");
        Vector3 dy = new Vector3(0.0f, inputY, 0.0f);
        // Debug.Log("dy: " + dy);
        transform.position += dy *speed *Time.deltaTime;

        // Debug.Log("Time.deltaTime: " + Time.deltaTime);
    }
}
