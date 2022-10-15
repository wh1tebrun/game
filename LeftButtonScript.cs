using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LeftButtonScript : MonoBehaviour
{
    public Sprite LeftButtonDown;
    public Sprite LeftButtonUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LeftButtonEnter()
    {
        this.gameObject.GetComponent<Image>().sprite = LeftButtonDown;
    }
    public void LeftButtonExit()
    {
        this.gameObject.GetComponent<Image>().sprite = LeftButtonUp;

    }
}
