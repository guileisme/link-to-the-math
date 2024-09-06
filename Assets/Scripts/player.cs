using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject Player;
    public healthBar healthbar;
    public staminaBar staminabar;
    public BoxCollider2D boxCollider2D;
    public float damage;
    public float hitpoints;
    public float stamina;
    public npc npc1;
    public npc npc2;
    public dialogueManager dialogueManager;

    void Start()
    {
        hitpoints = 3f;
        damage = 5f;
        stamina = 5f;
        healthbar.setMaxHealth(hitpoints);
        healthbar.setHealth(hitpoints);
        staminabar.SetMaxStamina(stamina);
        staminabar.SetStamina(stamina);

    }
    void Update()
    {
        if (hitpoints == 0)
        {
            Player.SetActive(false);
        }

        if (npc1.interactionPopup.canTalk == true && Input.GetKeyDown(KeyCode.E))
        {
           npc1.dialogueTrigger.triggerDialogue();
        }

        if (npc2.interactionPopup.canTalk == true && Input.GetKeyDown(KeyCode.E))
        {
           npc2.dialogueTrigger.triggerDialogue();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            dialogueManager.endDialogue();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            dialogueManager.displayNextSentence();
        }

    }
}
