using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneCameraManager : MonoBehaviour
{
    public Camera playerCam;
    public static bool attack = false;
    private bool attacked = false;
    public Camera churchCutsceneCamera;
    public static bool playChurchCutscene = false;
    public Animator ChurchSwitchAnimator;
    public Animator ChurchDoorAnimator;

    float cutsceneDurationCountdown = 0;


    private void Update()
    {
        if (playChurchCutscene)
        {
            if (!attacked)
            {
                if (!attack)
                {
                    attack = true;
                }
                attacked = true;
            }
            Inputs.attackR = false;
            InChurchTriggerBox.switchPressedIn = true;
            churchCutsceneCamera.gameObject.SetActive(true);
            ChurchSwitchAnimator.SetBool("Switch", true);
            ChurchDoorAnimator.SetBool("SwitchPressed", true);
            Inputs.cutscene = true;
            churchCutsceneCamera.enabled = true;
            cutsceneDurationCountdown += Time.deltaTime;

            if (cutsceneDurationCountdown >= 3)
            {
                Inputs.cutscene = false;
                churchCutsceneCamera.gameObject.SetActive(false);
                churchCutsceneCamera.enabled = false;
                playerCam.enabled = true;
                playChurchCutscene = false;
            }
        }

        else
        {
            cutsceneDurationCountdown = 0;
        }
    }


   
}
