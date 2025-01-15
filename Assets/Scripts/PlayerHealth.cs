using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

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

    private void Die(){
        Debug.Log("I have died");
        Destroy(gameObject);
    }

        public void Update(){
            if(healthSlider.value != health){
                healthSlider.value = health;
            }
        }




}
