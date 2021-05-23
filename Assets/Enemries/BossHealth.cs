
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{

	public float health = 500.0f;

	public GameObject deathEffect;

	public bool isInvulnerable = false;

	public void TakeDamage(float damage)
	{
		if (isInvulnerable)
			return;

		health -= damage;

		//if (health <= 200)
		//{
		//	GetComponent<Animator>().SetBool("IsEnraged", true);
		//}

		if (health <= 0.0f)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}

