using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingPlatformTrigger : MonoBehaviour
{
    public static bool platformUp = false;

    void Update()
    {
        if (platformUp)
        {
            this.GetComponent<Animator>().SetBool("PlatformUp", true);
        }
    }
}
