using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // reference for objects
    GameObject player;
    keyStat key;
    //audio
    public Audio aSource;
    public AudioClip dooropen;
    // Start is called before the first frame update
    void Start()
    {
        // player finds the game object of the player. ** Replace string to Chuck **
        player = GameObject.Find("Chuck Standing");
        // gets the Component of the player that is the keystat script
        key = player.GetComponent<keyStat>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // checks if the object is the player ** replace string  to chuck **
        if (collision.gameObject.name.Contains("Chuck Standing"))
        {
            // checks if the player has the key
            if (key.hasKey == true)
            {
                Debug.Log("Door Open");
                transform.position = transform.position + new Vector3(0, 10, 0);
                //audio play
                aSource.playAudio(dooropen);
            }
            if (key.hasKey == false)
            {
                Debug.Log("Door still close");
            }
        }
       
    }
}
