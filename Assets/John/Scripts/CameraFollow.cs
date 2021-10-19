using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothspeed = 0.125f;

    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 EndPosition = target.position + offset;

        Vector3 SmoothFollow = Vector3.Lerp(transform.position, EndPosition, smoothspeed);

        transform.position = SmoothFollow;
    }
}
