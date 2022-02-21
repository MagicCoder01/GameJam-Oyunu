using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public Transform _camera;

    public float moveSpeed = 6f;
    public float jumpForce = 10f;

    public LayerMask Ground;

    bool isGrounded;
    public LayerMask objecsE;
    public static bool konusurkenKarakterKilitleme;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if(!konusurkenKarakterKilitleme){
        //grounding
        isGrounded = Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), 0.4f, Ground);


        //facing direction
        Debug.DrawLine(_camera.position, transform.forward * 2.5f);

        //moving
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed;

        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);

        //setting movement
        Vector3 move = transform.right * x + transform.forward * y;

        rb.velocity = new Vector3(move.x, rb.velocity.y,move.z);
        }
    }
    private void OnTriggerStay(Collider other) {
        if(other.tag == "kumanda" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(other.gameObject);
            telefonalma.KumandaElimde = true;

        }
        if(other.tag == "deadline")
        {
            yeniSahne.finishLevel = true;
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag =="kumanda" || other.tag == "key" || other.tag == "much" )
        {
            Trigger.eTrue = true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag =="kumanda" || other.tag == "key" || other.tag == "much")
        {
            Trigger.eTrue = false;
        }
    }
}
