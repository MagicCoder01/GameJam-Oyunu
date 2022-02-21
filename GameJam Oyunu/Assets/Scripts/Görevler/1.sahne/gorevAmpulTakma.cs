using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gorevAmpulTakma : MonoBehaviour
{
    public Transform lampPoint;
    public Material matLamp;
    public Transform a;
    public Transform player;
     bool lampoff;
    public GameObject light;
    public GameObject Dirlight;
    GameObject lamp;
    public bool MaterialChanger;
    public door kapikodu;
    public GameObject ligh2;
    // Start is called before the first frame update
    void Start()
    {
        lampoff = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(MaterialChanger){   
                
        if(!lampoff && Input.GetKey(KeyCode.E) && Vector3.Distance(a.transform.position,player.transform.position) <= 1.5f)
        {
            lamp.SetActive(false);
            ligh2.SetActive(true);
            Dirlight.GetComponent<Light>().intensity = 1;
            kapikodu.enabled = true;


            
            
        }}
        
                 
        
    
    }
    private void OnTriggerEnter(Collider other) {
       if(MaterialChanger){
        if(other.tag == "lamp")
        {
            lamp  = other.gameObject;
            other.transform.parent = null;
            other.transform.position = lampPoint.transform.position;
           
            other.transform.rotation =  Quaternion.Euler(-90f,lampPoint.transform.rotation.y,lampPoint.transform.rotation.z);
            other.transform.GetComponent<Rigidbody>().isKinematic = true;
            other.transform.parent = lampPoint.transform;
            
        
        
        }
        }
        if(other.tag == "meyve")
        {
            other.transform.parent = null;
            other.transform.position = lampPoint.transform.position;
            other.transform.rotation =  Quaternion.Euler(-90f,lampPoint.transform.rotation.y,lampPoint.transform.rotation.z);
            lampPoint.GetComponent<Rigidbody>().isKinematic=true;
            lampoff = true;
            other.transform.GetComponent<Rigidbody>().isKinematic = true;
            other.transform.parent = lampPoint.transform;
            yeniSahne.finishLevel = true;

        }
        
    }
}
