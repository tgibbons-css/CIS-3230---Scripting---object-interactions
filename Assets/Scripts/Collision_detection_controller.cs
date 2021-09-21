using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_detection_controller : MonoBehaviour
{
    private int collectionScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("--- Collision_detection initialized in Start method in " + gameObject.name);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("--- Collision_detection Update method");
    }

    // FixedUpdate is called at regular time intervals
    void FixedUpdate()
    {
        // Debug.Log("--- Collision_detection FixedUpdate method");
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision_detection OnCollisionEnter with " + collision.gameObject + "colliding with" + gameObject.name);
        if (collision.gameObject.tag == "Collectible")
        {
            collectionScore++;
            Debug.Log("Collecting item, Score = " + collectionScore);
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision_detection OnTriggerEnter with " + other.gameObject + "triggered by" + gameObject.name);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name != "Floor")
        {
            Debug.Log("Collision_detection OnControllerColliderHit with " + hit.gameObject + "colliding with" + gameObject.name);
        }
    }
}
