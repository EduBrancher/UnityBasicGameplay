using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    [SerializeField] float speed;
    [SerializeField] float zBound;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
        if (transform.position.z > zBound || 
            transform.position.z < -zBound) {
            Destroy(gameObject);
        }
        
    }

    void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }
}


