using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

public class Circle : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

        var linePoints = new List<Vector3>(100);
        VectorLine myLine = new VectorLine("Line", linePoints, 8.0f, LineType.Continuous, Joins.Fill);
        myLine.SetColor(Color.yellow);
        myLine.MakeCircle(new Vector3 (0,0,0), new Vector3(1, 0, 0), 0.5f,50);
        myLine.drawTransform = transform;
        myLine.Draw3DAuto();
    }
	
	// Update is called once per frame
	void Update () {

    }
}
