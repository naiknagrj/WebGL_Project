using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSelection : MonoBehaviour
{
    public void hideIt(GameObject Obj)
    {
        Obj.SetActive(false);
    }
}
