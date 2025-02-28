using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBehaviour : MonoBehaviour
{
    public float speed = 10.0f;
    public Vector2 newPosition;
    public Vector3 mousePosG;
    private Camera cam;
    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();

         cam = Camera.main;
        if (cam == null)
        {
            Debug.Log("Camera not found, Bozo.");
        }
       
    }
  

    // Update is called once per frame
    void Update()
    {
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }
    
    void FixedUpdate()
    {
        newPosition = Vector2.MoveTowards(transform.position, mousePosG, speed * Time.fixedDeltaTime);
        body.MovePosition(newPosition); //transform.position = newPosition;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string collided = collision.gameObject.tag;
        Debug.Log("Collided with " + collided);
        if (collided == "Ball" || collided == "Wall")
        {
            Debug.Log("Game Over, Poser.");
        }
    }
}
