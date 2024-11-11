using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator _animator;
    private CharacterController _controller;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }


}