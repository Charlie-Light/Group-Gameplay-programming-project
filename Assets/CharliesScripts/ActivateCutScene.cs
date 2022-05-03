using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCutScene : MonoBehaviour
{
    public cutsceneScript attachedScene;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerController>())
        {
            attachedScene.is_active = true;
            Destroy(this);
        }
    }
}
