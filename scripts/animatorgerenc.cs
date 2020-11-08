using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorgerenc : MonoBehaviour
{
    //Classe usada para gerenciar animações 
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //animação ao pressionar w
        if (Input.GetKey(KeyCode.W))
        {
            anim.Play("metarigwalking");
        }
        //animação anterior para para iniciar animação padrao(parado)
        if (Input.GetKeyUp(KeyCode.W)) {
            anim.Play("metarigstandby",-1,0f);
            
        }
    }
}
