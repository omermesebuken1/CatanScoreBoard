using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class numColor : MonoBehaviour
{
   
    void Update()
    {
        if(this.GetComponent<TextMeshProUGUI>().text == "0")
        {
            this.GetComponent<TextMeshProUGUI>().color = new Color32(255,255,255,100);
        }
        else
        {
            this.GetComponent<TextMeshProUGUI>().color = new Color32(255,255,255,255);
        }
    }
}
