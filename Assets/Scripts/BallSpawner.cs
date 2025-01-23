using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    private float ballInterval = 2.5f;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnBall(ballInterval, ballPrefab));
        
    }

    private IEnumerator spawnBall(float interval, GameObject ball){
        yield return new WaitForSeconds(interval);
        GameObject newBall = Instantiate(ball, new Vector3(Random.Range(-5f,5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnBall(interval, ball));
    }

}
