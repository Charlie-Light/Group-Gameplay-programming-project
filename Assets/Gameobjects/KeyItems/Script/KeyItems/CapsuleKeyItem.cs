using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleKeyItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        KeyItemManager.CapsuleKeyItem = true;
    }
}
