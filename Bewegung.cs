using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegung : MonoBehaviour



{
    public Vector2 speed = new Vector2(50,50);
   
    

    public void Start()
    {
        
    }
    
        
        
    
   


    
    
    


    

    
    public void Update()

    {
        
        

        Vector3 movement = new Vector3(0, -5, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
        
    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        
    }
   
    
}
