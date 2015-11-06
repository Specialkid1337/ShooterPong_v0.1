using UnityEngine;
using System.Collections;

public class PaddleControl : MonoBehaviour {

    public float speed = 20;
	// Use this for initialization
	void Start ()
    {

        

    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0, 1, 0) * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
