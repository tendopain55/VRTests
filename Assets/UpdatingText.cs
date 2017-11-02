using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NewtonVR
{
    public class UpdatingText : MonoBehaviour
    {

        Text sliderinput;
        public NVRSlider Slider;
        void Start()
        {
            sliderinput = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
        
            string output = Slider.CurrentValue.ToString("0.00");
            sliderinput.text = output;

        }
    }
}
