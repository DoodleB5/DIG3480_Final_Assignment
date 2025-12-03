using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootRotation : MonoBehaviour
{
     public float rotationSpeed = 90f;

     public float maxLeftAngle = -60f;
     public float maxRightAngle = 60f;

     private float currentAngle = 0f;

     void Update()
     {
        float horizontalInput = 0f;

         if(Input.GetKey(KeyCode.O))
         {
             horizontalInput = -1f;
         }
         if(Input.GetKey(KeyCode.P))
         {
             horizontalInput = 1f;
         }

        if(horizontalInput != 0f)
         {
             currentAngle += horizontalInput * rotationSpeed * Time.deltaTime;

            if(currentAngle<maxLeftAngle)
            {
                currentAngle = maxLeftAngle;
            }
            else if(currentAngle>maxRightAngle)
            {
                currentAngle = maxRightAngle;
            }

            Vector3 euler = transform.localEulerAngles;
            euler.y = currentAngle;
            transform.localEulerAngles = euler;
         }

     }
}
