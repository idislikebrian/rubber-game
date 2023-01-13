using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject cone, walkingLady, oldLady;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    void Start()
    {
        spawnCone();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnCone();
            timer = 0;
        }
    }

    private void spawnCone()
    {
        int random = Random.Range(1, 4);

        if (random == 1)
        {
            Instantiate(cone, new Vector3(transform.position.x, 1, 0), transform.rotation);
        }

        else if (random == 2)
        {
            Instantiate(walkingLady, new Vector3(transform.position.x, 1, 0), transform.rotation);
        }        
        
        else if (random == 3)
        {
            Instantiate(oldLady, new Vector3(transform.position.x, 1, 0), transform.rotation);
        }                
    }
} 