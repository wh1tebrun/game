using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
     public GameObject Background;

   

   float currentTime = 0f;
   float startingTime = 60f;

   [SerializeField] TMP_Text countdownText; 

   void Start()
   {
        currentTime = startingTime;
   }

   void Update()
   {
      
    currentTime -= 1 * Time.deltaTime;
    countdownText.text = currentTime.ToString ("0");
        if (currentTime <= 0)
        {
         Time.timeScale = 0;
         
          Background.SetActive(true);




      
     

     }
    
   
}


}
