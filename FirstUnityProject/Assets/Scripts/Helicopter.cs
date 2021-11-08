using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    public float upForce = 100f;
    public float rotationForce = 100f;
    private Rigidbody rigidBody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() //60FPS
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddForce(transform.up * upForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddTorque(transform.right * rotationForce * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.AddTorque(-1 * transform.right * rotationForce * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddTorque(-transform.forward * rotationForce * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddTorque(transform.forward * rotationForce * Time.deltaTime);
        }
    }
}
