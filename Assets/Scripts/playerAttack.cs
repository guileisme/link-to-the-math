using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack1 : MonoBehaviour
{
    public player player;
    public bool isAttacking; 
    public BoxCollider2D boxCollider2D;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (player.stamina != 0f && Input.GetKeyUp(KeyCode.F))
        {
            isAttacking = true;
            animator.SetBool("isAttacking", true);
            GetComponent<BoxCollider2D>().size = new Vector2(0.3f, 0.3f);
            player.stamina -= 1f;
            player.staminabar.SetStamina(player.stamina);
        }

        else
        {
            isAttacking = false;
            animator.SetBool("isAttacking", false);
            GetComponent<BoxCollider2D>().size = new Vector2(0.13f, 0.21f);
        }

    }
}
