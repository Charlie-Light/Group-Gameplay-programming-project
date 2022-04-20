using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDoubleJump : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ScoreScript.score += 25;
        //change to player script to allow for double jumps 
        //Inputs.jumpBoosted = true;
        Destroy(gameObject);
    }
}
