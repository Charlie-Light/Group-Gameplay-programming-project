using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecendingPlatformTrigger : MonoBehaviour
{
    public static bool decend = false;


    void Update()
    {
        if (decend)
        {
            DecendingPlatformTrigger.decend = true;
        }
    }
}
