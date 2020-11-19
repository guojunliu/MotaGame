using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	public float speed = 8.0f;

    

    public int currentFloor = 1;

    public GetKey key;
    public OpenTheDoor door;
    public Monster monster;
    public Healing healing;
    public GemAttack gemAttack;
    public GemDefense gemDefense;

    public static PlayerMove instance;
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
        transform.position = new Vector3(-2.5f, -5.5f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Input.GetMouseButtonDown(0);

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
