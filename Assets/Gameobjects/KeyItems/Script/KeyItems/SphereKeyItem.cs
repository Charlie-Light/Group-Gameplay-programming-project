using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereKeyItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        KeyItemManager.SphereKeyItem = true;
        RisingPlatformTrigger.platformUp = true;
        Destroy(this);
    }
}
