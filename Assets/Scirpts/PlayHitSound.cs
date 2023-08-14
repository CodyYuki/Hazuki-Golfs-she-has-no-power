using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHitSound : MonoBehaviour
{

    static public bool PlayHit = false;
    public AudioSource soundPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayHit == true)
        {
            soundPlayer.Play();
            PlayHit = false;
        }
    }
}
