﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroid
    : MonoBehaviour
{
    public GameObject enemeyPrefab;

    public float spawnDistance = 15;

    float astroidRate = 5;
    float nextEnemy = 1;

    // Update is called once per frame
    void Update()
    {
        nextEnemy -= Time.deltaTime;
      if(nextEnemy <= 0)
        {
            nextEnemy = astroidRate;
            astroidRate *= 1f;

            Vector3 offset = Random.onUnitSphere;

            offset.z = 0;

            offset = offset.normalized * spawnDistance;

            Instantiate(enemeyPrefab, transform.position + offset, Quaternion.identity);
        }  
    }
}
