using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;
public class Circle : MonoBehaviour {
    public int segments=50;
    public float radius=0.5f;
    public float thickness=5.0f;
    public float offset = 0.0f;
    public Color linecolor = Color.red;
	// Use this for initialization
	void Start () {
        var linePoints = new List<Vector3>(segments*2);
        var myLine = new VectorLine("Line", linePoints, thickness, LineType.Discrete, Joins.Weld);
        myLine.drawTransform = transform;
        myLine.color = linecolor;
        myLine.MakeCircle(new Vector3(offset,0,0), new Vector3(1,0,0), radius, segments);
        myLine.Draw3DAuto();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
