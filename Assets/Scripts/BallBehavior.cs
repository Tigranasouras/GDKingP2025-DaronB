using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float minX = -8.01f;
    public float minY = 4.16f;
    public float maxX = 7.8f;
    public float maxY = 4.34f;
    public float minSpeed;
    public float maxSpeed;
    public Vector2 targetPosition;

    public int secondsToMaxSpeed;

    void Start(){
        secondsToMaxSpeed = 30;
        minSpeed = 0.75f;
        maxSpeed = 2.0f;


        targetPosition = getRandomPosition();;
    }



    void Update()
    {

        UnityEngine.Vector2 currentPos = gameObject.GetComponent<Transform>().position;
        if(targetPosition != currentPos){
            float currentSpeed = minSpeed;
            UnityEngine.Vector2 newPosition = UnityEngine.Vector2.MoveTowards(currentPos, targetPosition, currentSpeed);
        }
        
        
        getRandomPositon();


    }

      private  UnityEngine.Vector2 getRandomPosition(){
        float randomX = Random.Range(minX, maxX);
        
    }
}
