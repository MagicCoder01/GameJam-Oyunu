using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsEffect : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(this, 15f);
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}
