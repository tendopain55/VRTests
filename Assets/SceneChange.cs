using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NewtonVR;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    public NVRButton Button;
    public string Scene;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Button.ButtonDown)
        {
            SceneManager.LoadScene(Scene);
        }
	}
}
