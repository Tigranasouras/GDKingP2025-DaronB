using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D body;
    public float speed;

    public float dodgeDistance = 3.0f; // How far player dodges
    public float doubleTapTime = 0.3f; // Time allowed between taps
    private float lastTapTime = -1; // Tracks when the shift was last tapped




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(xInput, yInput).normalized;
        body.velocity = direction * speed;
        DetectDoubleTap();
    }


#region Dodge Logic
    private void DetectDoubleTap(){
        if(Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)){
          if(Time.time - lastTapTime <= doubleTapTime) 
          {
            Dodge(); // Call Dodge if double-taooed
          } 

          lastTapTime = Time.time; //Update the last tap time
        }
    }

    private void Dodge(){
        Vector3 dodgeDirection = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0).normalized; 

         if (dodgeDirection == Vector3.zero) //if no movement, then simply go forward
        {
            dodgeDirection = transform.up;
        }

        transform.position += dodgeDirection * dodgeDistance;  // Move the player in the dodge direction
        //Debug.Log("Dodged in direction: " + dodgeDirection);

    }
#endregion

}
