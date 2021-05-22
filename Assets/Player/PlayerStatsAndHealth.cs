using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsAndHealth : MonoBehaviour
{
    public Animator animator;
    float maxHealthPlayer = 100.0f;
    float currentHealthPlayer;
    public float playerdamageDeal = 0.0f;
    float playerDefense = 2.0f;
    void Start()
    {
        currentHealthPlayer = maxHealthPlayer;
    }

    public void TakeDamagePlayer(float damageTaken)
    {
        currentHealthPlayer = currentHealthPlayer - (damageTaken/playerDefense);
        animator.SetTrigger("Hurt");
        if (currentHealthPlayer <= 0.0f)
        {
            PlayerDie();
        }
    }

    void PlayerDie()
    {
        animator.SetBool("IsDead", true);
        //We a reset furtcion to restart the level or game over menu.
    }
}
