using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePedastalPlace_Script : MonoBehaviour
{
    public static bool blueKeyItemHeld;
    public GameObject blueKeyItem;
    public Transform bluePlacementTransform;

    bool inTrigger = false;

    private void OnTriggerStay(Collider other)
    {
        inTrigger = true;
        /*
        if (blueKeyItemHeld && Player.place)
        {
            Instantiate(blueKeyItem, bluePlacementTransform.position, bluePlacementTransform.rotation);
            blueKeyItemHeld = false;
            SealOpen_Script.bluePlaced = true;
        }*/
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
}
