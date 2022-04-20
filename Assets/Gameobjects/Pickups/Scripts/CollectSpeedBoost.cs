using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectSpeedBoost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoreScript.score += 50;
        //Change in player script to allow for speed boost
        //Inputs.speedBoosted = true;
        Destroy(gameObject);
    }
}
