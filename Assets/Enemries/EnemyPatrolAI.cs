using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolAI : MonoBehaviour
{
    public float walkSpeed, range, timeBTWShots, shootSpeed; // BTW means between
    private float DistToPlayer; //DistToPlayer means DistanceToPlayer

    [HideInInspector]
    public bool mustPatrol;
    private bool mustTurn, canShoot;

    public Rigidbody2D rb;
    public Transform GroundCheckPos;
    public LayerMask GroundLayer;
    public Transform player, shootPos;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mustPatrol)
        {
            Patrol();
        }

        DistToPlayer = Vector2.Distance(transform.position, player.position);

        if(DistToPlayer <= range)
        {
            if (player.position.x > transform.position.x && transform.localScale.x < 0 
                || player.position.x < transform.position.x && transform.localScale.x > 0)
            {
                Flip();
            }

            mustPatrol = false;
            rb.velocity = Vector2.zero;

            if (canShoot) 
            StartCoroutine(Shoot());
        }
        else
        {
            mustPatrol = true;
        }

    }

    private void FixedUpdate()
    {

        if (mustPatrol)
        {
            mustTurn = !Physics2D.OverlapCircle(GroundCheckPos.position, 0.1f, GroundLayer);
        }
    }

    void Patrol()
    {
        if (mustTurn)
        {
            Flip();
        }

        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void Flip()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }

    IEnumerator Shoot() //shoot projectiles
    {
        canShoot = false;

        yield return new WaitForSeconds(timeBTWShots);
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);

        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * walkSpeed * Time.fixedDeltaTime, 0f);

        canShoot = true;

    }
}
