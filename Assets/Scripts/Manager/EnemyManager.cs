using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> EnemyPrefabs;
    public Vector3 EnemySpawnPosition;

    private void Start()
    {
        StartCoroutine(CoSpawnCheck());
    }

    private void SpawnMonster()
    {
        switch (MapManager.Instance.Stage)
        {
            case 0:
                Instantiate(EnemyPrefabs[0], MapManager.Instance.Party.position, Quaternion.FromToRotation(EnemySpawnPosition + new Vector3(0, 0, 3), EnemySpawnPosition));
                break;
            case 1:
                Instantiate(EnemyPrefabs[1], MapManager.Instance.Party.position, Quaternion.FromToRotation(EnemySpawnPosition + new Vector3(0, 0, 3), EnemySpawnPosition));
                break;
            case 2:
                Instantiate(EnemyPrefabs[2], MapManager.Instance.Party.position, Quaternion.FromToRotation(EnemySpawnPosition + new Vector3(0, 0, 3), EnemySpawnPosition));
                break;
        }
        
    }

    private IEnumerator CoSpawnCheck()
    {
        while (true)
        {
            EnemySpawnPosition = MapManager.Instance.Party.position;
            if (Mathf.Ceil(EnemySpawnPosition.z % 15) == 1)
            {
                SpawnMonster();
                yield return new WaitForSeconds(1);
            }
            yield return null;
        }
    }
}