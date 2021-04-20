using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateM : MonoBehaviour
{
    float speed = 300.0f;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * speed * Mathf.Deg2Rad;
        transform.Rotate(Vector3.up, -rotX);
    
    }
}
