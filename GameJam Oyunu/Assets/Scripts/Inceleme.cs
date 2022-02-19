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

    PlayerController fps;

    Camera cam;
    float camfield;
    // Start is called before the first frame update
    void Start()
    {
        fps = GetComponent<PlayerController>();
        cam = kamera.GetComponent<Camera>();
        camfield = cam.fieldOfView;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(kamera.transform.position, kamera.transform.forward, out hit, Mesafe))
        {
            if (hit.distance <= Mesafe && hit.collider.gameObject.tag == "Deneme")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (!view)
                    {
                        view = true;
                        objpos = hit.transform.position;
                        objrot = hit.transform.rotation;
                        objscale = hit.transform.localScale;
                        obj = hit.transform.gameObject;

                        IObje Iobj = hit.transform.GetComponent<IObje>();
                        Iobj.view = true;

                        fps.enabled = false;
                    }
                }
            }
        }

        if(view)
        {
            IObje Iobj = obj.GetComponent<IObje>();

            Vector3 my = kamera.transform.position + kamera.transform.forward / 0.8f;

            obj.transform.position = Vector3.Slerp(obj.transform.position, my, 1);
            if (Iobj.buyuk == true)
                obj.transform.localScale = objscale / 2;
            else
                obj.transform.localScale = objscale * 2;

            if (Input.GetKeyDown(KeyCode.F))
            {
                view = false;
                Iobj.view = false;

                obj.transform.position = Vector3.Slerp(obj.transform.position, objpos, 1);
                obj.transform.localScale = objscale;
                obj.transform.rotation = Quaternion.Slerp(obj.transform.rotation, objrot, 1);

                fps.enabled = true;
            }

            if(Input.GetKey(KeyCode.LeftShift))
            {
                cam.fieldOfView = Mathf.Lerp(camfield, camfield / 2.5f, 1);
            }
            else
            {
                cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, camfield, 1);
            }
        }
    }
}
