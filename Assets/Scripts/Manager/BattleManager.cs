using System;
using System.Collections;
using UnityEngine;

public class BattleManager : Singleton<BattleManager>
{
    public Character Character;
    public Enemy Enemy;

    public void StartBattle()
    {
        StartCoroutine(CoBattle());
    }

    private IEnumerator CoBattle()
    {
        float gameSpeed = 0;
        Character.Controller.Animator.SetBool("isRunning", false);
        Character.Controller.isBattle = true;
        StartCoroutine(BattleLogic());
        while (Enemy.Controller.distanceToPlayer < 10 || Enemy != null || Character != null)
        {
            gameSpeed += Time.deltaTime;
            if (gameSpeed > 15) gameSpeed = 0;
            Character.Controller.Animator.SetFloat("AttackRate", gameSpeed);
            Enemy.Controller.Animator.SetFloat("AttackRate", gameSpeed);

            yield return null;
        }
        Character.Controller.isBattle = false;
        Character.Controller.Animator.SetBool("isRunning", true);
        StopCoroutine(CoBattle());
    }

    private IEnumerator BattleLogic()
    {
        while(Character.Controller.isBattle == true)
        {
            if (Character.Controller.Animator.GetCurrentAnimatorStateInfo(0).IsName("WAIT04_converted"))
            {
                Character.OnAttack();
                Enemy.Controller.Animator.SetBool("Damaged", true);
                yield return Character.Controller.Animator.GetCurrentAnimatorStateInfo(0).IsName("WAIT04_converted") == false;
                Enemy.Controller.Animator.SetBool("Damaged", false);
            }
            if (Enemy.Controller.Animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                Enemy.OnAttack();
                yield return Enemy.Controller.Animator.GetCurrentAnimatorStateInfo(0).IsName("Attack") == false;
            }
            yield return null;
        }
        StopCoroutine(BattleLogic());
    }
}