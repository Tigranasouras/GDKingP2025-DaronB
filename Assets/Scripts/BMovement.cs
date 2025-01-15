using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMovement : MonoBehaviour
{
    public GameObject target;
    public float speed = 10f;
    public float waitTime = 3.5f;

    private Vector2 targetPosition;
    private bool isMoving = true;

    void Update()
    {
        targetPosition = target.transform.position;
        MoveTowardsTarget();


    }

    private void MoveTowardsTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            Debug.Log("Player Hit!");
        }

    }
}
