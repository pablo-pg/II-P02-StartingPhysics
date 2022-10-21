using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.detectCollisions = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movementInput = Vector3.zero;

        if (Input.GetKey("i")) {
            movementInput.z = 1;
        }
        if (Input.GetKey("k")) {
            movementInput.z = -1;
        }
        if (Input.GetKey("l")) {
            movementInput.x = 1;
        }
        if (Input.GetKey("j")) {
            movementInput.x = -1;
        }
        gameObject.transform.position += movementInput.normalized * 4 * Time.deltaTime;
    }
}
