using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorGateOpen : MonoBehaviour
{
    private void Update()
    {
        if (KeyItemManager.FuseKeyItem)
        {
            this.gameObject.GetComponent<Animator>().SetBool("FuseKeyItemHeld", true);
        }
    }
}
