using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MotaGame;

public class LifeValue : MonoBehaviour
{
    //private static LifeValue instance;
    private static object _lock = new object();
    private GameObject gameObj;

    public static LifeValue instance;
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
        int lifeValue = PlayerManager.GetInstance().lifeValue;

        this.UpdateLiftValue(lifeValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLiftValue (int value)
    {
        Debug.Log("UpdateLiftValue : " + value);
        Text text = gameObj.GetComponent<Text>();
        Debug.Log("UpdateLiftValue text : " + text);
        text.text = value.ToString();
    }
}
