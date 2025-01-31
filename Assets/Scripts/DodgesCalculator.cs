using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UI;

public class DodgesCalculator : MonoBehaviour
{


public TextMeshProUGUI startText;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");

        int dodge = player.GetComponentInChildren<PlayerOverhead>().dodges;

        //Text @ start
        startText.text = "Dodges: " + dodge;
        
    }

    // Update is called once per frame
    void Update()
    {
    GameObject player = GameObject.FindWithTag("Player");

        int dodge = player.GetComponentInChildren<PlayerOverhead>().dodges;

        //Text @ start
        startText.text = "Dodges: " + dodge;
       
        
    }
}
