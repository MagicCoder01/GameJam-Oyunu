using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voicePlayer : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audio;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other) {
        if(other.tag == "Player")
        {
            audioSource.PlayOneShot(audio);
            this.transform.GetComponent<Collider>().enabled = !enabled;
            Destroy(gameObject,8f);
        }
    }
}
