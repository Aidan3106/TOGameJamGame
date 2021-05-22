using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobinStats : MonoBehaviour
{
    float maxHealthGobin = 40.0f;
    float currentHealthGobin;
    public float gobinDamageDeal = 0.0f;
    float gobinDefense = 1.0f;
    void Start()
    {
        currentHealthGobin = maxHealthGobin;
    }

    public void TakeDamageSkeleton(float damageTaken)
    {
        currentHealthGobin = currentHealthGobin - (damageTaken / gobinDefense);

        if (currentHealthGobin <= 0.0f)
        {
            GobinDie();
        }
    }

    void GobinDie()
    {
        //For when the Gobin Health hit zero.
    }
}
