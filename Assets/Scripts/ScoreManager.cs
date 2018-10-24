using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    
    private SpriteRenderer sp;
    private bool collected = false;
    public Text TextScore;
    public int IntScore;


	// Use this for initialization
	void Start ()
    {
        sp = GetComponent<SpriteRenderer>();
	}

    private void OnCollisionEnter(Collision Player)
    {
        if ((Player.gameObject.tag == "Player") && !collected)
        {
            sp.sortingLayerName = "Behind";
            collected = true;
            IntScore += 100;
            TextScore.text = IntScore.ToString();
        }
        
    }



    private void Update()
    {
        if (transform.position.y <= -9.0f)
        {
            collected = false;
            sp.sortingLayerName = "Default";
        }
    }
}

