using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoxDamage_Script : MonoBehaviour
{
    public int damage = 5;
    public float onForInSecs = 0.75F;
    public float offForInSecs = 4.0F;
    float onCountdown = 0.0F;
    public float damageDelay = 0.25F;
    float damageCountdown = 0.0F;


    bool on = false;

    private void OnTriggerEnter(Collider other)
    {
        if (on)
        {
            damageDelay += Time.deltaTime;
            if (damageDelay < damageCountdown)
            {
                //Player.health -= damage;
                damageCountdown = 0.0F;
            }
        }
    }


    void Update()
    {
        if (offForInSecs > onCountdown && !on)
        {
            onCountdown += Time.deltaTime;
        }

        if (offForInSecs < onCountdown && !on)
        {
            on = true;
        }

        if (on == true)
        {
            onCountdown = 0.0F;
            if (onForInSecs > onCountdown)
            {
                onCountdown += Time.deltaTime;
            }
        }
    }
}
