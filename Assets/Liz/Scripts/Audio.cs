using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField]
    public AudioClip happysteps;
    public AudioClip death;
    public AudioClip keycollect;
    public AudioClip dooropen;
    public AudioClip jump;

    private AudioSource source;

    private float volLow = 0.5f;
    private float volHigh = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float vol = Random.Range(volLow, volHigh);
            source.PlayOneShot(jump, vol);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            source.PlayOneShot(happysteps);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            source.PlayOneShot(happysteps);
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            source.Stop();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            source.Stop();
        }
    }

    public void playAudio(AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
}
