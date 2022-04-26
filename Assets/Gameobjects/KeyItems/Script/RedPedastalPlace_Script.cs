using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPedastalPlace_Script : MonoBehaviour
{
    public static bool redKeyItemHeld;
    public GameObject redKeyItem;
    public Transform redPlacementTransform;

    bool inTrigger = false;

    private void OnTriggerStay(Collider other)
    {
        inTrigger = true;
        /*
        if (redKeyItemHeld && Player.place)
        {
            Instantiate(redKeyItem, redPlacementTransform.position, redPlacementTransform.rotation);
            redKeyItemHeld = false;
            SealOpen_Script.redPlaced = true;
        }*/
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
}
