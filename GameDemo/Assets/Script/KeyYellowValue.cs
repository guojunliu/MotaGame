using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MotaGame;

public class KeyYellowValue : MonoBehaviour
{
    //private static LifeValue instance;
    private static object _lock = new object();
    private GameObject gameObj;

    public static KeyYellowValue instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        gameObj = gameObject;
        int value = PlayerManager.GetInstance().yellowKeyNumber;

        this.UpdateValue(value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateValue (int value)
    {
        Text text = gameObj.GetComponent<Text>();
        text.text = value.ToString();
    }
}
