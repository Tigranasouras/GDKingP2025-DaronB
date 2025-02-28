using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBehavior : MonoBehaviour
{
    public float speed = 10.0f;
    public Vector2 newPosition;
    public Vector3 mousePosG;
    Camera cam;
  

    // Update is called once per frame
    void Update()
    {
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = Vector2.MoveTowards(transform.position, mousePosG, speed*Time.fixedDeltaTime);
        transform.position = newPosition;
        
    }
}
