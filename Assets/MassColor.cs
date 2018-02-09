using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;

public class MassColor : MonoBehaviour {
    public Renderer result;
    public NVRSlider Slider;
    public Rigidbody rb;
    void Start () {
        rb = GetComponent<Rigidbody>();
        
	}
	
	// Update is called once per frame
	void Update () {
        this.rb.mass = Slider.CurrentValue * 10 + 0.5f;
        result.material.color = new Color(1 - Slider.CurrentValue, 1 - Slider.CurrentValue, 1 - Slider.CurrentValue, 1);
    }
}
