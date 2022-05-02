using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{

    //input vars
    private float horizontal_axis = 0.0f; private float vertical_axis = 0.0f;
    private float attackL; private float attackR;
    private bool sprint = false;

    public bool camera_input_enabled = true; public bool player_input_vert_enabled = true; public bool player_input_horz_enabled = true; 

    //movement / attack vars
    public float speed_modifier = 10.0f; public float camera_speed_mod = 20.0f;
    public float dead_zone = 0.1f;
    public float attack_cooldown = 1.0f;
    private float current_attack_cooldown = 0.0f;
    public int current_attack = 0;
    private bool in_air = false;
    private float distance_to_ground;
    private int jump_count = 0; private float jump_timer;
    ParticleSystem power_up;
    public float camera_dist = 1.0f;
    private float attack_timer;


    public int health;
    public float damage_taken_delay;
    private bool invinisible;
    private float invinisbile_timer;

    //objects attached to character
    private Animator animation_handeler;
    private Rigidbody rb;
    public GameObject main_camera;
    private GameObject camera_holder;

    private CameraController player_cam_controller;
    //Refrences
    public List<GameObject> overlapping_go;
    public Collider left_fist;

    void Start()
    {
        camera_holder = GameObject.Find("CameraCentre");
        animation_handeler = GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();

        Physics.gravity = new Vector3(0, -20, 0);
        player_cam_controller = new CameraController();
        player_cam_controller.InitilizeCameraController(camera_speed_mod, dead_zone, main_camera, this, camera_dist);
        attack_timer = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (current_attack_cooldown > -4)
        {
            current_attack_cooldown -= Time.deltaTime;
        }
        updateVerticleMovement();
    }

    private void FixedUpdate()
    {
            update_movement();

            if (!in_air)
                attack();
            if (Input.GetButton("Interact"))
                interact();

        if (jump_timer <= 0)
        {
            if (Input.GetButton("Jump") && jump_count < 2)
            {
                jump_timer = 0.25f;
                Jump();
            }
            else if (IsGrounded())
            {
                jump_count = 0;
            }
        }
        else
        {
            jump_timer -= Time.deltaTime;
        }
    }

    private void LateUpdate()
    {
        if (camera_input_enabled)
        {
            player_cam_controller.LateUpdate();
        }

        if (attack_timer > 0)
        {
            foreach (GameObject x in overlapping_go)
            {
                if(x == null)
                {
                    overlapping_go.Remove(x);
                }
                {

                }
                if (left_fist.bounds.Intersects(x.GetComponent<Collider>().bounds))
                {
                    if (x.GetComponent<AI_Slime>() != null)
                    {
                        x.GetComponent<AI_Slime>().TakeDamage(1, 5, transform.forward);
                    }
                }
            }

            attack_timer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //add to refrence to manage overlapping gmae objects
        overlapping_go.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        overlapping_go.Remove(other.gameObject);
    }

    private void interact()
    {
        foreach(GameObject x in overlapping_go)
        {

        }
    }

    void Jump()
    {
        in_air = true;
        rb.AddForce(Vector2.up * 50, ForceMode.Impulse);
        animation_handeler.SetBool("Jump", true);
        animation_handeler.SetBool("InAir", false);
        jump_count += 1;
    }

    private void updateVerticleMovement()
    {

        if (IsGrounded() != true)
        {
            if (rb.velocity.y > 1)
            {
                animation_handeler.SetBool("Jump", true);
                if (animation_handeler.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Unarmed-Jump")
                {
                    animation_handeler.SetBool("InAir", true);
                }
            }
            else if (rb.velocity.y < -1)
            {
                animation_handeler.SetBool("Jump", false);
                animation_handeler.SetBool("Falling", true);
                animation_handeler.SetBool("InAir", true);
            }

        }
        else if (rb.velocity.y < 0.001 && rb.velocity.y > -0.001)
        {
            in_air = false;
            animation_handeler.SetBool("Jump", false);
            animation_handeler.SetBool("Falling", false);
            animation_handeler.SetBool("InAir", false);
        }
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, 1);
    }

    private void attack()
    {
        attackL = Input.GetAxis("AttackL");
        attackR = Input.GetAxis("AttackR");

        if(animation_handeler.GetCurrentAnimatorClipInfo(1)[0].clip.name == "Unarmed-Idle")
        {
            animation_handeler.SetLayerWeight(1, 0.6f);
        }
        else
        {
            animation_handeler.SetLayerWeight(1, 1f);
        }
     
        if (current_attack_cooldown <= 0 && attackL > 0.1)
        {
            animation_handeler.SetBool("AttackLeft", true);
            current_attack += 1;
            current_attack_cooldown = attack_cooldown;

            attack_timer = 0.5f;
        }
        else
        {
                animation_handeler.SetInteger("current_attack", current_attack);
                animation_handeler.SetBool("AttackLeft", false);
        }

        if(current_attack_cooldown < -1 || current_attack >= 4)
        {
            animation_handeler.SetInteger("current_attack", 0);
            current_attack = 0;
        }
    }

    private void update_movement()
    {
        horizontal_axis = Input.GetAxis("Horizontal");
        vertical_axis = Input.GetAxis("Vertical");
        float camera_hor_axis = Input.GetAxis("Camera_horizontal");

        sprint = Input.GetButton("Sprint");

        if ((Math.Abs(horizontal_axis) < dead_zone) || !player_input_horz_enabled )
            horizontal_axis = 0;
        if ((Math.Abs(vertical_axis) < dead_zone) || !player_input_vert_enabled)
            vertical_axis = 0;

        animation_handeler.SetFloat("Strafe", horizontal_axis);
        animation_handeler.SetFloat("Forward", vertical_axis);

        if (Math.Abs(horizontal_axis) > 0 || Math.Abs(vertical_axis) > 0)
        {
            if(sprint && IsGrounded() && vertical_axis > 0)
            {
                animation_handeler.SetBool("Sprint", true);
                vertical_axis = vertical_axis * 2;
            }
            else
            {
                animation_handeler.SetBool("Sprint", false);
            }
            transform.Translate(new Vector3(horizontal_axis, 0, vertical_axis) * speed_modifier * Time.deltaTime);
        }

        if (Math.Abs(rb.velocity.x) > 0 || Math.Abs(rb.velocity.z) > 0)
        {
            if (Math.Abs(camera_hor_axis) > dead_zone)
                transform.Rotate(new Vector3(0, camera_hor_axis, 0) * (camera_speed_mod) * Time.deltaTime);
            player_cam_controller.UpdateCameraMovementHorz(false);
        }
        else
        {
            player_cam_controller.UpdateCameraMovementHorz(true);
        }
    }

    public void PowerUp(float value, string type)
    {
        if (type == "speed")
        {
            StartCoroutine(powerUpSpeed(value));
        }
    }

    IEnumerator powerUpSpeed(float value)
    {
        animation_handeler.speed += (value / 10);
        speed_modifier += value;
        power_up.Play();

        yield return new WaitForSeconds(5);

        animation_handeler.speed -= (value / 10);
        speed_modifier -= value;
        power_up.Stop();
    }

    public void TakeDamage(int damage, float knockback, Vector3 attacker_forward)
    {
        //handle damage!
        if(!invinisible)
        {
            health -= damage;
            invinisible = true;
        }
        else
        {
            if(invinisbile_timer > 0)
            {
                invinisbile_timer -= Time.deltaTime;
            }
            else
            {
                invinisible = false;
                invinisbile_timer = damage_taken_delay;
            }
        }

    }
}

