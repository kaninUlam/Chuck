﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = new Vector3(0, 0, 0);
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float yoffset = Random.Range(-0.5f, 0.5f) * magnitude;
            float xoffset = Random.Range(-0.5f, 0.5f) * magnitude;

            transform.localPosition = new Vector3(xoffset, yoffset, originalPos.z);

            elapsedTime += Time.deltaTime;

            yield return null;
        }
        transform.localPosition = originalPos;  
    }
}
