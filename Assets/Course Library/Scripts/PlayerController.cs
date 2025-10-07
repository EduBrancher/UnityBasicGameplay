using System;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] float speed;
    [SerializeField] float xBound;
    [SerializeField] GameObject projectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        EventHub.AnimalCrossedBottom += AnimalCrossedBottom;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        if (transform.position.x > xBound) {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xBound) {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
    }

    void Update() {
        var spacebarPress = Input.GetKeyDown(KeyCode.Space);
        if (spacebarPress) {
            var go = Instantiate(projectile, transform.position, transform.rotation);
        }
    }

    void AnimalCrossedBottom() {
        Debug.Log("Game Over!");
    }
}
