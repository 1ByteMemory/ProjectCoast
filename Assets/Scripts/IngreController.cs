﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngreController : MonoBehaviour {

    private Rigidbody rb;
    private Animator anim;

    public RuntimeAnimatorController[] animsList = new RuntimeAnimatorController[] { };

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        
        
        if (transform.position.y <= -10.0f)
        {
            
            rb.isKinematic = true;
<<<<<<< HEAD
            gameObject.transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(10, 20), 0);
=======
            gameObject.transform.position = new Vector3(Random.Range(-8.0f, 8.0f), Random.Range(10, 20), 0);
>>>>>>> c81e2dc78950846d15520b7609eda22c13df0e7a
            gameObject.transform.rotation = new Quaternion();
            
            
            var Index = Random.Range(0, animsList.Length);
            anim.runtimeAnimatorController = animsList[Index];
            
            rb.mass = Random.Range(0.1f, 2.0f);
<<<<<<< HEAD
            
        // allows it to move again.
=======
            
        // allows it to move again.
>>>>>>> c81e2dc78950846d15520b7609eda22c13df0e7a
        rb.isKinematic = false;
        }
        
    }

}
