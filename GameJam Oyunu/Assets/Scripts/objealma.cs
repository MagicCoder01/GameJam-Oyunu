using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objealma : MonoBehaviour
{
    public Transform point;
    public float rangeSpahere;
    public LayerMask LayerObje;
    public Camera cam;

    Rigidbody rbObje;
    public float maxDistance = 20f;
    GameObject cube;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (rbObje)
            {
                rbObje.isKinematic = false;
                rbObje.useGravity = true;
                rbObje = null;
                cube.transform.parent = null;
            }
            else
            {
                Collider[] cols = Physics.OverlapSphere(point.position, rangeSpahere, LayerObje);
                foreach (Collider obje in cols)
                {
                    rbObje = obje.transform.GetComponent<Rigidbody>();
                    rbObje.isKinematic = true;
                    rbObje.useGravity = false;
                    
                    
                    cube = obje.gameObject;
                    cube.transform.parent = point.transform;

                }
            }

        }

    }
    void OnDrawGizmosSelected() 
    {
        Gizmos.DrawWireSphere(point.position, rangeSpahere);
    }
}

