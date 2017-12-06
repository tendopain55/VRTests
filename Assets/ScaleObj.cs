using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
public class ScaleObj : MonoBehaviour {
    public NVRSlider Slider;
    public NVRSlider Slider2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3(1, Slider.CurrentValue * 3, Slider.CurrentValue * 3);
        //transform.localPosition = new Vector3((Slider2.CurrentValue*3 - 0.5f), 0, 0);
	}
}
