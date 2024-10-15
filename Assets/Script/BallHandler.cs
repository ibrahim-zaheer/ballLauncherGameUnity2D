using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallHandler : MonoBehaviour
{
    private Camera mainCamera;
    void Start()
    {
        mainCamera = Camera.main;
    }


    // Update is called once per frame
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed)
        {
            return;
        }

        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
        //the ScreenToWorldPoint by default accepts vector 3 but it will also take Vector2
        // and convert it to Vector3
        Vector3 worldPosition =  mainCamera.ScreenToWorldPoint(touchPosition);   
        Debug.Log(worldPosition);

    }
}
