using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
    [SerializeField]
    private Material InitialMaterial;

    [SerializeField]
    private Material green;

    [HideInInspector]
    public bool currentlySelected = false;

    private MeshRenderer myRend;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        ClickMe();
    }

    public void ClickMe()
    {
        if (currentlySelected == false)
        {
            myRend.material = InitialMaterial;
        }
        else
        {
            myRend.material = green;
        }
        
    }

}
