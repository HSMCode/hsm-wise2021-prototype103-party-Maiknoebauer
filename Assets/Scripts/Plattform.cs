using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plattform : MonoBehaviour
{
    public float jumpForce = 12f;

    private float xScale;

    public ParticleSystem jumpParticle;
    
    private AudioSource jumpSound;

    private void Start()
    {
        jumpSound = GetComponent<AudioSource>();
    }

    
    
    
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
                jumpSound.Play();
                createParticle();
            }
        }
    }

    private void createParticle()
    {
        jumpParticle.Play();
    }
    
}
