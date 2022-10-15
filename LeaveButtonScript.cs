using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveButtonScript : MonoBehaviour

{
    public GameObject Background;
    public void LeaveButtonFunction()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
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
