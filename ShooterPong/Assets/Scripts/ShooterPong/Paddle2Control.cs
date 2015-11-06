using UnityEngine;
using System.Collections;

public class Paddle2Control : MonoBehaviour
{

    public float speed = 20;
    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0, 1, 0) * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
