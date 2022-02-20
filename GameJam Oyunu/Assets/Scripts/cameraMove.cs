using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform player;
    

    public float x;
    

    float y;
    public float sent;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        x += Input.GetAxis("Mouse X")* sent;
        y += -Input.GetAxis("Mouse Y") * sent;

        y = Mathf.Clamp(y,-90,90);
        transform.localRotation = Quaternion.Euler(y,transform.rotation.y,transform.rotation.z);
      
        player.transform.localRotation = Quaternion.Euler(player.transform.rotation.x,x,player.transform.rotation.z);


    }
}
