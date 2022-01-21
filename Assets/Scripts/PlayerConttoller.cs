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
    
    private AudioSource gameSound;
    public AudioClip gameOverSound;
    public AudioClip gameWinSound;

    private bool isGameOver = false;
    private bool isWon = false;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    private void Start()
    {
        gameSound = GetComponent<AudioSource>();
        gameSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        Score();

        Finish();

        GameOver();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Respawn") && isGameOver == false )
        {
            isGameOver = true;
            Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);
            gameSound.Stop();
            gameSound.PlayOneShot(gameOverSound);
        }
    }

    private void GameOver()
    {
        if (transform.position.x <= -3.5f || transform.position.x >= 3.15f && isGameOver == false)
        {
            isGameOver = true;
            Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);
            gameSound.Stop();
            gameSound.PlayOneShot(gameOverSound);
        }
    }

    private void Finish()
    {
        if (transform.position.y >= 342 && isWon == false)
        {
            isWon = true;
            Time.timeScale = 0;
            finish.gameObject.SetActive(true);
            gameSound.Stop();
            gameSound.PlayOneShot(gameWinSound);
        }
    }

    private void Movement()
    {
       if (transform.position.y >= 80)
        {
            moveSpeed = 2f + (transform.position.y / 100); 
        }
       else
        {
            moveSpeed = 2f;
        }
        
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
