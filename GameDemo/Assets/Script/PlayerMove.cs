using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        Vector3 dx = new Vector3(inputX, 0.0f, 0.0f);
        transform.position += dx *speed *Time.deltaTime;

        float inputY = Input.GetAxisRaw("Vertical");
        Vector3 dy = new Vector3(0.0f, inputY, 0.0f);
        transform.position += dy *speed *Time.deltaTime;
    }
}
