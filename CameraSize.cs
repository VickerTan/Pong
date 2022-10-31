using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    public SpriteRenderer Arena;

    void Start()
    {
        float screenRatio = (float)Screen.width /(float)Screen.height;
        float targetRatio = Arena.bounds.size.x / Arena.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = Arena.bounds.size.y / 2;
        }
        else
        {
            float differenceInSize = targetRatio / screenRatio;
            Camera.main.orthographicSize = Arena.bounds.size.y / 2 * differenceInSize;
        }
    }
}
