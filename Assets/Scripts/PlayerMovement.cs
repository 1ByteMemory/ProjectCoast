using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    // The speed of the Player
    public float speed = 1.0f;


    // Player Movement
    void Update ()
    { 
        transform.position += new Vector3(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
    }
}
