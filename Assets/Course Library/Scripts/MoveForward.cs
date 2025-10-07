using UnityEngine;

public class MoveForward : MonoBehaviour {
    [SerializeField] float speed;
    [SerializeField] float zBound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        if (transform.position.z < -zBound ||
            transform.position.z > zBound) {
            Destroy(gameObject);
        }
    }
}
