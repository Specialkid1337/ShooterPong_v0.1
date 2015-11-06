using UnityEngine;
using System.Collections;

public class BoxSpawner : MonoBehaviour
{

    public GameObject thing;



    // Use this for initialization
    void Start()
    {
        Debug.Log("Start");

    }

    void Awake ()
    {
        Debug.Log("Awake");
        thing.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        Debug.Log("Enable");
    }

    public void ClickMe()
    {
        Debug.Log("I have been clicked.");
        thing.gameObject.SetActive(true);
    }
}
