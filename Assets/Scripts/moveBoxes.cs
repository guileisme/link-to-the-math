using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Numerics;
using Vector2 = UnityEngine.Vector2;

public class moveBoxes : MonoBehaviour
{
    public Collider2D playerCollider;
    public playerMovement player;
    public float speedBox = 0f;
    Vector2 boxMovement;
    public GameObject box;
    public Rigidbody2D boxRigidBody;
    public BoxCollider2D boxColliderRight;

    private void OnTriggerEnter2D(Collider2D playerCollider) {
        boxRigidBody.isKinematic = true;
        if (player.movement.x == -1)
        {
            boxMovement.x = -1f;
            boxMovement.y = 0f;
        }
        if (player.movement.x == 1)
        {
            boxMovement.x = 1f;
            boxMovement.y = 0f;
        }
        if (player.movement.y == -1)
        {
            boxMovement.x = 0f;
            boxMovement.y = -1f;
        }
        if (player.movement.y == 1)
        {
            boxMovement.x = 0f;
            boxMovement.y = 1f;
        }
        // speedBox = 0.5f;  
        // transform.position = new Vector2 (boxRigidBody.position.x + boxMovement.x, boxRigidBody.position.y + boxMovement.y);
    }

    private void OnTriggerExit2D(Collider2D playerCollider){
        boxRigidBody.isKinematic = false;
        boxMovement.x = 0f;
        boxMovement.y = 0f;
        transform.position = new Vector2 (boxRigidBody.position.x, boxRigidBody.position.y);
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.W)){
            transform.position = new Vector2 (boxRigidBody.position.x + boxMovement.x, boxRigidBody.position.y + boxMovement.y);
        }
        // boxRigidBody.MovePosition(boxRigidBody.position + boxMovement * Time.fixedDeltaTime);
    }
}
