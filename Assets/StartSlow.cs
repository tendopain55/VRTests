using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSlow : MonoBehaviour {
    public float timeScale  = 0.5f;
	// Use this for initialization
	void Start () {
        Time.timeScale = this.timeScale;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
