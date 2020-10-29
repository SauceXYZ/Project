using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Menubutton : MonoBehaviour
{

    public GameObject Menu;
    public PlayerController controller;

    public void OpenMenuClick()
    {
        controller.enabled = false;
        Menu.SetActive(true);
    }
    public void CloseMenuClick()
    {
        controller.enabled = true;
        Menu.SetActive(false);
    }
}
