using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkingPlatform : MonoBehaviour
{
    public int sinkSpeed;
    private bool sinking = false;
    
    // Update is called once per frame

    private void Update()
    {
        if(sinking)
        {
            transform.parent.position -= new Vector3(0, sinkSpeed * Time.deltaTime, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            sinking = true;
            
        }
    }
       
}
