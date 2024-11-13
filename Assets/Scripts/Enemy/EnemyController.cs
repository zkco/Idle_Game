using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Animator Animator;
    public float distanceToPlayer;

    private void Awake()
    {
        Animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        distanceToPlayer = CalcDistanceToPlayer();
    }

    private void Update()
    {
        if(distanceToPlayer < 5)
        {
            //BattleManager.Instance.StartBattle();
        }
    }

    public float CalcDistanceToPlayer()
    {
        float distance = Vector3.Distance(transform.position, GameManager.Instance.Character.transform.position);
        return distance;
    }
}