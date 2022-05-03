using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurderScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(target);
        Destroy(this);
    }
}
