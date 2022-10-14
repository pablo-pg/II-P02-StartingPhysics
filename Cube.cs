using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Rigidbody rb = GetComponent<Rigidbody>();
        Debug.Log(rb);
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter(Collision other) {
        Debug.Log("Colision hecha");
    }

    
}
