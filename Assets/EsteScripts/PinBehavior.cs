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

    public float start;
    public float baseSpeed = 2.0f;
    public float dashSpeed = 8.0f;
    public float dashDuration = 0.3f;
    public bool dashing;

    public float cooldownRate = 1.0f;
    public float endLastDash;
    public float cooldown = 0.0f;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        dashing = false;

        cam = Camera.main;
        if (cam == null)
        {
            Debug.Log("Camera not found, Bozo.");
        }

    }
    private void Dash()
    {
        if (dashing == true) {

            float currenttime = Time.time;
            float timeDashing = currenttime - start;
            if (timeDashing > dashDuration) {
                dashing = false;
                speed = baseSpeed;
                cooldown = cooldownRate;
            } else {
                cooldown = cooldown - Time.deltaTime;
                if (cooldown < 0.0f) {
                    cooldown = 0.0f;
                }
                if (cooldown == 0.0 && Input.GetMouseButtonDown(0)) {
                    dashing = true;
                    speed = dashSpeed;
                    start = Time.time;
                }
            }

        }
    }


        // Update is called once per frame
        void Update()
        {
            Dash();
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
