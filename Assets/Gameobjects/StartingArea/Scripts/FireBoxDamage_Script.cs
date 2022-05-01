using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoxDamage_Script : MonoBehaviour
{
    public int damage = 5;
    public float offForInSecs = 2.0F;
    public float onForInSecs = 5.0F;
    float onCountdown = 0.0F;
    public float damageDelay = 0.25F;
    float damageCountdown = 0.0F;


    public static bool on = false;

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
        if (on)
        {
            onCountdown += Time.deltaTime;
            if (onCountdown > onForInSecs)
            {
                on = false;
                onCountdown = 0;
            }
        }

        if (!on)
        {
            onCountdown += Time.deltaTime;
            if (onCountdown > offForInSecs)
            {
                on = true;
                onCountdown = 0;
            }
        }
    }
}
