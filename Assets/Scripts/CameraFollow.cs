using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    private Transform target;
    


    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if(player != null)
        {
            target = player.transform;
        }
        else
        {
            Debug.Log("Player not found, Bozo.");
        }
    }

    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
        
    }
}
