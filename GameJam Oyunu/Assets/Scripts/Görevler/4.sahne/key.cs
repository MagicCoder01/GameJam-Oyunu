using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public Transform Player;
    public GameObject keys;
    public door kapiKodu;
    AudioSource AudioSource;
    public AudioClip ses;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Vector3.Distance(keys.transform.position,Player.transform.position) <= 2f)
            {
                
                if(Input.GetKeyDown(KeyCode.E)){
                keys.SetActive(false);
                kapiKodu.enabled  = true;
                AudioSource.PlayOneShot(ses);
                }

            }
           
        
    }
    
}
