using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HittingBalloons : MonoBehaviour
{


    public int health = 10;



    public GameObject balloonDeathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }


    }


    void Die()
    {
        Instantiate(balloonDeathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
