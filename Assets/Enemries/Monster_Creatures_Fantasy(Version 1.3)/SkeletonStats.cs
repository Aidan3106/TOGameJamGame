using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonStats : MonoBehaviour
{
    float maxHealthSkeleton = 40.0f;
    float currentHealthSkeleton;
    public float skeletonDamageDeal = 0.0f;
    float skeletonDefense = 1.0f;
    void Start()
    {
        currentHealthSkeleton = maxHealthSkeleton;
    }

    public void TakeDamageSkeleton(float damageTaken)
    {
        currentHealthSkeleton = currentHealthSkeleton - (damageTaken / skeletonDefense);

        if (currentHealthSkeleton <= 0.0f)
        {
            SkeletonDie();
        }
    }

    void SkeletonDie()
    {
        //For when the Skeleton Health hit zero.
    }
}
