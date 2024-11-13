using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEntity
{
    public List<Item> DropTable;
    public Condition EnemyHealth;
    public EnemyController Controller;

    private void Start()
    {
        Controller = GetComponent<EnemyController>();
    }

    public void OnAttack()
    {
        GameManager.Instance.Character.Condition.Hp.ReduceValue(Random.Range(10,30));
    }

    public void OnDamaged()
    {
        EnemyHealth.ReduceValue(GameManager.Instance.Character.TotalStatus);
    }

    public void OnDeath()
    {
        GameManager.Instance.Character.Condition.AddGold(Random.Range(10, 500));
        Destroy(this.gameObject);
    }
}