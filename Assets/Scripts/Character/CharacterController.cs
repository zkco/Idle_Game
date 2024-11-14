using System;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Rigidbody _rb;
    public Animator Animator;
    public float Speed = 4.0f;
    public float StartBattleDistance = 3;
    public bool isBattle = false;

    private void Awake()
    {
        Animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(isBattle == false) OnMove();
    }

    public void OnMove()
    {
        _rb.velocity = Vector3.forward * Speed;
        Animator.SetBool("isRunning", true);
    }
}