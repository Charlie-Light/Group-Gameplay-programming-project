using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemManager : MonoBehaviour
{
    public static bool KeyItemsPickedup = false;

    public static bool SphereKeyItem = false;
    public static bool FuseKeyItem = false;
    public static bool CapsuleKeyItem = false;



    private void Update()
    {
        if (SphereKeyItem && FuseKeyItem && CapsuleKeyItem)
        {
            KeyItemsPickedup = true;
        }
    }
}
