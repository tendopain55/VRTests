using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

public class StraightArrows : MonoBehaviour {
    public float length = 1.0f;
    public Color linecolor = Color.red;
    private VectorLine myLine;
    public float thickness = 5.0f;
    public float offsetX = 0.0f;
    public float offsetY = 0.0f;
    public float offsetZ = 0.0f;



    // Use this for initialization
    void Start () {
        var linePoints = new List<Vector3>(){ new Vector3(offsetX/10,offsetY + length,0 + offsetZ/10), new Vector3(offsetX/10,offsetY,offsetZ/10)};
        myLine = new VectorLine("Line", linePoints, thickness, LineType.Discrete, Joins.Weld);
        myLine.drawTransform = transform;
        myLine.color = linecolor;
        myLine.endCap = "Arrow";
        myLine.Draw3DAuto();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
