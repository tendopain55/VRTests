using UnityEngine;
public class exampleCircle : MonoBehaviour
{

    public float RotateSpeed = 5f;
    public float Radius = 1.0f;

    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        _centre = transform.localPosition;
    }

    private void Update()
    {

        _angle += RotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        transform.position = _centre + offset;
    }



}