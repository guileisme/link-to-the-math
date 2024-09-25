using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Numerics;
using Vector2 = UnityEngine.Vector2;

public class moveBoxes : MonoBehaviour
{
    public playerMovement player;
    public float speedBox = 0f;
    Vector2 boxMovement;
    public GameObject box;
    public Rigidbody2D boxRigidBody;
    public BoxCollider2D boxColliderRight;

    private void OnTriggerEnter2D(Collider2D other) {
        if (player.movement.x == -1)
        {
            boxMovement.x = -0.5f;
            boxMovement.y = 0f;
        }
        if (player.movement.x == 1)
        {
            boxMovement.x = 0.5f;
            boxMovement.y = 0f;
        }
        if (player.movement.y == -1)
        {
            boxMovement.x = 0f;
            boxMovement.y = -0.5f;
        }
        if (player.movement.y == 1)
        {
            boxMovement.x = 0f;
            boxMovement.y = 0.5f;
        }
        // speedBox = 0.5f;  
        // transform.position = new Vector2 (boxRigidBody.position.x + boxMovement.x, boxRigidBody.position.y + boxMovement.y);

    }

    private Vector2 Vector2(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerExit2D(Collider2D other){
        speedBox = 0f;
        boxMovement.x = 0f;
        boxMovement.y = 0f;
    }
    private void FixedUpdate()
    {
        transform.position = new Vector2 (boxRigidBody.position.x + boxMovement.x, boxRigidBody.position.y + boxMovement.y);
        // boxRigidBody.MovePosition(boxRigidBody.position + boxMovement * Time.fixedDeltaTime);
    }
}
