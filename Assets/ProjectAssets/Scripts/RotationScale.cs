using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScale : MonoBehaviour
{
    private int minScale = 1;
    private int maxScale = 5;
    private bool isScale = false;

    private void FixedUpdate()
    {
        transform.RotateAround(transform.position, Vector3.up, 70 * Time.deltaTime);

        if (transform.localScale.x >= maxScale - 1)
        {
            isScale = false;
        }

        if (transform.localScale.x <= minScale + 1)
        {
            isScale = true;
        }

        transform.localScale = Vector3.Lerp(
            transform.localScale,
            isScale 
                ? new Vector3(maxScale, maxScale, maxScale) 
                : new Vector3(minScale, minScale, minScale), 
            Time.deltaTime);
    }
}
