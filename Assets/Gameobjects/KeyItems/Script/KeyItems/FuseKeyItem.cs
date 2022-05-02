using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseKeyItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        KeyItemManager.FuseKeyItem = true;
        Destroy(this);
    }
}
