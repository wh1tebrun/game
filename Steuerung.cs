using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;




public class Steuerung : MonoBehaviour
{
    Rigidbody2D rb2d;
    Gun[] guns;
    
    



    public Sprite TriggeredButtonRight;
    public Sprite TriggeredButtonLeft;
    public Sprite TriggeredButtonSkillSpeed;
    public Sprite TriggeredButtonSkillBreak;
    public Sprite TriggeredButtonSkillInvisible;
    public float cloudSpeed;
    public float cloudTimer;
    public bool cloudSlowing;
    
    
     
    
    
   


    

    
    private float shootTimer = 40;
    private float moveSpeed = 5;
    private float upSpeed = 1;
    private float boostTimer;
    private float breakTimer;
    private Collider2D balloon;
    private bool boosting;
    private bool breaking;
    private bool invisible = true;
    private float activationTime;
    private bool eTetiklendiMi;
    public CircleCollider2D collider;
    private float ozelZaman = 50;
    private bool moveLeft, moveRight;
   
    public UnityEvent RightButtonClicked;
    

    public const string RIGHT = "right";
    public const string LEFT = "left";
   

    string buttonPressed;



    bool shoot;




    



    
    void Start()
    {


        guns = transform.GetComponentsInChildren<Gun>();

        moveLeft = false;
        moveRight = false;



        eTetiklendiMi = false;
        collider.enabled = true;
        collider = GetComponent<CircleCollider2D>();
        
        
        activationTime = 10;
        

        
        rb2d = GetComponent<Rigidbody2D>();
        boostTimer = 20;
        breakTimer = 45;
        boosting = false;
        breaking = false;
    }

    public void SkillInvisible()
    {
       
        eTetiklendiMi = true;
    }



    public void SkillBreak()
    {
        if(breakTimer>=44){

        
        breaking = true;
        

        }

    }
    


    public void SkillSpeed()
    {

        if(boostTimer >= 20)
        {
            boosting = true;
            upSpeed = 2;
            
        
            boostTimer = 0;
            
        }
       

    }
    public void SkillBullet()
    {
        //if(shootTimer >=60)
        //{
            shootTimer = 0;
            shoot = true;
            if(shoot)
            {
                shoot = false;
             foreach(Gun gun in guns)
                {
                    gun.Shoot();
             }
           // }
            
        }
        
    }
    

    



    public void MoveLeft()
    {
        moveLeft = true;

    }
     public void MoveRight()
    {
        moveRight = true;

    }
    

    public void StopMoving()
    {
        moveLeft = false;
        moveRight = false;

    }

    
    private void Update()

    {

        
        







        if(moveLeft)
        {
            rb2d.velocity = new Vector2(-moveSpeed, upSpeed);
        }
        else if(moveRight)
        {
            rb2d.velocity = new Vector2(moveSpeed, upSpeed);
        }
        else
        {
            rb2d.velocity = new Vector2(0f, upSpeed);
        }        
       
        if(ozelZaman>= 50){

        
            collider.enabled = true;
            

            }
        
        
     

        
        ozelZaman += Time.deltaTime;
        activationTime += Time.deltaTime;
        breakTimer += Time.deltaTime;
        boostTimer += Time.deltaTime;
        shootTimer += Time.deltaTime;

        

        if(Input.GetKeyDown("e"))
        {
            
           eTetiklendiMi = true;
           
        }

        
        
        
        
            
        

       
       
        if(Input.GetKeyDown("w") && breakTimer>=44)
        {
            breaking = true;
            
            

            }
        
        
        
        
        
        if(boosting)
        {
            
            
            
            
            if(boostTimer >= 3)
            {
                upSpeed = 1;
                
                boosting = false;
            }
        }
        //if (Input.GetKeyDown("q"))
       // {
           // boosting = true;
          //  upSpeed = 2;
           // boostTimer = 0;
        //}

       



         if (Input.GetKey(KeyCode.RightArrow))
        {
            buttonPressed = RIGHT;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            buttonPressed = LEFT;
        }
        
        else
        {
            buttonPressed = null;
        }
       
        
    }
   
    

   // public void FixedUpdate()
   // {
        



       // if(buttonPressed == RIGHT){
          //  rb2d.velocity = new Vector2(moveSpeed, upSpeed);

       // }

       // else if(buttonPressed == LEFT)
       // {
       //     rb2d.velocity = new Vector2(-moveSpeed, upSpeed);

      //  }
        
      //  else
      //  {
        //    rb2d.velocity = new Vector2(0, upSpeed);

      //  }
   // }
   

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
      
        

        
        if (collisionInfo.collider.tag == "wolke" && breakTimer >=45 && breaking)
        {
             breakTimer = 0;
             Destroy(collisionInfo.collider.gameObject);
             breaking = false;
            
          }


        if (collisionInfo.collider.tag == "wolke" &&  activationTime >=11 && eTetiklendiMi && invisible){
          
            
            activationTime = 0;
            eTetiklendiMi = false;
            collider.enabled = false;
            ozelZaman = 49.5f;
            
            
            invisible = false;

            

            }
        
    
        
        



          
        
            
                

                
          


          }
         
         
    


          
            
            

            
          
    

    

        
        

            

            
        

        
        

        
    
    

    }




