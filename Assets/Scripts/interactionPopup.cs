using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionPopup : MonoBehaviour
{
    public bool canTalk = false;
    public GameObject popup;
    private void OnTriggerEnter2D(Collider2D other) {
        popup.SetActive(true); 
        canTalk = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        popup.SetActive(false);
        canTalk = false;   
    }
}
