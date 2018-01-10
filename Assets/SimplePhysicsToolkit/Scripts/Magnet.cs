﻿using UnityEngine;
using System.Collections;
using NewtonVR;

/* Simple Physics Toolkit - Magnet
 * Description: Magnet applies force to any rigidbody within range,
 * 				this force is not applied differently based on distance (Future Feature).
 * Required Components: None
 * Author: Dylan Anthony Auty
 * Version: 1.1
 * Last Change: 2017-04-29
*/
public class Magnet : MonoBehaviour {
    //public NVRSlider magnetForceSlider;
    public float magnetForce = 15.0f;
	public bool enabled = true;
	public bool attract = true;
	public float innerRadius = 2.0f;
	public float outerRadius = 5.0f; 

	public bool onlyAffectInteractableItems = false;
	public bool realismMode = false;
	
	// Update is called once per frame
	void FixedUpdate () {
		if (enabled) {
			Collider[] objects = Physics.OverlapSphere (transform.position, outerRadius);
			foreach (Collider col in objects) {
				if (col.attachedRigidbody) { //Must be rigidbody
					if (onlyAffectInteractableItems) {
						if (col.attachedRigidbody.GetComponent<InteractableItem> ()) {
							attractOrRepel (col);
						}
					} else {
						attractOrRepel (col);
					}
				}
			}
		}	
	}

	void attractOrRepel(Collider col){
		if (Vector3.Distance (transform.position, col.transform.position) > innerRadius) {
			//Apply force in direction of magnet center
			if (attract) {
				if (realismMode) {
					float dynamicDistance = Mathf.Abs( (Vector3.Distance (transform.position, col.transform.position) ) - (outerRadius + (innerRadius * 2)) );
					float multiplier = dynamicDistance / outerRadius;

					col.attachedRigidbody.AddForce ( (magnetForce * (transform.position - col.transform.position).normalized) * multiplier, ForceMode.Force);
				} else {
					col.attachedRigidbody.AddForce (magnetForce * (transform.position - col.transform.position).normalized, ForceMode.Force);
				}
			} else {
				if (realismMode) {
					float dynamicDistance = Mathf.Abs( (Vector3.Distance (transform.position, col.transform.position) ) - (outerRadius + (innerRadius * 2)) );
					float multiplier = dynamicDistance / outerRadius;

					col.attachedRigidbody.AddForce (-( (magnetForce * (transform.position - col.transform.position).normalized) * multiplier), ForceMode.Force);
				} else {
					col.attachedRigidbody.AddForce (-magnetForce * (transform.position - col.transform.position).normalized, ForceMode.Force);
				}
			}
		} else {
			//Inner Radius float gentle - Future additional handling here
		}
	}
	
	void OnDrawGizmos(){
		if (enabled) {
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(transform.position, outerRadius);
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(transform.position, innerRadius);

			Gizmos.DrawIcon (transform.position, "sptk_magnet.png", true);
		}
	}
}
