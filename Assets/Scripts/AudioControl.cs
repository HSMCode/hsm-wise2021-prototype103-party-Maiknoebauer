using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource source1;
    
    public AudioSource source2;
    
    public AudioSource source3;
    
    public AudioSource source4;
    
    public AudioSource source5;
    
    public AudioSource source6;
    
    public AudioSource source7;
    

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y <= 12.84f || player.transform.position.y >= -5)
        {
            source1.Play();
        }
        
        if (player.transform.position.y <= 27.26f || player.transform.position.y >= 12.85)
        {
            source2.Play();
        }
        
        if (player.transform.position.y <= 44 || player.transform.position.y >= 27.26f)
        {
            source3.Play();
        }
        
        if (player.transform.position.y <= 60.3f || player.transform.position.y >= 44)
        {
            source4.Play();
        }
        
        if (player.transform.position.y <= 75.8f || player.transform.position.y >= 60.3f)
        {
            source5.Play();
        }
        
        if (player.transform.position.y <= 93 || player.transform.position.y >= 75.8f)
        {
            source6.Play();
        }
        
        if (player.transform.position.y <= 106.5f || player.transform.position.y >= 93)
        {
            source7.Play();
        }
        
    }
}
