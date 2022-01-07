using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConttoller : MonoBehaviour
{

    public float moveSpeed = 0.1f;

    public Rigidbody2D _rb;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(Vector3.down * 180);
        }
    }

    
}
