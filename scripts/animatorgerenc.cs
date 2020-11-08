using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorgerenc : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.Play("metarigwalking");
        }
        
        if (Input.GetKeyUp(KeyCode.W)) {
            anim.Play("metarigstandby",-1,0f);
            
        }
    }
}
