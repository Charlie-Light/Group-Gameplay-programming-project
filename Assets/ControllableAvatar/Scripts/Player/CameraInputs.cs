using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInputs : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        RotateRight();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void RotateRight()
    {
        transform.RotateAround(target.transform.position, Vector3.up, 10 * Time.deltaTime);
    }


    void RotateLeft()
    {
        transform.RotateAround(target.transform.position, Vector3.up, -10 * Time.deltaTime);
    }
}
