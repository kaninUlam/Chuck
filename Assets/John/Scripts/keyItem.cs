using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyItem : MonoBehaviour
{
    // destroys object on collision
    //audio
    public Audio aSource;
    public AudioClip keycollect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        //playaudio
        aSource.playAudio(keycollect);
    }
}
