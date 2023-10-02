using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvilSphere : MonoBehaviour
{
    bool val = false;
    public GameObject TestObj;

    public void Toggle()
    {
        TestObj.SetActive(val);
        val = !val;
    }
}