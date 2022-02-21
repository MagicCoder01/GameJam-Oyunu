using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telefonalma : MonoBehaviour
{
    public AudioClip telefonSesi;
    private AudioSource audioS;
    bool telefonAlmak;
    public Transform televizonyon;
    public Transform player;
    public GameObject TV;
    public static bool KumandaElimde;
    public GameObject Scenanager;
    public AudioClip[] diyalogs;
    public int maxIndex;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        KumandaElimde = false;
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
        if(Vector3.Distance(televizonyon.transform.position,player.transform.position) <= 3f){
           
        if(KumandaElimde  && Input.GetKeyDown(KeyCode.E))
        {
            
            TV.SetActive(true);
            yeniSahne.finishLevel = true;
            
           


        }}
        


        
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
        else if(index >= 4)
        
        {
            PlayerController.konusurkenKarakterKilitleme = false;

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
   

}
