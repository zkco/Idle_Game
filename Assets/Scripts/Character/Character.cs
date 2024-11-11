using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public abstract string Name { get; }
    public abstract string Description { get; }

    public AttackData attackData;

    public abstract void Attack(AttackData attackData);
}