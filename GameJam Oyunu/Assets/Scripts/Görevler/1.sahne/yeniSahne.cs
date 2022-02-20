using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yeniSahne : MonoBehaviour
{
    public static bool finishLevel;
    public int nextSceneNo;
    public Animator Kararma;
    // Start is called before the first frame update
    void Start()
    {
        finishLevel = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(finishLevel)
        {
            StartCoroutine(finish());
            Kararma.SetTrigger("kararma");

        }

    }
    IEnumerator finish()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(nextSceneNo);
        finishLevel = false;


    }
}
