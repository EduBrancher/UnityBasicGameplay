using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float rightLimit = 30;

    // Update is called once per frame
    void Update()
    {
        // Destroy if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy if x position is more than rightLimit
        else if (transform.position.x > rightLimit)
        {
            Destroy(gameObject);
        }

    }
}
