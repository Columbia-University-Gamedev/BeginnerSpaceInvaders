using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Speed at which aliens move horizontally
    public float horizontalBounds = 5.0f; // Maximum horizontal movement range for aliens
    public float moveDownDistance = 0.5f; // Distance to move down when hitting horizontal bounds

    private bool moveRight = true; // Determines the initial direction

    void Update()
    {
        // Calculate the movement vector
        Vector3 movement = Vector3.right * (moveRight ? 1 : -1) * moveSpeed * Time.deltaTime;

        // Move the aliens
        transform.Translate(movement);

        // Check if the aliens hit the horizontal bounds
        if (transform.position.x > horizontalBounds)
        {
            moveRight = false;
            MoveDown();
        }
        else if (transform.position.x < -horizontalBounds)
        {
            moveRight = true;
            MoveDown();
        }
    }

    void MoveDown()
    {
        // Move the aliens down
        Vector3 currentPosition = transform.position;
        currentPosition.y -= moveDownDistance;
        transform.position = currentPosition;
    }
}
