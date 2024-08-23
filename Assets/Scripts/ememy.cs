using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ememy : MonoBehaviour
{
    public GameObject enemy;
    public Animator enemyAnimator;
    public BoxCollider2D boxCollider2D;
    public float enemyHitpoints;
    void Start()
    {
        enemyHitpoints = 10f;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        enemyHitpoints -= 2f;
    }

    void Update()
    {
        if (enemyHitpoints == 0)
        {
            Die();
        }
    }

    void Die ()
    {
            enemyAnimator.SetBool("isDead", true);
            this.enabled = false;
    }
}
