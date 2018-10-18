using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private Rigidbody[] rb;

	// At the start of the level this block will run.
	void Start () {
        rb = GetComponentsInChildren<Rigidbody>();
        
        // Calls wait Function
        StartCoroutine("Wait");
    }
	
    // Wait function.
    IEnumerator Wait()
    {
        // Cycles through all the ingriedients to cascade them.
        for (int i = 0; i < rb.Length; i++)
        {
            // Enables Gravity for one ingreidient.
            rb[i].useGravity = true;
            yield return new WaitForSeconds(2);
        }

        
    }
}
