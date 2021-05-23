using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonBossStats : MonoBehaviour
{
    float maxHealthSkeletonBoss = 500.0f;
    float currentHealthSkeletonBoss;
    public float skeletonBossDamageDeal = 50.0f;
    float skeletonBossDefense = 2.0f;
    void Start()
    {
        currentHealthSkeletonBoss = maxHealthSkeletonBoss;
    }

    public void TakeDamageSkeletonBoss(float damageTaken)
    {
        currentHealthSkeletonBoss = currentHealthSkeletonBoss - (damageTaken / skeletonBossDefense);

        if (currentHealthSkeletonBoss <= 0.0f)
        {
            SkeletonBossDie();
        }
    }

    void SkeletonBossDie()
    {
        //For when the Skeleton Health hit zero.
    }
}
