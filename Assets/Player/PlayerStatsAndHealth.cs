using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsAndHealth : MonoBehaviour
{
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

        if (currentHealthPlayer <= 0.0f)
        {
            PlayerDie();
        }
    }

    void PlayerDie()
    {
        //We a reset furtcion to restart the level or game over menu.
    }
}
