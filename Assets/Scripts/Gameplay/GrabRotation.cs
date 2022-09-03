using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRotation : MonoBehaviour
{

    float rotationSpeed = 1f;

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("HEre");

            float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
            float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;

            transform.Rotate(Vector3.down, XaxisRotation);
            transform.Rotate(Vector3.right, YaxisRotation);
        }
    }
}
