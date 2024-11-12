using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float distanceToPlayer;
    private void FixedUpdate()
    {
        distanceToPlayer = CalcDistanceToPlayer();
    }
    private void Update()
    {
        StartBattle();
    }
    public float CalcDistanceToPlayer()
    {
        float distance = Vector3.Distance(transform.position, GameManager.Instance.Character.transform.position);
        return distance;
    }
    public void StartBattle()
    {
        if(distanceToPlayer < 5)
        {
            GameManager.Instance.Character.Controller.Battle = true;
        }
    }
}