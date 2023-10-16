using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Text Txt;

    private void OnCollisionEnter(Collision collision)
    {
        int x = 0;
        Txt.text = Int32.TryParse(Txt.text, out x) ? (Int32.Parse(Txt.text) + 1).ToString() : "0" ;
    }
}
