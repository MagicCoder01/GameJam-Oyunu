using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject Player;

    bool ab,ba;

    // Start is called before the first frame update
    void Start()
    {
        ab =false;
        ba=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(a.transform.position,Player.transform.position) <= 5f )
        {
            if( Input.GetKeyDown(KeyCode.E)){

            ab = true;
            a.SetActive(false);
            }

        }
        
            
        if(Vector3.Distance(b.transform.position,Player.transform.position) <= 5f )
        {
            
            if( Input.GetKeyDown(KeyCode.E)){
            ba = true;
            b.SetActive(false);
            }

        }
        
            
        
        if(ab && ba)
        {
            yeniSahne.finishLevel = true;
        }
        
        
    }
}
