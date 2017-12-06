using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NewtonVR.Example
{
    public class CompassTangent : MonoBehaviour
    {
        public Transform centerPoint;
        public NVRSwitch Switch;
        public Transform Casing;
        private float onoff;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //OLD, would only update once
            /* Vector3 realCenter = centerPoint.position;
             realCenter.y = this.transform.position.y;
             Vector3 heading = realCenter - this.transform.position;
             transform.eulerAngles = heading;*/

            //Attempts to lock x,y rotation of center so that it locks rotation of object
            Vector3 target = new Vector3(centerPoint.position.x, this.transform.position.y, centerPoint.position.z);
            /* Vector3 target = centerPoint.position;
             target.x = this.transform.position.x;
             target.z = this.transform.position.z;*/
            if (Switch.CurrentState == true)
            {
                onoff = 90;
            }
            else
            {
                onoff = -90;
            }
                //WORKING
            this.transform.LookAt(target, -Casing.forward);
            this.transform.Rotate(0, onoff, 0);


            //Attempts to lock x and y rotation after
            /*Vector3 tempAngles = this.transform.eulerAngles;
            tempAngles.x = 0.0f;
            tempAngles.z = 0.0f;
            transform.eulerAngles = tempAngles;*/
            // transform.eulerAngles.x = 0;
            //transform.eulerAngles.y = 0;

        }
    }
}
