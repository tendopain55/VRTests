﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;
public class Circle : MonoBehaviour {
    public int segments=50;
    public float radius=0.5f;
    public float thickness=5.0f;
	// Use this for initialization
	void Start () {
        var linePoints = new List<Vector3>(segments*2);
        var myLine = new VectorLine("Line", linePoints, thickness, LineType.Continuous, Joins.Weld);
        myLine.color = Color.red;
        myLine.MakeCircle(new Vector3(0,0,0), new Vector3(1,0,0), radius, segments);
        myLine.Draw3DAuto();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
