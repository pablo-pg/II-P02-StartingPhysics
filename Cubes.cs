using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public GameObject sphere;
    private float startDistance;
    // Start is called before the first frame update
    void Start()
    {
        startDistance = Vector3.Distance(gameObject.transform.position, sphere.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, sphere.transform.position);

        Collider collider = GetComponent<Collider>();
        Vector3 size = collider.bounds.size;

        Debug.Log("Tamaño"+size);

        Vector3 scaleChange = new Vector3(1, 1, 1);
        Vector3 maxSize = new Vector3(10,10,10);
        Vector3 minSize = new Vector3(0.1f,0.1f,0.1f); 
        
        if (size.x < maxSize.x && size.y < maxSize.y && size.z < maxSize.z)
            if (size.x > minSize.x && size.y > minSize.y && size.z > minSize.z)
                gameObject.transform.localScale = (startDistance - distance) * scaleChange + scaleChange;

        }
}
