using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class dialoge : MonoBehaviour
{
    public AudioSource audioDisplay;
    public AudioClip[] audioClips;
    private int index;
    public float typingSpeed;
    public static bool go;

    

    
    public void play()
    {
        if(go)
        {
            StartCoroutine(max());
        }
    }
    IEnumerator max() 
    {
        yield return new WaitForSeconds(0.2f);
      audioDisplay.clip = audioClips[index];
        audioDisplay.Play();
        NextPlay();
            
        
        
    
    }
    void NextPlay()
    {
        if(!audioDisplay.isPlaying)
        {
            index++;
            
            StartCoroutine(max());
        }
        if(audioDisplay.isPlaying)
        {
            StartCoroutine(YenidenDene());

        }
    }
    IEnumerator YenidenDene()
    {
        yield return new WaitForSeconds(2f);
        NextPlay();
    }
    
    
}
