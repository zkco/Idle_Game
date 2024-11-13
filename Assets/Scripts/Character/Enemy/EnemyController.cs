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
        if(distanceToPlayer < 5)
        {

        }
    }
    public float CalcDistanceToPlayer()
    {
        float distance = Vector3.Distance(transform.position, GameManager.Instance.Character.transform.position);
        return distance;
    }
}