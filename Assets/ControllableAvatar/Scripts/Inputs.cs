using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using RPGCharacterAnims.Lookups;
using RPGCharacterAnims.Actions;
using RPGCharacterAnims.Extensions;
using TMPro;



public class Inputs : MonoBehaviour
{
    public RPGCharacterAnims.RPGCharacterController rpgCharacterController;
    Controls controls;
    Rigidbody rigidbody;
    public static bool twoPointFiveDimens = false;
    //public LockOn lockOnCam;

    public Camera playerCamera;
    public int CameraSpeed = 100;
    public static Vector2 inputCamera;
    private bool CameraInput;


    public GameObject player;
    private Vector2 inputMovement;

    public static Vector3 moveInput;
    public static Vector3 moveInput2d;
    public static int movementSpeedMultiplier = 1;
    public Rigidbody rb;
    public float speed = 1;

    private bool isJumpHeld;

    public static bool speedBoosted = false;
    private float cooldownBoost = 5;
    private float boostTimer = 0;

    public static bool jumpBoosted = false;

    private int menuOption = 0;

    public static bool cutscene = false;
    public static bool cameraControlledStick = false;

    public static bool rightCamera = false;
    public static bool leftCamera = false;
    public static bool locked = false;

    public static int health = 50;

    private float timer = 0;

    enum GameState
    {
        MENU,
        GAMEPLAY
    }

    int currentGameState = 1;

    enum PlayerState
    {
        IDLE,
        ROLLING,
        ATTACKING,
        MOVING,
        JUMPING
    }

    int currentPlayerState = 0;

    private bool inputJump;
    private bool squareInteract;
    private bool diveRoll;
    private bool attackR;
    private bool attackL;
    private bool equip;
    private bool lockOn;

    public static bool inCutsceneTrigger = false;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        controls = new Controls();
        controls.Menu.DpadDown.performed += ctx => DownOption();
        controls.Menu.DpadUp.performed += ctx => UpOption();
    }

    private void Input()
    {
        try
        {
            inputJump = controls.Play.Jump.triggered;
            diveRoll = controls.Play.DiveRoll.triggered;
            squareInteract = controls.Play.SquareInteract.triggered;

            if (!twoPointFiveDimens)
            {
                attackR = controls.Play.AttackR.triggered;
                attackL = controls.Play.AttackL.triggered;
                equip = controls.Play.Equip.triggered;
                lockOn = controls.Play.ThumbstickIn.triggered;
            }
        }
        catch (System.Exception) { Debug.Log("Inputs not found!"); }
    }

    void Update()
    {
        if (cutscene)
        {
            controls.Disable();
        }
        BoostedSpeed();
        Input();
        Attack();
        Jumping();
        Roll();
        SquareInteract();
        MovementInput();
        isIdling();
        isMoving();

        if (!twoPointFiveDimens)
        {
            RotateLeft();
            RotateRight();
            hasCameraInput();
            LockOn();
            moveInput = new Vector3(inputMovement.x * movementSpeedMultiplier, inputMovement.y * movementSpeedMultiplier, 0f);
        }

        rpgCharacterController.SetMoveInput(moveInput);


        if (currentGameState == (int)GameState.GAMEPLAY)
        {
            controls.Menu.Disable();
            controls.Play.Enable();
        }
    }


    void BoostedSpeed()
    {
        if (speedBoosted)
        {
            boostTimer += Time.deltaTime;
            rpgCharacterController.animationSpeed = 1.5f;

            if (boostTimer >= cooldownBoost)
            {
                rpgCharacterController.animationSpeed = 1f;
            }
        }
    }


    void hasCameraInput()
    {
        if (inputCamera.x >= -0.7 && inputCamera.x <= 0.7)
        {
            leftCamera = false;
            rightCamera = false;
        }
    }


    void Jumping()
    {
        Vector3 jumpInput = isJumpHeld ? Vector3.up : Vector3.zero;
        rpgCharacterController.SetJumpInput(jumpInput);

        if (inputJump && rpgCharacterController.CanStartAction("Jump"))
        {
            rpgCharacterController.StartAction("Jump");
        }
        else if (inputJump && jumpBoosted && rpgCharacterController.CanStartAction("DoubleJump"))
        {
            rpgCharacterController.StartAction("DoubleJump");
            jumpBoosted = false;
        }
    }





    private void MovementInput()
    {
        if (currentGameState == (int)GameState.GAMEPLAY)
        {
            inputMovement = controls.Play.Move.ReadValue<Vector2>();
            inputCamera = controls.Play.Camera.ReadValue<Vector2>();
        }
    }


    void isIdling()
    {
        if (moveInput == Vector3.zero)
        {
            currentPlayerState = (int)PlayerState.IDLE;
        }
    }


    void isMoving()
    {
        if (moveInput != Vector3.zero)
        {
            currentPlayerState = (int)PlayerState.MOVING;
        }
    }


   
    void Attack()
    {
        if (attackR && rpgCharacterController.CanStartAction("Attack"))
        {
            //AttackFirstPhase.playerAttacking = true;
            //if (Attacked.phase2)
            //{
            //    AttackedCutSlime.playerAttacking = true;
            //}
            //Attacked.playerAttacking = true;
            rpgCharacterController.Attack(1, Side.Right, 0, 0, 0);
            currentPlayerState = (int)PlayerState.ATTACKING;
        }
        else if (attackL && rpgCharacterController.CanStartAction("Attack"))
        {
            //AttackFirstPhase.playerAttacking = true;
            //if (Attacked.phase2)
            //{
            //    AttackedCutSlime.playerAttacking = true;
            //}
            //Attacked.playerAttacking = true;
            rpgCharacterController.Attack(1, Side.Left, 0, 0, 0);
            currentPlayerState = (int)PlayerState.ATTACKING;
        }
    }


    void UpOption()
    {
        menuOption -= 1;

        if (menuOption < 0)
        {
            menuOption = 0;
        }
    }

    void DownOption()
    {
        menuOption += 1;

        if (menuOption > 1)
        {
            menuOption = 1;
        }
    }


    void RotateRight()
    {
        if (inputCamera.x > 0.7)
        {
            leftCamera = false;
            rightCamera = true;
        }
    }

    void RotateLeft()
    {
        if (inputCamera.x < -0.7)
        {
            rightCamera = false;
            leftCamera = true;
        }    
    }

    
    void LockOn()
    {
        if (lockOn)
        {
            //lockOnCam.lockedOn = true;
        }
    }


    void Roll()
    {
        if (diveRoll && rpgCharacterController.CanStartAction("DiveRoll"))
        {
            rpgCharacterController.StartAction("DiveRoll", 1);
            currentPlayerState = (int)PlayerState.ROLLING;
        }
    }


    void SquareInteract()
    {
        if (squareInteract && InChurchTriggerBox.inChurchBox)
        {
            Debug.Log("InBox");
            CutsceneCameraManager.playChurchCutscene = true;
        }
    }
}