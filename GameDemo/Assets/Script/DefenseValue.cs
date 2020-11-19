﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MotaGame;
using UnityEngine.UI;

public class DefenseValue : MonoBehaviour
{
    private static object _lock = new object();
    private GameObject gameObj;

    public static DefenseValue instance;
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
        int value = PlayerManager.GetInstance().defenseValue;

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
