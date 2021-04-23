using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class rabbitWander : MonoBehaviour
{
    public int rabbitHealth = 14;
    public int rabbitHunger = 0;
    public int rabbitThirst = 0;
    public static Vector3 test;
    void Start()
    {
        InvokeRepeating("RandomNavSphere", 10f, 5); 
    }

    
    void Update()
    {
      //  Debug.Log(test);
    }



    public static Vector3 RandomNavSphere (Vector3 origin, float distance, int layermask) {

        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * distance;

        randomDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randomDirection, out navHit, distance, layermask);
        
        test = navHit.position;
        
        return navHit.position;

        
    }


    
}
