using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUp ()
    {
        Debug.Log("PickUp");
        if (PlayerMove.instance.key != null)
        {
            PlayerMove.instance.key.PikcUp();
        }
        if (PlayerMove.instance.healing != null)
        {
            PlayerMove.instance.healing.PikcUp();
        }
        if (PlayerMove.instance.gemAttack != null)
        {
            PlayerMove.instance.gemAttack.PikcUp();
        }
        if (PlayerMove.instance.gemDefense != null)
        {
            PlayerMove.instance.gemDefense.PikcUp();
        }
    }

    public void OpenDoor()
    {
        Debug.Log("OpenDoor");
        if (PlayerMove.instance.door != null)
        {
            PlayerMove.instance.door.OpenDoor();
        }
    }

    public void Attack()
    {
        Debug.Log("Attack");
        if (PlayerMove.instance.monster != null)
        {
            PlayerMove.instance.monster.Attact();
        }
    }
}
