using System.Threading;
//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
    [Header("Personaje")]
    [Tooltip("Velocidad del personaje")]
    public float velocity = 1.0f;
    [Header("Tipo de movimiento")]
    public bool wasd = true;
    public bool arrows = false;
    // Start is called before the first frame update
    void Start() {
        Renderer rend = GetComponent<Renderer>();
        rend.material = Resources.Load<Material>("blue");
    }

    // Update is called once per frame
    void Update() {
        Vector3 movementInput = Vector3.zero;

        if (wasd) {
            arrows = false;
            if (Input.GetKey("w")) {
                movementInput.z = 1;
            }
            if (Input.GetKey("s")) {
                movementInput.z = -1;
            }
            if (Input.GetKey("d")) {
                movementInput.x = 1;
            }
            if (Input.GetKey("a")) {
                movementInput.x = -1;
            }
        } else {
            wasd = false;
            if (Input.GetKey("up")) {
                movementInput.z = 1;
            }
            if (Input.GetKey("down")) {
                movementInput.z = -1;
            }
            if (Input.GetKey("right")) {
                movementInput.x = 1;
            }
            if (Input.GetKey("left")) {
                movementInput.x = -1;
            }
        }
        gameObject.transform.position += movementInput.normalized * velocity * Time.deltaTime;
    }
}
