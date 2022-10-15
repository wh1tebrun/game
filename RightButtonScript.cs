using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RightButtonScript : MonoBehaviour
{
    public Sprite RightButtonDown;
    public Sprite RightButtonUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RightButtonEnter()
    {
        this.gameObject.GetComponent<Image>().sprite = RightButtonDown;
    }
    public void RightButtonExit()
    {
        this.gameObject.GetComponent<Image>().sprite = RightButtonUp;

    }
}
