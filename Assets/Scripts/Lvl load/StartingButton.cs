using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingButton : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Zone 1");
    }
    //https://forum.unity.com/threads/using-a-button-to-switch-scenes.379945/
    //by orb
}
