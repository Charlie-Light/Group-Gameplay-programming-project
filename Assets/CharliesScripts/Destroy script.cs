using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyscript : MonoBehaviour
{
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(target);
        Destroy(this);
    }
}
