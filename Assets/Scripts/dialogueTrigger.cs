using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger : MonoBehaviour
{
    public dialogue dialogue;

    public void triggerDialogue()
    {
        FindObjectOfType<dialogueManager>().startDialogue(dialogue);
    }
}
