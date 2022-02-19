using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IObje : MonoBehaviour
{
    public bool view;

    public float Hýz = 2;

    public bool buyuk;

    BoxCollider col;

    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    void FixedUpdate()
    {
        if (view)
        {
            float X = Input.GetAxis("Mouse X") * Hýz;
            float Y = Input.GetAxis("Mouse Y") * Hýz;

            if (Input.GetMouseButton(0))
            {
                transform.Rotate(0, X, 0);
            }
            else
            {
                transform.Rotate(X, 0, Y);
            }

            col.enabled = false;
        }
        else
            col.enabled = true;
    }
  
}
