//using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilindros : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Cube") {
            Vector3 scaleChange = new Vector3(0.1f, 0.1f, 0.1f);
            gameObject.transform.localScale += scaleChange;
        }
    }
}
