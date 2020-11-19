using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceDown : MonoBehaviour
{
    public int floor;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerMove.instance != null)
        {
            if (PlayerMove.instance.currentFloor + 1 == floor)
            {
                PlayerMove.instance.transform.position = transform.position;
                PlayerMove.instance.currentFloor += 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
