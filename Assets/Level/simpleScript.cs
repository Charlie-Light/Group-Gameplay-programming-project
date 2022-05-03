using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;
//D5 Additions
public class simpleScript : MonoBehaviour
{
    public PathCreator pathCreator;
    public EndOfPathInstruction end;
    public float speed;
    public float dstTravelled;
    private float timeTravelled;
    public GameObject platform;

    [SerializeField] private Vector3 middleCoordinate;
    [SerializeField] private int coordinateVariance;
    [SerializeField] private float destroyTime;
    private Vector3 blockCoords;
    public float randomNumber;
    public float timer = 0;
    public int spawnInterval;
    public StartSequenceTrigger startSequenceTrigger;
    public EndSequenceTrigger endSequenceTrigger;


    void Update()
    {
        timer += Time.deltaTime;
        
        if (startSequenceTrigger.hasTriggered && !endSequenceTrigger.hasTriggered)
        {
            
            if (timer >= spawnInterval)
            {
                StartCoroutine(SpawnBlocks());
                timer = 0;
            }
        }   
        
        
    }
    private IEnumerator SpawnBlocks()
    {
        
        randomNumber = Random.Range(-coordinateVariance, coordinateVariance);
        blockCoords = new Vector3(middleCoordinate.x, middleCoordinate.y, (middleCoordinate.z + randomNumber));
        Destroy(Instantiate(platform, blockCoords, new Quaternion(0, 0, 0, 0)), destroyTime);
        timeTravelled = Time.deltaTime;
        yield return new WaitForSeconds(0);
    }
}
