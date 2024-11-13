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
        GameObject obj = new GameObject();
        switch (MapManager.Instance.Stage)
        {
            case 0:
                obj = Instantiate(EnemyPrefabs[0], EnemySpawnPosition + new Vector3(0, 0, 10), Quaternion.FromToRotation(EnemySpawnPosition + new Vector3(0, 0, 10), EnemySpawnPosition));
                break;
            case 1:
                obj = Instantiate(EnemyPrefabs[1], EnemySpawnPosition + new Vector3(0, 0, 10), Quaternion.FromToRotation(EnemySpawnPosition + new Vector3(0, 0, 10), EnemySpawnPosition));
                break;
            case 2:
                obj = Instantiate(EnemyPrefabs[2], EnemySpawnPosition + new Vector3(0, 0, 10), Quaternion.FromToRotation(EnemySpawnPosition + new Vector3(0, 0, 10), EnemySpawnPosition));
                break;
        }
        BattleManager.Instance.Enemy = obj.AddComponent<Enemy>();
        obj.AddComponent<EnemyController>();
    }

    private IEnumerator CoSpawnCheck()
    {
        while (true)
        {
            EnemySpawnPosition = MapManager.Instance.Party.position;
            if (Mathf.Ceil(EnemySpawnPosition.z % 30) == 1)
            {
                SpawnMonster();
                yield return new WaitForSeconds(1);
            }
            yield return null;
        }
    }
}