using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    // The speed of the Player
    public float speed = 1.0f;


    // Player Movement
    void Update () {

        if ((Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > -8.4f)
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }

        if ((Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < 8.4f)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
}
