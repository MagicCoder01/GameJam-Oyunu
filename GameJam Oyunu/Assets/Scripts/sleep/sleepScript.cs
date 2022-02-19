using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleepScript : MonoBehaviour
{
    public Animator animator;
    public Transform player;
    public GameObject cam;

    private void Start()
    {
        StartCoroutine(animatorFalse());

    }
    IEnumerator animatorFalse() 
    {
        yield return new WaitForSeconds(2.5f);
        animator.enabled = !animator.enabled;
        player.rotation = Quaternion.identity;
        cam.GetComponent<cameraMove>().enabled = true;
    }
}
