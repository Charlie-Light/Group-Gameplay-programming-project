using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSequenceTrigger : MonoBehaviour
{
    public bool hasTriggered;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            hasTriggered = true;

        }
    }
}
