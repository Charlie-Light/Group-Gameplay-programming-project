using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Slime : MonoBehaviour
{
    public int damage;
    public float jump_strength;
    public int health;
    public float detection_range;
    public float jump_delay;
    public float knockback;
    public float damage_cooldown;
    public int div_count;
    public int split_count;

    private bool can_melee_attack;
    private float jump_timer;
    private float distance;
    private bool found_player;
    private bool can_range_attack;
    private bool jump_ready;
    private bool can_be_attacked;
    private float damage_timer;
    private ParticleSystem smoke;
    private bool dead = false;
    private Renderer Renderer;

    private Rigidbody rb;

    public GameObject player_character;

    // Start is called before the first frame update
    void Start()
    {
        distance = 100.0f;
        found_player = false;
        can_range_attack = true;
        jump_ready = true;
        rb = GetComponent<Rigidbody>();

        jump_strength = jump_strength * 10;
        jump_timer = jump_delay;
        can_melee_attack = false;
        smoke = gameObject.transform.Find("Smoke").GetComponent<ParticleSystem>();
        Renderer = gameObject.transform.Find("Slime_Body").gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        found_player = CheckDetection();
    }

    private void LateUpdate()
    {
        distance = getDistance();

        if (found_player)
        {
            if (can_range_attack)
            {
                //check range attack (not implemetned yet)
            }

            if (!can_be_attacked)
            {
                if (damage_timer > 0)
                {
                    damage_timer -= Time.deltaTime;
                }
                else
                {
                    can_be_attacked = true;
                    damage_timer = damage_cooldown;
                    Renderer.material.color = Color.green;
                }
            }

            if (can_melee_attack)
            {
                MeleeAttack();
            }

            if(jump_ready)
            {
                //If slime can jump, jump!
                MoveTowardsPlayer();
            }
            else
            {
                //if slime cannot jump(has recently)
                if(rb.velocity.y < 0.1)
                {
                    //if y velocity is 0 (on ground) activate delay timer
                    jump_timer -= Time.deltaTime;
                    if(jump_timer < 0)
                    {
                        //once timer is below 0 allow next jump, and reset timer
                        jump_ready = true;
                        jump_timer = jump_delay;
                    }
                }
            }
        }
    }

    private void MeleeAttack()
    {
        if (player_character.GetComponent<PlayerController>() != null)
        {
            PlayerController player_ref = player_character.GetComponent<PlayerController>();
            player_ref.TakeDamage(damage, knockback, transform.forward);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //has overlapped player attack with melee
        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            can_melee_attack = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            can_melee_attack = false;
        }
    }

    private void MoveTowardsPlayer()
    {
        jump_ready = false;

        transform.LookAt(player_character.transform);

        Vector3 slime_rotation = transform.eulerAngles;
        slime_rotation.z = 0;
        slime_rotation.x = 0;
        transform.eulerAngles = slime_rotation;

        Vector3 jump_dir;
        jump_dir = transform.forward * jump_strength;
        jump_dir.y = jump_strength / 2;
        rb.AddForce(jump_dir);
    }

    private bool CheckDetection()
    {
        if(distance < detection_range)
        {
            return true;
        }
        return false;
    }

    private float getDistance()
    {
        return Vector3.Distance(transform.position, player_character.transform.position);
    }


    bool spawn_clone = true;
    public void TakeDamage(int damage, float knockback, Vector3 attacker_forward)
    {
        //handle damage!
        if (can_be_attacked)
        {
            health -= damage;

            Vector3 knockback_dir;
            knockback_dir = attacker_forward * (knockback * 100);
            knockback_dir.y = knockback * 10;

            rb.AddForce(knockback_dir);
            can_be_attacked = false;
            Renderer.material.color = Color.red;

            if (health <= 0)
            {
                Vector3 spawn_position = transform.position;
                spawn_position.y += 1.0f;
                if (div_count > 0)
                {
                    for (int i = split_count; i > 0; --i)
                    {
                        var new_enemy = Instantiate(transform, new Vector3(0.0f, 0.0f, 0.0f), transform.rotation);
                        AI_Slime slime_ref = new_enemy.GetComponent<AI_Slime>();
                        slime_ref.jump_strength = 50;
                        new_enemy.position = spawn_position;
                        slime_ref.spawn_clone = false;
                        new_enemy.transform.localScale = transform.localScale / 2;
                        slime_ref.health = 2;
                        slime_ref.div_count = div_count - 1;
                    }
                }


                if(!dead)
                    StartCoroutine(death());
            }
        }
    }

    IEnumerator death()
    {
        smoke.transform.parent = null;
        dead = true;
        transform.position = new Vector3(0.0f, -1110.0f, 0.0f);
        smoke.Play();

        yield return new WaitForSeconds(1);

        Destroy(gameObject);
    }
}
