using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneDegisme : MonoBehaviour
{
    public void OtherScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
