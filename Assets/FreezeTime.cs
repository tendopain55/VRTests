using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
public class FreezeTime : MonoBehaviour
{
    public const float slowTimeScale = 0.001f;
    public NVRHand hand;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        hand = GetComponent<NVRHand>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hand.Inputs[NVRButtons.ApplicationMenu].PressDown)
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = slowTimeScale;
            }
            else
            {
                Time.timeScale = 1;
               
            }
        }
    }
}
