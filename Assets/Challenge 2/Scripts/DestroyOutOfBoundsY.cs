using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsY : MonoBehaviour
{
    private float topLimit = 30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy if y position more than top limit
        if (transform.position.y > topLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
