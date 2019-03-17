using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCapsule : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector3 WhereToSpawn;
    public float spawRate = 2f;
    float nextSpawn = 0.0f;

    private void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawRate;
            randX = Random.Range(-8.4f, 8.4f);
            WhereToSpawn = new Vector3(randX, transform.position.y);
            Instantiate(enemy, WhereToSpawn, Quaternion.identity);
            
        }
    }

}
