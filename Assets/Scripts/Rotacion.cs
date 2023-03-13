using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float degreesPerSecond = 10;
    Vector3 pivote = new Vector3(0.0f, 0.0f, 0.0f);
    void Update()
    {
        //transform.Rotate(new Vector3(0, -degreesPerSecond, 0) * Time.deltaTime);
        transform.RotateAround(pivote, Vector3.up, degreesPerSecond * Time.deltaTime);
    }
}
