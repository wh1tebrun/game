using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayButtonScript : MonoBehaviour

{
    public GameObject Background;
    public void StayButtonFunction()
    {
        Time.timeScale = 1;
        Background.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
