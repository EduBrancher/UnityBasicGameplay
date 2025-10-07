using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogFireCooldown;
    float dogFireTimer;

    void Start() {
        dogFireTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogFireTimer < 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogFireTimer = dogFireCooldown;
        }
        dogFireTimer -= Time.deltaTime;
    }
}
