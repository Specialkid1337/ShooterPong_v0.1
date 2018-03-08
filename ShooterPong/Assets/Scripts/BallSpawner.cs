using UnityEngine;
using System.Collections;
using System;

public class BallSpawner : MonoBehaviour
{
    public GameObject Ball;
    public int direction;
    public float yposition1 = 0.0f;
    public float yposition2 = 0.0f;

    // Use this for initialization
    void Start ()
    {
        
    }

    void FireBall()
    {
        Instantiate(Ball, new Vector3(-12.5f, yposition1, 0.0f), Quaternion.identity);
        new WaitForSeconds(1);
    }

    // Update is called once per frame
    void Update ()
    {
        yposition1 = GameObject.FindGameObjectWithTag("Paddle1").transform.position.y;
        if (Input.GetKey("e"))
         {
            FireBall();
         }
    }
}
