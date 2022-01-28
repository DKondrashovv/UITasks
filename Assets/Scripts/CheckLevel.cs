using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CheckLevel : MonoBehaviour
{
    [SerializeField] private GameObject Level;
    [SerializeField] private GameObject Menu;
    private void Start()
    {
        
    }

    public void ShowLevel()
    {
        Menu.SetActive(true);
        gameObject.SetActive(false);
        Level.SetActive(true);
        
    }
    
}
