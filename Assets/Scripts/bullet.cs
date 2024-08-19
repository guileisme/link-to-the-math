using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Range(1, 10)] // range da velocidade do projétil
    [SerializeField] private float speed = 10f; // velocidade do projétil

    [Range(1, 10)] // range do tempo que o projétil vai desaparecer
    [SerializeField] private float lifetime = 5f; // tempo de vida do projétil

    private Rigidbody2D rigidBody; // gravidade do projétil

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = transform.up * speed;
    }
}
