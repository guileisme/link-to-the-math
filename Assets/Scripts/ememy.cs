using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ememy : MonoBehaviour
{
    public playerAttack1 player;
    public GameObject enemy;
    public Animator enemyAnimator;
    public BoxCollider2D boxCollider2D;
    public float enemyHitpoints;
    void Start()
    {
        enemyHitpoints = 10f;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (player.isAttacking == true)
        {
            enemyHitpoints -= 2f;
        }
    }

    void Update()
    {
        if (enemyHitpoints == 0)
        {
            Die();
            Disappear();
        }
    }

    void Die ()
    {
            enemyAnimator.SetBool("isDead", true);
    }

    void Disappear(){
            enemy.SetActive(false);

    }
}
