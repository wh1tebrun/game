using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NachKontrolle : MonoBehaviour
{
    bool isPressed = false;
    public GameObject balloon;
    public float Force;

    void Update()
    {
        if( isPressed)
        {
            balloon.transform.Translate(Force * Time.deltaTime, 0, 0);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }


    public void InPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }





}
