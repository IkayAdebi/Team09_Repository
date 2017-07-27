using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // On mouse down
    private void OnMouseDown()
    {
        print("Wassup");
    }
}
