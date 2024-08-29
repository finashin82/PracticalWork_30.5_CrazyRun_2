using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private InputHandler inputHandler;

    [SerializeField] private float ballSpeed;
    
    Vector3 newGravityVector = new Vector3();

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        if (inputHandler.IsTheTouchOnScreen())
        {
            Vector2 currDeltaPos = inputHandler.GetTouchDeltaPosition();

            currDeltaPos *= ballSpeed;

            newGravityVector = new Vector3(-currDeltaPos.x, Physics.gravity.y, -currDeltaPos.y);

            Physics.gravity = newGravityVector;
        }
    }
}
