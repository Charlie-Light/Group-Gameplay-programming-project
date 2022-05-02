using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    private Transform SpawnPoint;
    public GameObject PlatformType1;
    public float SpawnTimer;
    public float Timer;
    public static bool gateOpened = true;
    public bool loop;

    public void Start()
    {
        SpawnPoint = GetComponent<Transform>();
    }

    public void Update()
    {
        if (gateOpened)
        {
            Timer += Time.deltaTime;
            if (Timer > SpawnTimer)
            {
                Instantiate(PlatformType1, SpawnPoint.position, PlatformType1.transform.rotation);
                Timer = 0;
            }
        }
    }
}
