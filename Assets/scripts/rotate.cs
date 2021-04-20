using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject Object;
    private bool _rotateR;
    private bool _rotateL;

    void Update()
    {
        if (_rotateR)
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }
        if (_rotateL)
        {
            transform.Rotate(new Vector3(0, -1, 0));
        }

    }

    public void OnPressR()
    {
        _rotateR = true;
    }

    public void OnReleaseR()
    {
        _rotateR = false;
    }
    public void OnPressL()
    {
        _rotateL = true;
    }

    public void OnReleaseL()
    {
        _rotateL = false;
    }
}

