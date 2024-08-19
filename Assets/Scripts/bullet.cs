using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [Range(1, 10)] // range da velocidade do proj�til
    [SerializeField] private float speed = 10f; // velocidade do proj�til

    [Range(1, 10)] // range do tempo que o proj�til vai desaparecer
    [SerializeField] private float lifetime = 5f; // tempo de vida do proj�til

    private Rigidbody2D rigidBody; // gravidade do proj�til

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
