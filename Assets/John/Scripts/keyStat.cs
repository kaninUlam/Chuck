using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyStat : MonoBehaviour
{
    // set collider2d on item and tick is trigger in collider
    // name item as Key
    // sets a stats for if the player has a key or not
    public bool hasKey = false;

    public cameraShake CameraShake;

    // sets hasKey to true when player collides with object that is named Key
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Key"))
        {
            hasKey = true;
            StartCoroutine(CameraShake.Shake(.15f, .05f));
        }
    }
}
