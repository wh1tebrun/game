using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStopping : MonoBehaviour
{
    public GameObject Background;
    public GameObject Background2;

  

         void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.collider.tag == "obstacle")
        {
            Time.timeScale = 0;
            Background.SetActive(true);
        }
        if (collision.collider.tag == "win")
        {
            Time.timeScale = 0;
            Background2.SetActive(true);
        }
    }
}