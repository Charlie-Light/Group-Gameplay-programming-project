using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressFTextVisible : MonoBehaviour
{
    public GameObject textF;


    void Update()
    {
        if (UI_Manager.interactFText)
        {
            Debug.Log("true");
            textF.SetActive(true);
        }

        else if (!UI_Manager.interactFText)
        {
            textF.SetActive(false);
        }
    }
}
