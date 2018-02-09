using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class GravityControl : MonoBehaviour {
    public NVRSlider Slider;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Physics.gravity = new Vector3(0,-9.81f * 2 * Slider.CurrentValue,0);
	}
}
