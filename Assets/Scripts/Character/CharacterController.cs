using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody _rb;
    private Animator _animator;
    public float Speed = 4.0f;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        OnMove();
    }

    public void OnMove()
    {
        _rb.velocity = Vector3.forward * Speed;
        _animator.SetBool("isRunning", true);
    }

    public void OnAttack()
    {

    }

    public void OnDamaged()
    {
        
    }
}