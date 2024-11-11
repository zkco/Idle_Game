using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public ObjectPool ObjectPool;

    private void Awake()
    {
        if (ObjectPool == null)
        {
            ObjectPool = this.gameObject.GetOrAddComponent<ObjectPool>();
        }
    }
}
