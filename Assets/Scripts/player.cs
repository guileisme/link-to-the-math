using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;   
using TMPro;

public class player : MonoBehaviour
{
    public TextMeshProUGUI lifepoints;
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
        hitpoints = 10f;
        damage = 5f;
        stamina = 10f;
        lifepoints.SetText("1");
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
            lifepoints.SetText("0");

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
