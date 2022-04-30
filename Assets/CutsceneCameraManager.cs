using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneCameraManager : MonoBehaviour
{
    public Camera churchCutsceneCamera;
    public static bool playChurchCutscene = false;
    public Animator ChurchAnimator;

    float cutsceneDurationCountdown = 0;


    private void Update()
    {
        if (playChurchCutscene)
        {
            Debug.Log("PlayingChurchCutscene");
            churchCutsceneCamera.gameObject.SetActive(true);
            churchCutsceneCamera.enabled = true;
            ChurchAnimator.SetBool("PressSwitch", true);
            Inputs.cutscene = true;
            cutsceneDurationCountdown += Time.deltaTime;

            if (cutsceneDurationCountdown == 3)
            {
                Inputs.cutscene = false;
                churchCutsceneCamera.gameObject.SetActive(false);
                churchCutsceneCamera.enabled = false;
                playChurchCutscene = false;
            }
        }

        else
        {
            cutsceneDurationCountdown = 0;
        }
    }


   
}
