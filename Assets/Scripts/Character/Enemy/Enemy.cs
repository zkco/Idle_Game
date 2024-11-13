using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEntity
{
    public List<Item> DropTable;
    public List<GameObject> MonsterPrefabs;

    public void OnAttack()
    {
        throw new System.NotImplementedException();
    }

    public void OnDamaged()
    {
        throw new System.NotImplementedException();
    }

    public void OnDeath()
    {
        throw new System.NotImplementedException();
    }
}