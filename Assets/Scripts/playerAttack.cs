using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack1 : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            animator.SetBool("isAttacking", true);
            GetComponent<BoxCollider2D>().size = new Vector2(0.3f, 0.3f);
        }

        else
        {
            animator.SetBool("isAttacking", false);
            GetComponent<BoxCollider2D>().size = new Vector2(0.13f, 0.21f);
        }

    }
}
