using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    private BoxCollider coll;
    private SpriteRenderer sp;


	// Use this for initialization
	void Start () {
        coll = GetComponent<BoxCollider>();
        sp = GetComponentInParent<SpriteRenderer>();
	}

    private void OnTriggerEnter(Collider Player)
    {
        sp.enabled = !sp.enabled;
        coll.enabled = !coll.enabled;
    }
    
}
