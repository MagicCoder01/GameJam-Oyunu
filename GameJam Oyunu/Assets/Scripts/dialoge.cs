using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class dialoge : MonoBehaviour
{
      public AudioClip telefonSesi;
    private AudioSource audioS;
    bool telefonAlmak;
    public int credits;
  

   

    public GameObject Scenanager;
    public AudioClip[] diyalogs;
    public int maxIndex;
    int index;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(telefonucaldir());
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(telefonAlmak && Input.GetKeyDown(KeyCode.E) && index == 0)
        {
            audioS.Stop();
            PlayerController.konusurkenKarakterKilitleme = true;
            
           
            StartCoroutine(max());

           

        }
        
        


        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
            telefonAlmak= true;
            Trigger.eTrue = true;
            

        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player")
        {
            telefonAlmak= false;
            Trigger.eTrue = false;
            

        }
    }
    IEnumerator telefonucaldir()
    {
        yield return new WaitForSeconds(4f);
        audioS.PlayOneShot(telefonSesi);
    }
    IEnumerator max() 
    {
        yield return new WaitForSeconds(0.0001f);
      
       
       if(index < maxIndex){
           audioS.PlayOneShot(diyalogs[index]);
        
        NextPlay();
        }
        else if(index == 7)
        {
            animator.SetTrigger("kararma");
            StartCoroutine(konushma());
        }
        
        
            
        
        
    
    }
    void NextPlay()
    {
        
       
        if(!audioS.isPlaying)
        {
            index++;
            
            StartCoroutine(max());
        }
        if(audioS.isPlaying)
        {
            StartCoroutine(YenidenDene());

        }
    }
    IEnumerator YenidenDene()
    {
        yield return new WaitForSeconds(0.5f);
        NextPlay();
    }
    IEnumerator konushma()
    {
        yield return new WaitForSeconds(3f);
        audioS.PlayOneShot(diyalogs[7]);
        yield return new WaitForSeconds(15f);
        SceneManager.LoadScene(credits);

        
        

        
    }
    
    
}
