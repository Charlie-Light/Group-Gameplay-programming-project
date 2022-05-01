using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireVolumeManager : MonoBehaviour
{
    public GameObject fireVolume;
    float transparancy;


    private void Update()
    {        
        if (FireBoxDamage_Script.on)
        {
            fireVolume.GetComponent<MeshRenderer>().forceRenderingOff = true;
        }


        else
        {
            fireVolume.GetComponent<MeshRenderer>().forceRenderingOff = false;
        }
    }
}
