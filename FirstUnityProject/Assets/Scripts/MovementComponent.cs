using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  MovementComponent: MonoBehaviour
{
    public float movementSpeed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //frame başlangıcı
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        //movementSpeed = 3
        
        //(0, 0, 1) * movementSpeed = (0, 0, 3)
        //(0, 0, movementSpeed) = (0, 0, 3)
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(movementSpeed * Time.deltaTime, 0, 0));
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-movementSpeed * Time.deltaTime, 0, 0));
        }
        //frame bitişi
    }
}
