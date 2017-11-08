using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

namespace NewtonVR

{

    public class VariableCircle : MonoBehaviour

    {



        public NVRSlider Slider;

        public int segments = 50;

        public float radius;

        public float thickness = 5.0f;

        public float offset = 0.0f;

        void Start()

        {

            radius = Slider.CurrentValue;

            var linePoints = new List<Vector3>(segments * 2);

            var myLine = new VectorLine("Line", linePoints, thickness, LineType.Discrete, Joins.Weld);

            myLine.drawTransform = transform;

            myLine.color = Color.cyan;

            myLine.MakeCircle(new Vector3(offset, 0, 0), new Vector3(1, 0, 0), radius, segments);

            myLine.Draw3DAuto();

        }



        // Update is called once per frame

        void Update()

        {







        }

    }

}