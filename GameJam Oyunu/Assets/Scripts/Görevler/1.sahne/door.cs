using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public bool openclosed;
    public float angle;
    public float speed;
    public bool yrot;
    public bool xrot;
    public bool zrot;
    public Vector3 direction;


    public bool InDistance;

    private void Start()
    {
        if(yrot)
        angle = transform.eulerAngles.y;
        if(xrot)
        angle = transform.eulerAngles.x;
        if(zrot)
        angle = transform.eulerAngles.y;
        openclosed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        InDistance = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        InDistance = false;
    }

    private void Update()
    {
        if(yrot){
        if (Mathf.Round(transform.eulerAngles.y) != angle) 
        {
            transform.Rotate(direction * speed);
        
        }
        if (Input.GetKeyDown(KeyCode.E) && InDistance == true && openclosed == false )
        {
            openclosed = true;
            angle = 90;
            direction = Vector3.up;
        }

        else if (Input.GetKeyDown(KeyCode.E) && openclosed == true && InDistance == true)
        {
            openclosed = false;
            angle = 0;
            direction = -Vector3.up;
        }
        }
        if(xrot){
        if (Mathf.Round(transform.eulerAngles.x) != angle) 
        {
            transform.Rotate(direction * speed);
        
        }
        if (Input.GetKeyDown(KeyCode.E) && InDistance == true && openclosed == false )
        {
            openclosed = true;
            angle = 90;
            direction = Vector3.right;
        }

        else if (Input.GetKeyDown(KeyCode.E) && openclosed == true && InDistance == true)
        {
            openclosed = false;
            angle = 0;
            direction = -Vector3.right;
        }
        }
        else if(zrot){
        if (Mathf.Round(transform.eulerAngles.y) != angle) 
        {
           
            transform.Rotate(direction * speed);
        
        }
        if (Input.GetKeyDown(KeyCode.E) && InDistance == true && openclosed == false )
        {
            openclosed = true;
            angle = 90;
            direction = -Vector3.down;
            
        }

        else if (Input.GetKeyDown(KeyCode.E) && openclosed == true && InDistance == true)
        {
            openclosed = false;
            angle = 180;
            direction = Vector3.down;
        }

    }



    }
}
