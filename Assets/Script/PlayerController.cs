using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] Ball ball;
   [SerializeField] Camera cam;
   [SerializeField] Transform cameraPivot;
   [SerializeField] Vector2 camSensitivity;

    Vector3 lastMousePosition;

   void Update()
   {
    if(Input.GetMouseButton(0))
    {
        var delta = Input.mousePosition - lastMousePosition;

        cameraPivot.transform.RotateAround(
            ball.Position, 
            Vector3.up, 
            delta.x*camSensitivity.x);

        cameraPivot.transform.RotateAround(
            ball.Position, 
            cam.transform.right, 
            -delta.y*camSensitivity.y);

        var angle  = Vector3.SignedAngle(
            Vector3.up, cam.transform.up, cam.transform.right);

        if(angle < 3) 
            cameraPivot.transform.RotateAround(
            ball.Position,
            cam.transform.right,
            3 - angle);
        
        else if(angle > 65)
            cameraPivot.transform.RotateAround(
            ball.Position,
            cam.transform.right,
            65 - angle);
    }

    lastMousePosition = Input.mousePosition;
   
    }
}
