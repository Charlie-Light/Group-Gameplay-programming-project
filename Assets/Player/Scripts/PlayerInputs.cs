using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using RPGCharacterAnims.Lookups;
using RPGCharacterAnims.Actions;
using RPGCharacterAnims.Extensions;
using TMPro;
using System.Linq;
using UnityEngine.InputSystem.Controls;

public class PlayerInputs : MonoBehaviour
{
    public RPGCharacterAnims.RPGCharacterController rpgCharacterController;
    Controls controls;
    public GameObject player;

    bool cutsceneplaying = false;
    private Vector2 inputMovement;
    public static Vector3 moveInput;
    public static int movementSpeedMultiplier = 1;
    private bool isJumpHeld;

    //Pickups
    //bool jumpBoosted = false;
    //bool attackBoosted = false;
    //bool speedBoosted = false;


    enum PlayerState
    {
        IDLE,
        ROLLING,
        ATTACKING,
        MOVING,
        JUMPING,
        INTERACTING
    }

    //int current_playerstate = 0;

    private bool inputJump;
    private bool diveRoll;
    private bool attackR;
    private bool attackL;
    private bool equip;
    private bool resetCamera;


    void Start()
    {
        //rpgCharacterController = gameObject.GetComponent<RPGCharacterAnims.RPGCharacterController>();
        controls = new Controls();
    }


    void Inputs()
    {
        try
        {
            inputJump = controls.Play.Jump.triggered;
            diveRoll = controls.Play.DiveRoll.triggered;
            attackL = controls.Play.AttackL.triggered;
            attackR = controls.Play.AttackR.triggered;
            equip = controls.Play.Equip.triggered;
        }
        catch (System.Exception) { Debug.Log("Inputs not found!"); }
    }

    // Update is called once per frame
    void Update()
    {
        if (cutsceneplaying)
        {
            controls.Disable();
        }
        Inputs();
        Jumping();
        DiveRolling();
        Attacking();
        inputMovement = controls.Play.Move.ReadValue<Vector2>();
        //inputCamera = controls.Gameplay.Move.ReadValue<Vector2>();
        moveInput = new Vector3(inputMovement.x * movementSpeedMultiplier, inputMovement.y * movementSpeedMultiplier, 0F);
        rpgCharacterController.SetMoveInput(moveInput);
    }


    void Jumping()
    {
        Vector3 jumpInput = isJumpHeld ? Vector3.up : Vector3.zero;
        rpgCharacterController.SetJumpInput(jumpInput);

        if (inputJump && rpgCharacterController.CanStartAction("Jump"))
        {
            rpgCharacterController.StartAction("Jump");
        }
        else if (inputJump && rpgCharacterController.CanStartAction("DoubleJump"))
        {
            rpgCharacterController.StartAction("DoubleJump");
        }
    }


    void DiveRolling()
    {
        if (diveRoll && rpgCharacterController.CanStartAction("DiveRoll"))
        {
            rpgCharacterController.StartAction("DiveRoll", 1);
        }
    }


    void Attacking()
    {
        if (attackL && rpgCharacterController.CanStartAction("Attack"))
        {
            Debug.Log("Attacking!");
            rpgCharacterController.Attack(2, Side.Left, 0, 0, 1);
        }    
    }
}
