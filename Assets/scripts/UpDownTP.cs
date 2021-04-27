using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpDownTP : MonoBehaviour
{
    
    public float Speed = 0.2f;
    bool ismouseheld;
    Vector2 currentMousePosition;
    Vector2 mouseDeltaPosition;
    Vector2 lastMousePosition;
    bool istouchpadactive;
    private void Start()
    {
        currentMousePosition = Input.mousePosition;
        lastMousePosition = currentMousePosition;
        mouseDeltaPosition = currentMousePosition - lastMousePosition;
    }
    void Update()
    {
        if (istouchpadactive)
        {
            currentMousePosition = Input.mousePosition;
            mouseDeltaPosition = currentMousePosition - lastMousePosition;
            transform.Translate(0f, mouseDeltaPosition.y * Speed*Speed*Speed, 0f);
            lastMousePosition = currentMousePosition;
        }
    }
    public void ActivateTouchpad()
    {
        istouchpadactive = true;
    }
    public void DeactivateTouchpad()
    {
        istouchpadactive = false;
    }
}