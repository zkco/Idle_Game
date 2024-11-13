using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Character Character;

    private void Awake()
    {
        Character = FindObjectOfType<Character>();
    }
}