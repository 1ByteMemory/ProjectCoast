using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

<<<<<<< HEAD
    public int score;
    
    private float time = 2;
    private int level = 5;

    public Rigidbody itemPrefab;
    public Transform spawn;

    private void Start()
    {
        score = GetComponent<ScoreManager>().IntScore;

    }


    private void Update()
    {

=======
    public int score;
    
    private float time = 2;
    private int level = 5;

    public Rigidbody itemPrefab;
    public Transform spawn;

    private void Start()
    {
        score = GetComponent<ScoreManager>().IntScore;

    }


    private void Update()
    {

>>>>>>> c81e2dc78950846d15520b7609eda22c13df0e7a
    }
}
