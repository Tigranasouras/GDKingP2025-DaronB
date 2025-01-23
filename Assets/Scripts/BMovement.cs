using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMovement : MonoBehaviour
{
    public GameObject target; //Make this find it when initialized
    public GameObject slider; //Make this find it when initialized
    public float speed = 25f;
    public float moveDuration = 2.5f;
    public bool playerHit = false;
    public int damage = 25;

    private Vector2 moveDirection;

    void Start()
    {
        StartCoroutine(MoveTowardsTarget());
    }

  
    private IEnumerator MoveTowardsTarget()
    {
        while (true)
        {
            Vector2 targetPosition = target.transform.position;

            moveDirection = (targetPosition - (Vector2)transform.position).normalized;


            float elapsedTime = 0f; // move towards target for this set duration

            while (elapsedTime < moveDuration)
            {
                transform.position += (Vector3)(moveDirection * speed * Time.deltaTime);
                elapsedTime += Time.deltaTime;

                yield return null;
                if(playerHit == true){

                }

            }
            yield return new WaitForSeconds(0.1f);

        }
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            Debug.Log("Player Hit!");
            
            //references slider game object to give "player" damage
           slider.GetComponentInChildren<PlayerHealth>().takeDamage(damage);
        }

    }
}
