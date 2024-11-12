using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody _rb;
    private Animator _animator;
    public float Speed = 4.0f;
    public float StartBattleDistance = 3;
    public bool Battle;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if(Battle == false) OnMove();
    }

    public void OnMove()
    {
        _rb.velocity = Vector3.forward * Speed;
        _animator.SetBool("isRunning", true);
    }


}