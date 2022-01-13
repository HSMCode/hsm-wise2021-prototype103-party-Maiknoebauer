using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    private bool isStarted = false;
    public Text startText;


    public GameObject plattformPrefab;

    public int plattformCount = 300;

    void Start()
    {
        PlatformSpawn();

        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GameStart();

        Restart();
        
    }

    private void GameStart()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isStarted == false)
        {
            isStarted = true;
            startText.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    private void Restart()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Menu");
        }
    }

    private void PlatformSpawn()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < plattformCount; i++)
        {
            if (spawnPosition.y <= 340)
            {
                spawnPosition.y += Random.Range(.4f, 2f);
                spawnPosition.x = Random.Range(-2.4f, 2.4f);
                Instantiate(plattformPrefab, spawnPosition, Quaternion.identity); 
            }
            
        }
    }
}
