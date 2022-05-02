using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    public Transform target;
    public float smoothingSpeed = 0.1f;
    public Vector3 offset = new Vector3(1, 5, 5);

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothingSpeed);
        transform.position = smoothedPosition;
        //transform.rotation = target.rotation; 
    }
}
