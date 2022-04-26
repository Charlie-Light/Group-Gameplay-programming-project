using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealOpen_Script : MonoBehaviour
{
    public static bool bluePlaced = false;
    public static bool redPlaced = false;
    public Material redMaterial;
    public Material blueMaterial;



    private void Update()
    {
        if (redPlaced && bluePlaced)
        {
            Destroy(this);
        }

        if (bluePlaced)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = redMaterial;
        }

        if (redPlaced)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = blueMaterial;
        }   
    }
}
