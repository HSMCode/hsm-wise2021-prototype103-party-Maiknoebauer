using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plattform : MonoBehaviour
{
    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.relativeVelocity.y <= 0f)
        {
            Rigidbody2D _rb = other.gameObject.GetComponent<Rigidbody2D>();
            if (_rb != null)
            {
                Vector2 velocity = _rb.velocity;
                velocity.y = jumpForce;
                _rb.velocity = velocity;
            }
        }
    }
}
