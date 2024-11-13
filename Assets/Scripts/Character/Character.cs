using UnityEngine;

public class Character : MonoBehaviour, IEntity
{
    public CharacterCondition Condition;
    public CharacterController Controller;
    public Equipment Equipment;
    public int TotalStatus;
    public int Level;
    public int Gold = 0;
    public float AttackRate = 10f;

    private void Awake()
    {
        GameManager.Instance.Character = this;
        BattleManager.Instance.Character = this;
        Controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        TotalStatus = ItemManager.Instance.Equipment.AddStatus();
    }

    public void OnAttack()
    {
        BattleManager.Instance.Enemy.EnemyHealth.ReduceValue(TotalStatus);
    }

    public void OnDamaged()
    {

    }

    public void OnDeath()
    {
        Time.timeScale = 0;
    }
}