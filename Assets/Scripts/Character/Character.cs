using UnityEngine;

public class Character : MonoBehaviour, IAttackable
{
    public CharacterCondition Condition;
    public CharacterController Controller;
    private void Awake()
    {
        GameManager.Instance.Character = this;
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