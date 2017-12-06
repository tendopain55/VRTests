using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

public class EndCaps : MonoBehaviour {
    public Texture2D lineTex;
    public Texture2D frontTex;
    public Texture2D backTex;
    // Use this for initialization
    private void Awake()
    {
        VectorLine.SetEndCap("Arrow", EndCap.Both, 1.0f, lineTex, frontTex, backTex);
    }
}
