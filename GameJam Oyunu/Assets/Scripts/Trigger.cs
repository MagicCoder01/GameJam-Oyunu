using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public Text Tgr;


    void Start()
    {
        Tgr.text = "Aga ilah deðiliz silah deðiliz büyütmeyin bu kadar";
    }

    void OnTriggerEnter(Collider collider)
    {
        if (this.gameObject.tag == "Trigger1")
        {
            Tgr.text = "Abi deðilsin ama taþþaklý adamsýn yani";
        }
        if (this.gameObject.tag == "Trigger2")
        {
            Tgr.text = "Kübü býrak";
        }

    }
}
