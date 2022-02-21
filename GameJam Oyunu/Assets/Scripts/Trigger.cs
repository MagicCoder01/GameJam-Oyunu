using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public GameObject E;
    public static bool eTrue;
    


   
    private void Update() {
        if(eTrue)
        {
            E.SetActive(true);

        }
        else if(!eTrue)
        {
            E.SetActive(false);
            
        }
    }
}
