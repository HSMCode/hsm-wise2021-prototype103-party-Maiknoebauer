using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConttoller : MonoBehaviour
{

    public float moveSpeed = 0.1f;

    public Rigidbody2D _rb;

    private float _topScore = 0.0f;
    public Text scoreText;
    public Text gameOver;
    public Text finish;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

        FindObjectOfType<AudioManager>().Play("StartMusic");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
        Score();

        Finish();

        GameOver();
        
    }

    private void AudioPlay()
    {
        if (transform.position.y >= 1)
        {
            FindObjectOfType<AudioManager>().Play("Loop1");
        }
        
        if (transform.position.y >= 1)
        {
            FindObjectOfType<AudioManager>().Play("Loop2");
        }
        
        if (transform.position.y >= 1)
        {
            FindObjectOfType<AudioManager>().Play("Loop3");
        }
        
        if (transform.position.y >= 1)
        {
            FindObjectOfType<AudioManager>().Play("Loop4");
        }
        
        if (transform.position.y >= 1)
        {
            FindObjectOfType<AudioManager>().Play("Loop5");
        }
        
        if (transform.position.y >= 1)
        {
            FindObjectOfType<AudioManager>().Play("Loop6");
        }
        
        if (transform.position.y >= 1)
        {
            FindObjectOfType<AudioManager>().Play("Loop7");
        }
        
        if (transform.position.y >= 1)
        {
            FindObjectOfType<AudioManager>().Play("Loop8");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Respawn") )
        {
            Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);
        }
    }

    private void GameOver()
    {
        if (transform.position.x <= -3.5f || transform.position.x >= 3.15f)
        {
            Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);
        }
    }

    private void Finish()
    {
        if (transform.position.y >= 342)
        {
            Time.timeScale = 0;
            finish.gameObject.SetActive(true);
        }
    }

    private void Movement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(Vector3.down * 180);
        }  
    }

    private void Score()
    {
        if (_rb.velocity.y > 0 && transform.position.y > _topScore)
        {
            _topScore = transform.position.y;
        }

        scoreText.text = "Score :" + Mathf.Round(_topScore);
    }
    
    
}
