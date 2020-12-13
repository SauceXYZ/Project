using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRules : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Rules");
    }
    //https://forum.unity.com/threads/using-a-button-to-switch-scenes.379945/
    //by orb
}
