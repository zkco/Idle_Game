using UnityEngine;

public class Character : MonoBehaviour, IEntity
{
    public CharacterCondition Condition;
    public CharacterController Controller;
    public Equipment Equipment;
    public int TotalStatus;
    public int Level;
    public int Gold;

    private void Awake()
    {
        GameManager.Instance.Character = this;
        Controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        TotalStatus = ItemManager.Instance.Equipment.AddStatus();
    }
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