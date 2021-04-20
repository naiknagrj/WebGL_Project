using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDownM : MonoBehaviour
{

    private Vector3 mOffset;
    private float mZCoord;
    private float mXCoord;


    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; // Store offset = gameobject world pos - mouse world pos
        mXCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).x;
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        mousePoint.x = mXCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

}