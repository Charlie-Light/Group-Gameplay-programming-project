using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateObjectmovement : MonoBehaviour
{
    public ObectMovementScript object_ref;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>() != null)
        {
            object_ref.is_active = true;
        }
    }
}
