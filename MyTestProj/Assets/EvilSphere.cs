using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilSphere : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    //static int horde = 1;
    bool val = false;
    /*void Start()
    {
        Debug.Log("Ja Zlaja Sfera! Ja razmnozhajus pri nazhatii probela!");
    }*/

    void OnClick()
    {
        obj.setActive(val);
        val = !val;
    }
}
