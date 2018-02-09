using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NewtonVR
{
    public class UpdatingText : MonoBehaviour
    {
        public bool gravity;
        Text sliderinput;
        public NVRSlider Slider;
        private string output;
        void Start()
        {
            sliderinput = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            if (gravity)
            {
                output = "Gravity:\n" +(2*Slider.CurrentValue * 9.81).ToString("0.00") + " N/kg";
            }
            else
            {
                output = Slider.CurrentValue.ToString("0.00");
            }
            sliderinput.text = output;

        }
    }
}
