using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_keys : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float rotateSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the player
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * moveSpeed, 0, Input.GetAxis("Vertical") * moveSpeed));
    }
}
