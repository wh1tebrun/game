using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BreakButtonScript : MonoBehaviour
{


    
    public Sprite BreakButtonDown;
    public Sprite BreakButtonUp;
    private float BreakTimer = 45f;



   
    // Start is called before the first frame update
    private void Start()
    {
        
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(BreakTimer >= 45)
        {
            this.gameObject.GetComponent<Image>().sprite = BreakButtonUp;

        }
        BreakTimer += Time.deltaTime;
        
    }
    public void BreakSpeedButton()
    {
        if(BreakTimer >= 45)
        {

        
        
        this.gameObject.GetComponent<Image>().sprite = BreakButtonDown;
        BreakTimer = 0;
        

        }
        

    }
}
