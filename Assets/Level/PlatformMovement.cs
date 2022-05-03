using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class PlatformMovement : MonoBehaviour
{
    public PathCreator pathCreator;
    public EndOfPathInstruction end;
    public float speed;
    private float dstTravelled;

    // Update is called once per frame
    void Update()
    {
        dstTravelled += speed * Time.deltaTime;
        transform.position = new Vector3(pathCreator.path.GetPointAtDistance(dstTravelled, end).x, transform.position.y, transform.position.z);
        transform.rotation = Quaternion.Euler(0, (pathCreator.path.GetRotationAtDistance(dstTravelled, end).eulerAngles.y -90), 0);
   
    }
}
