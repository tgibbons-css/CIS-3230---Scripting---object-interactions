using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 1.0f;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Gem Initialized in Start method");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Gem Update method with deltaTime= " + Time.deltaTime);
        //transform.Rotate(new Vector3(10, 0, 0) * rotateSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(10, 0, 0) * rotateSpeed);
    }
}
