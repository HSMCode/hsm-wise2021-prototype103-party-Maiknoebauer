using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConttoller : MonoBehaviour
{

    public float moveSpeed = 10f;
    private float moveX;

    public Rigidbody2D _rb;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _rb.velocity;
        velocity.x = moveX;
        _rb.velocity = velocity;
    }
}
