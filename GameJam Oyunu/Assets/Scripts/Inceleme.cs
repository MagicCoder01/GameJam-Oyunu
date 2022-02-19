using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Inceleme : MonoBehaviour
{
    public GameObject kamera, obj;

    public float Mesafe;

    bool view;

    Vector3 objpos;
    Quaternion objrot;
    Vector3 objscale;


    Camera cam;
    float camfield;
    // Start is called before the first frame update
    void Start()
    {
        cam = kamera.GetComponent<Camera>();
        camfield = cam.fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
