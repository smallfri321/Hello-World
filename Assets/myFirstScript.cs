using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class myFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("Hello world");
    }

    void Awake()
    {
        UnityEngine.Debug.Log("Hello World"); 
    }
}
