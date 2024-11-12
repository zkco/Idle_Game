using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IAttackable
{
    public List<Item> DropTable;

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