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
            enemyAnimator.SetBool("isDead", true);
            GameObject.Destroy(enemy);
        }
    }
}
