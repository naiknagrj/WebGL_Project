using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOut : MonoBehaviour
{
    public GameObject Object;

    private bool _ZoomIn;
    private bool _ZoomOut;
  

    //object scale speed
    public float Scale = 2.0f;
    public float mul = 0.5f;
    float Max = 5;
    float Min = 1;

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(
          Mathf.Clamp(transform.localScale.x, Min, Max),
          Mathf.Clamp(transform.localScale.y, Min, Max),
          Mathf.Clamp(transform.localScale.z, Min, Max)
     ); transform.localScale = new Vector3(
           Mathf.Clamp(transform.localScale.x, Min, Max),
           Mathf.Clamp(transform.localScale.y, Min, Max),
           Mathf.Clamp(transform.localScale.z, Min, Max)
      );
        if (_ZoomIn)
        {
            //make a bigger object
            Object.transform.localScale += new Vector3(Scale, Scale, Scale)*mul;
        }

        if (_ZoomOut)
        {
            //make a small object
            Object.transform.localScale -= new Vector3(Scale, Scale, Scale)*mul;
        }
        

    }

   


    //Make object scaled big
    public void OnPressZoomIn()
    {
        _ZoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        _ZoomIn = false;
    }

    //Make object scaled small
    public void OnPressZoomOut()
    {
        _ZoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        _ZoomOut = false;
    }
}
