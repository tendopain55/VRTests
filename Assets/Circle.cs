using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

public class Circle : MonoBehaviour
    {
    
    public int segments = 50;
    public float radius = 0.5f;
    public float thickness = 5.0f;
    public float offset = 0.0f;
    public Color linecolor = Color.red;
    public bool perpLinesIO;
    public Color perpcolor = Color.green;
    private VectorLine myLine;
    public int numberPerpLines = 1;
    public bool EndCapIO;
    // Use this for initialization
    void Start()
    {
        var linePoints = new List<Vector3>(segments * 2);
        myLine = new VectorLine("Line", linePoints, thickness, LineType.Discrete, Joins.Weld);
        myLine.drawTransform = transform;
        myLine.color = linecolor;
        Vector3 adjpos = new Vector3(offset, 0, 0);
        myLine.MakeCircle(new Vector3(offset, 0, 0), new Vector3(1, 0, 0), radius, segments);
        myLine.Draw3DAuto();
        if(perpLinesIO == true)
        {
            
            for (int i = 0; i < numberPerpLines; i++)
            {
                perpLines(adjpos, i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void perpLines(Vector3 pos, int currLine)
    {
        var linePoints = new List<Vector3>(new Vector3[]{this.transform.InverseTransformPoint(myLine.GetPoint3D01((float)currLine/(float)numberPerpLines)), pos});
        VectorLine perpL = new VectorLine("Perpendicular Lines", linePoints, thickness, LineType.Discrete, Joins.Weld);
        perpL.drawTransform = transform;
        perpL.color = perpcolor;
        if (EndCapIO)
        {
            perpL.endCap = "Arrow";
        }
        perpL.Draw3DAuto();

    }
}

