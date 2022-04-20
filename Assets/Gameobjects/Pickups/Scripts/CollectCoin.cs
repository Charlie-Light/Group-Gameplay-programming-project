using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        ScoreScript.score += 10;
        Debug.Log(ScoreScript.score);
        Destroy(gameObject);
    }
}
