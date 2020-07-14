﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker[] attackerPrefabArray;
    bool spawn = true;
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }


    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spwan(attackerPrefabArray[attackerIndex]);
    }
    private void Spwan(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate
            (myAttacker, transform.position, transform.rotation)
            as Attacker;
        newAttacker.transform.parent = transform;
    }
}
