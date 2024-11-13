using UnityEngine;

public class Character : MonoBehaviour, IEntity
{
    public CharacterCondition Condition;
    public CharacterController Controller;
    public Equipment Equipment;
    public int TotalStatus;
    public int Level;
    public int Gold = 0;

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

    }

    public void OnDamaged()
    {

    }

    public void OnDeath()
    {

    }
}