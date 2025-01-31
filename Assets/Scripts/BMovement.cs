using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMovement : MonoBehaviour
{
    public float speed = 25f;
    public float moveDuration = 2.5f;
    public bool playerHit = false;
    public int damage = 25;
    bool playerTouched;

    private Vector2 moveDirection;
    private DodgesCalculator dodgesCalculator;
    void Start()
    {
        StartCoroutine(MoveTowardsTarget());
            GameObject dodgesCalculator = GameObject.FindWithTag("DodgeScript");

       // DodgesCalculator dodgesCalculator = FindObjectOfType<DodgesCalculator>();
    }

  
    private IEnumerator MoveTowardsTarget()
    {
        while (true)
        {
            playerTouched = false;

            GameObject player = GameObject.FindWithTag("Player");



            Vector2 targetPosition = player.transform.position;

            moveDirection = (targetPosition - (Vector2)transform.position).normalized;


            float elapsedTime = 0f; // move towards target for this set duration

            while (elapsedTime < moveDuration)
            {
                transform.position += (Vector3)(moveDirection * speed * Time.deltaTime);
                elapsedTime += Time.deltaTime;

                yield return null;
                if(playerHit == true){
                    Debug.Log("This doesn't work.");
                    //This is where the logic for updating the dodge counter goes

                }

            }
            yield return new WaitForSeconds(0.1f);

            if(playerTouched != false)
            {
                
            }else{
                player.GetComponentInChildren<PlayerOverhead>().Dodged();

            }

        }
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            Debug.Log("Player Hit!");

             GameObject slider = GameObject.FindWithTag("healthSlider");

            //references slider game object to give "player" damage
           slider.GetComponentInChildren<PlayerHealth>().takeDamage(damage);
    
            GameObject player = GameObject.FindWithTag("Player");
            playerTouched = true;


        }

    }


}
