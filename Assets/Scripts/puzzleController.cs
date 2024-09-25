using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzleController : MonoBehaviour
{
    public blocoOperacao blocoOperacao;
    public BoxCollider2D puzzleCollider;
    public doorController doorController;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == blocoOperacao.nome)
        {
            doorController.blocosFileira[blocoOperacao.index] = 1;
        }

        // else
        // {
        //     doorController.blocosFileira1[0] = 2;
        // }
    }
}
