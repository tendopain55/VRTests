using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
    public class VariableLight : MonoBehaviour
    {
        public NVRSlider Slider;
        public Light lt;
        void Start()
        {
            lt = GetComponent<Light>();
        }
        void Update()
        {

            lt.intensity = 2.0f * Slider.CurrentValue;
        }
    }
