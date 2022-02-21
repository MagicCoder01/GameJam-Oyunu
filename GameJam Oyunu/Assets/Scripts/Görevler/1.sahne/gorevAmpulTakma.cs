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
    // Start is called before the first frame update
    void Start()
    {
        lampoff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(MaterialChanger){
            if( Vector3.Distance(a.transform.position,player.transform.position) <= 1.5f){
                
                if(lampoff && Input.GetKeyDown(KeyCode.E))
        {
            lamp.GetComponent<MeshRenderer>().material = matLamp;
            Dirlight.GetComponent<Light>().intensity = 1;
            kapikodu.enabled = true;

            light.SetActive(true);
            
        }
        
                 
        }
    }
    }
    private void OnTriggerEnter(Collider other) {
       if(MaterialChanger){
        if(other.tag == "lamp")
        {
            lamp  = other.gameObject;
            other.transform.parent = null;
            other.transform.position = lampPoint.transform.position;
            other.transform.rotation = lampPoint.transform.rotation;
            lampoff = true;
            other.transform.GetComponent<Rigidbody>().isKinematic = true;
            other.transform.parent = lampPoint.transform;
            
        
        
        }
        }
        if(other.tag == "meyve")
        {
            other.transform.parent = null;
            other.transform.position = lampPoint.transform.position;
            other.transform.rotation = lampPoint.transform.rotation;
            lampPoint.GetComponent<Rigidbody>().isKinematic=true;
            lampoff = true;
            other.transform.GetComponent<Rigidbody>().isKinematic = true;
            other.transform.parent = lampPoint.transform;
            yeniSahne.finishLevel = true;

        }
        
    }
}
