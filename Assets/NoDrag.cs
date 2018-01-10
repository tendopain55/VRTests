using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDrag : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().angularDrag = 0;
        GetComponent<Rigidbody>().drag = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().angularDrag = 0;
        GetComponent<Rigidbody>().drag = 0;
    }
}
