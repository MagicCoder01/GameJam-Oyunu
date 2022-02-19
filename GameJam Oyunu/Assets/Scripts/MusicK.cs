using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicK : MonoBehaviour
{
    private static MusicK obje = null;

    void Awake()
    {
        if (obje == null)
        {
            obje = this;
            DontDestroyOnLoad(this);

            SceneManager.sceneLoaded += SahneYuklendi;
        }
        else if (this != obje)
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= SahneYuklendi;
    }

    // Yeni bir sahne yüklenince çaðrýlýr
    void SahneYuklendi(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Sokak")
        {
            obje = null;
            Destroy(gameObject);
        }
    }
}
