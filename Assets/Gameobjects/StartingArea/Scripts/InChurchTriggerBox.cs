using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InChurchTriggerBox : MonoBehaviour
{
    public static bool inChurchBox = false;
    public static bool switchPressedIn = false;

    private void OnTriggerStay(Collider other)
    {
        if (!switchPressedIn)
        {
            UI_Manager.interactFText = true;
            inChurchBox = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        UI_Manager.interactFText = false;
        inChurchBox = false;
    }
}
