using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> EnemyPrefabs;

    private void Update()
    {
        if (Mathf.Ceil(MapManager.Instance.Party.position.z % 30) == 1)
        {
            SpawnMonster();
        }
    }

    private void SpawnMonster()
    {
        switch (MapManager.Instance.ChunkLevel)
        {
            case 0:
                Instantiate(EnemyPrefabs[0], MapManager.Instance.Party.position, Quaternion.EulerRotation(0f, 180f, 0f));
                break;
            case 1:
                break;
            case 2:
                break;
        }
        
    }
}