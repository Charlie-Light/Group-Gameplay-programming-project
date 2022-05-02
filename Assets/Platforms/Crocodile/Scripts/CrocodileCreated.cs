using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrocodileCreated : MonoBehaviour
{
    public float despawnTimer = 6;
    private float timer;
    public Vector3 velocity;
    private float bobbing = 0.0f;
    public float sinkSpeed = 5.0f;
    public float surfaceSpeed = 5.0f;
    private bool stoodOn;
    private bool returnToSurface;

    private float startYPos;



    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("On");
        startYPos = gameObject.transform.position.y;
        stoodOn = true;
    }


    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Not on");
        stoodOn = false;
        returnToSurface = true;
    }
       
   
    void Update()
    {
        if (stoodOn)
        {
            velocity.y -= sinkSpeed * Time.deltaTime;
            Debug.Log(velocity.y);
        }

        
        if (returnToSurface)
        {
            velocity.y += surfaceSpeed * Time.deltaTime;

            if (gameObject.transform.position.y >= startYPos)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x, startYPos, gameObject.transform.position.z);
                returnToSurface = false;
            }
        }
        

        gameObject.transform.position += (velocity * Time.deltaTime);
        Destroy(gameObject, despawnTimer);
        Debug.Log("Destroyed");
    }
}
