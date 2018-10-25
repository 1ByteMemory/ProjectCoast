<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    public Text tTime;
    public float iTime = 300;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        iTime -= 1 * Time.deltaTime;
        tTime.text = Mathf.Round(iTime).ToString();
	}

    
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    public Text tTime;
    public float iTime = 300;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        iTime -= 1 * Time.deltaTime;
        tTime.text = Mathf.Round(iTime).ToString();
	}

    
}
>>>>>>> c81e2dc78950846d15520b7609eda22c13df0e7a
