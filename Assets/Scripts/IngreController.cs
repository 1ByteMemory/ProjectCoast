using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngreController : MonoBehaviour {

    private Rigidbody rb;
    private SpriteRenderer sp;

    public Sprite[] ingredients = new Sprite[] { };

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        sp = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Checks if the ingredient is below -10 units.
        if (transform.position.y <= -10.0f)
        {
            // Stops it from moving, resetting it's velocity.
            rb.isKinematic = true;

            // Moves it to the top.
            gameObject.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(10, 20), 0);

            // Sets rotation to 0.
            gameObject.transform.rotation = new Quaternion();

            // Selects a random sprite from the ingredients list using the index.
            var spriteIndex = Random.Range(0, ingredients.Length);

            // Assigns selected sprite to be rendered.
            sp.sprite = ingredients[spriteIndex];

            // Randomly changes the mass to be between 0.1 and 2.
            rb.mass = Random.Range(0.1f, 2.0f);

            // allows it to move again.
            rb.isKinematic = false;
        }
    }

}
