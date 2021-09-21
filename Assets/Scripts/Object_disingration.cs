using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_disingration : MonoBehaviour
{
    public GameObject brokenVersion;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision_detection OnCollisionEnter with " + collision.gameObject + "colliding with" + gameObject.name);

        if (brokenVersion != null)
        {
            GameObject broke = Instantiate(brokenVersion, transform.position, transform.rotation);
        }

    }
}
