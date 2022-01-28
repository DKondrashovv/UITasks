using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject menu;

    void Start()
    {
        //menu.SetActive(false);
    }
    
    public void CloseMenu()
    {
        menu.SetActive(false);
    }
   
}
