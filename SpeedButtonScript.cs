using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedButtonScript : MonoBehaviour
{


    
    public Sprite SpeedButtonDown;
    public Sprite SpeedButtonUp;
    private float boostTimer = 20f;



   
    // Start is called before the first frame update
    private void Start()
    {
        
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(boostTimer >= 20)
        {
            this.gameObject.GetComponent<Image>().sprite = SpeedButtonUp;

        }
        boostTimer += Time.deltaTime;
        
    }
    public void SkillSpeedButton()
    {
        if(boostTimer >= 20)
        {

        
        
        this.gameObject.GetComponent<Image>().sprite = SpeedButtonDown;
        boostTimer = 0;
        

        }
        

    }
}
