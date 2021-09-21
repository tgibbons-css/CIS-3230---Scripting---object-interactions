using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  See https://learn.unity.com/tutorial/using-c-to-launch-projectiles#5fd7ab3bedbc2a7fb11f4e41
public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fire1 is generally the mouse click and left-ctrl
        // See Edit->Project Settings->Input
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("--- Fire1 button pressed ");
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation);
            //ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
            ball.GetComponent<Rigidbody>().AddRelativeForce(transform.forward * launchVelocity);

            // set a timer to destroy the bullet after 10 seconds
            // https://docs.unity3d.com/ScriptReference/Object.Destroy.html
            Destroy(ball, 10);
        }
    }
}
