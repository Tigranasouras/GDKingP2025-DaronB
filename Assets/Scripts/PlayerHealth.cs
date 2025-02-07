using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthSlider;
    public float maxHealth = 100f;
    public float health;
    public bool isDead;
    

    void Start(){
        health = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = health;
        isDead = false;
    }

    public void takeDamage(float damage){
        health = Mathf.Max(health - damage, 0);
        healthSlider.value = health;

    }

    public void healHealth(float heal){
        health = Mathf.Max(health + heal, 0);
    }

    

        public void Update(){
            if(healthSlider.value != health){
                healthSlider.value = health;
            }

            if(health  == 0 ){
            GameObject player = GameObject.FindWithTag("Player");
            player.GetComponentInChildren<PlayerOverhead>().Die();

            }


        }




}
