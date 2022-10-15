using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InvisibleButtonScript : MonoBehaviour
{


    
    public Sprite InvisibleButtonDown;
    public Sprite InvisibleButtonUp;
    private float InvisibleTimer = 60f;



   
    // Start is called before the first frame update
    private void Start()
    {
        
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(InvisibleTimer >= 60)
        {
            this.gameObject.GetComponent<Image>().sprite = InvisibleButtonUp;

        }
        InvisibleTimer += Time.deltaTime;
        
    }
    public void InvisibleSpeedButton()
    {
        if(InvisibleTimer >= 60)
        {

        
        
        this.gameObject.GetComponent<Image>().sprite = InvisibleButtonDown;
        InvisibleTimer = 0;
        

        }
        

    }
}
