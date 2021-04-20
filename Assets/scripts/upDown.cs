using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upDown : MonoBehaviour
{
    public GameObject Object;
    private bool _up;
    private bool _down;
    public float scale = 0.1f;

    void Update()
    {
        if (_up)
        {
            transform.Translate(new Vector3(0, 1, 0)*scale*scale);
        }
        if (_down)
        {
            transform.Translate(new Vector3(0, -1, 0)*scale*scale);
        }

    }

    public void OnPressUp()
    {
        _up = true;
    }

    public void OnReleaseUp()
    {
        _up = false;
    }
    public void OnPressDown()
    {
        _down = true;
    }

    public void OnReleaseDown()
    {
        _down = false;
    }
}
