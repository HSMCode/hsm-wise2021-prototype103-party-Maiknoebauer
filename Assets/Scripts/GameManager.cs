using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject plattformPrefab;

    public int plattformCount = 300;
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < plattformCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-2.4f, 2.4f);
            Instantiate(plattformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
