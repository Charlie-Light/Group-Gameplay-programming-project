using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealElevatorTrigger : MonoBehaviour
{
    public Camera playercamera;
    public Camera sealElevatorCamera;
    public Camera bottomElevatorCamera;
    public Animator elevatorAnimator;
    float sequenceCountdown = 0.0F;
    bool elevatorDown = false;
    bool inElevator = false;

    private void OnTriggerEnter(Collider other)
    {
        inElevator = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inElevator = false;
    }

    private void Update()
    {
        if (!elevatorDown && inElevator && sequenceCountdown <= 0)
        {
            Inputs.cutscene = true;
            playercamera.enabled = false;
            sealElevatorCamera.enabled = true;
            elevatorAnimator.SetBool("inSealElevator", true);
            sequenceCountdown += Time.deltaTime;
          }

        if (!elevatorDown && sequenceCountdown > 0 && sequenceCountdown < 3)
        {
            sequenceCountdown += Time.deltaTime;
        }

        if (!elevatorDown && sequenceCountdown >= 3 && sequenceCountdown <= 8)
        {
            sequenceCountdown += Time.deltaTime;
            sealElevatorCamera.enabled = false;
            bottomElevatorCamera.enabled = true;
        }

        if (!elevatorDown && sequenceCountdown > 8)
        {
            sequenceCountdown = 0;
            elevatorDown = true;
            bottomElevatorCamera.enabled = false;
            //SplineCamera.enable = true;
        }
    }
}
