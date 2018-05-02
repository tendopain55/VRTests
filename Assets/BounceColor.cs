using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceColor : MonoBehaviour {
    Material m;
    PhysicMaterial p;
	// Use this for initialization
	void Start () {
        m = GetComponent<Material>();
        Color c = GetComponent<Color>();
        c.a *= p.bounciness;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
