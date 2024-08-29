using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private void Update()
    {
        
    }

    public Vector2 GetTouchDeltaPosition()
    {
        if (Input.touchCount > 0)
        {
            return Input.GetTouch(0).deltaPosition;
        }

        return Vector2.zero;
    }

    public bool IsTheTouchOnScreen()
    {
        if (Input.touchCount > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
