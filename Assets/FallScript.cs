using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = spawnPoint.position;
    }
}
