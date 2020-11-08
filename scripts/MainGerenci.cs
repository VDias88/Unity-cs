using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGerenci : MonoBehaviour
{
    // Funções simples para esconder cursor ao iniciar 
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
