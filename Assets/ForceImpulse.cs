using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceImpulse : MonoBehaviour {
    private float force;
    public Text text;
    public Text leaderboard;
    private float first;
    private float second;
    private float third;
	// Use this for initialization
	void Start () {
        force = 0.0f;
        first = 0.0f;
        second = 0.0f;
        third = 0.0f;
        text.text = force.ToString("0") + " N";
    }
	
	// Update is called once per frame
	void Update () {
        if (force != 0)
        {
            text.text = force.ToString("0") + " N";
        }
        
        leaderboard.text = "High Score\n1.   " + first.ToString("0") + " N" + "\n" + "2.   " + second.ToString("0") + " N" + "\n" + "3.   " + third.ToString("0") + " N";

        if (force > 10000)
        {
            text.text += "!";
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        force = collision.impulse.magnitude / Time.deltaTime;
        //attempt to give weird 0 force collisions a believable magnitude
        //Will cause the part that causes 0 impact collisions to not display to do nothing
        /*if (collision.impulse.magnitude == 0)
        {
            force = collision.relativeVelocity.magnitude;
        }*/
        if (force != 0)
        {
            Debug.Log("Force: " + force + " N");
        }
        //updates the force highscore based on current force
        if (force > third)
        {
            if (force > second)
            {
                if (force > first)
                {
                    third = second;
                    second = first;
                    first = force;
                }
                else
                {
                    third = second;
                    second = force;
                }
            }
            else
            {
                third = force;
            }
        }
    }

}
