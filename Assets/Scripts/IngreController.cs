using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngreController : MonoBehaviour {

    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Checks if the ingredient is below -10 units.
        if (transform.position.y <= -10.0f)
        {
            // Stops it from moving, resetting it's velocity.
            rb.isKinematic = true;

            // Moves it to the top.
            gameObject.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), 10, 0.9f);

            // Sets rotation to 0.
            gameObject.transform.rotation = new Quaternion();

            // allows it to move again.
            rb.isKinematic = false;
        }
    }

}
