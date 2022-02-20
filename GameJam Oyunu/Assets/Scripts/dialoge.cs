using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialoge : MonoBehaviour
{
    public AudioSource audioDisplay;
    public AudioClip[] audioClips;
    private int index;
    public float typingSpeed;

    

    private void Start()
    {
        index = 0;
        
    }
    private void Update()
    {
        if(!audioDisplay.isPlaying)
        {
            index++;
            
            StartCoroutine(Type());
        }
    }
    IEnumerator Type() 
    {
        yield return new WaitForSeconds(0.2f);
        audioDisplay.clip = audioClips[index];
            audioDisplay.Play();
            
        
        
    
    }
    
    
}
