using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    float playerAttack1 = 50.0f;
    float playerAttack2 = 150.0f;
    public LayerMask enemyLayers;
    int numAttacks = 0;
    float attackSpeed = 1.0f;
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            numAttacks++;
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                numAttacks++;
                //if (Input.GetKeyDown(KeyCode.Mouse0))
                //{
                    //Attack(numAttacks);
                    //numAttacks++;
                    
                //}
                Attack(numAttacks);
                numAttacks = 0;
            }
            Attack(numAttacks);
            numAttacks = 0;
        }
    }

    void Attack(int numAttacks_)
    {
        int i = numAttacks_;
        if (i > 0)
        {
            animator.SetTrigger("Attack1");
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<BossHealth>().BossTakeDamage(playerAttack1);
            }
        }
        else if (i > 1)
        {
            animator.SetTrigger("Attack2");
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<BossHealth>().BossTakeDamage(playerAttack2);
            }
            //}
            //else if (i > 2)
            //{
            //    animator.SetTrigger("Attack3");
            //    Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
            //}
        }
    }

}
